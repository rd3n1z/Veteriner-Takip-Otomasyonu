using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Veteriner_Takip_Otomasyonu.frmRandevular;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmRandevuEkle : Form
    {
        public frmRandevuEkle()
        {
            InitializeComponent();
            HayvanlariGetir();  // Hayvanları ComboBox'a yükle
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private void btn_RandevuEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxHayvanlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir hayvan seçin.");
                return;
            }

            if (cb_Randevu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu türü seçin.");
                return;
            }

            int petId = (int)((dynamic)comboBoxHayvanlar.SelectedItem).PetId;
            DateTime randevuTarihi = dateTimePickerRandevuTarihi.Value;
            string randevuSaati = comboBox1.Text;
            string randevuTuru = cb_Randevu.Text;

            if (string.IsNullOrWhiteSpace(randevuSaati) || !TimeSpan.TryParse(randevuSaati, out TimeSpan saat))
            {
                MessageBox.Show("Lütfen geçerli bir saat seçin.");
                return;
            }

            // Aynı gün ve aynı türde randevu kontrolü
            if (CheckIfRandevuExists(randevuTarihi, petId))
            {
                MessageBox.Show("Bu hayvan için aynı gün içinde başka randevunuz var. Lütfen başka bir tarih seçin.");
                return;
            }



            // Randevu ekleme işlemi
            string randevuQuery = @"
    INSERT INTO randevular (petid, kullaniciId, tarih, saat, randevuTur, durum, AsiMi)
    VALUES (@petId, @userId, @tarih, @saat, @randevuTur, @durum, @asi);";

            string asiQuery = @"
    INSERT INTO Asilar (asiAdi, tarih, petid)
    VALUES (@asiAdi, @tarih, @petId);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction()) // İşlemleri tek bir işlem altında topla
                {
                    try
                    {
                        // Randevu Ekleme
                        using (SqlCommand cmdRandevu = new SqlCommand(randevuQuery, conn, transaction))
                        {
                            cmdRandevu.Parameters.AddWithValue("@userId", frmGirisYap.userId);
                            cmdRandevu.Parameters.AddWithValue("@petId", petId);
                            cmdRandevu.Parameters.AddWithValue("@tarih", randevuTarihi.Date);
                            cmdRandevu.Parameters.AddWithValue("@saat", randevuSaati);
                            cmdRandevu.Parameters.AddWithValue("@durum", "Beklemede");
                            cmdRandevu.Parameters.AddWithValue("@randevuTur", randevuTuru);
                            cmdRandevu.Parameters.AddWithValue("@asi", (randevuTuru.Contains("Aşı") ? 1 : 0));
                            cmdRandevu.ExecuteNonQuery();
                        }

                        // Aşı Türü Randevu ise, Aşı Tablosuna Ekleme
                        if (randevuTuru.Contains("Aşı"))
                        {
                            using (SqlCommand cmdAsi = new SqlCommand(asiQuery, conn, transaction))
                            {
                                cmdAsi.Parameters.AddWithValue("@asiAdi", randevuTuru);
                                cmdAsi.Parameters.AddWithValue("@tarih", randevuTarihi.Date);
                                cmdAsi.Parameters.AddWithValue("@petId", petId);
                                cmdAsi.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit(); // Tüm işlemleri onayla
                        MessageBox.Show("Randevu başarıyla eklendi!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Hata durumunda işlemleri geri al
                        MessageBox.Show("Randevu eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }


        // Randevu var mı diye kontrol etmek için fonksiyon
        private bool CheckIfRandevuExists(DateTime randevuTarihi, int petId)
        {
            string query = @"
        SELECT COUNT(*)
        FROM randevular r
        WHERE r.kullaniciId = @userId 
        AND r.petid = @petId 
        AND r.tarih = @randevuTarihi";  // Tarih ve tür kontrol ediliyor, saat kaldırıldı

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", frmGirisYap.userId);  // Giriş yapan kullanıcı ID'si
                cmd.Parameters.AddWithValue("@petId", petId);  // Seçilen pet ID
                cmd.Parameters.AddWithValue("@randevuTarihi", randevuTarihi.Date);  // Yalnızca tarihi alıyoruz

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();  // Aynı petId, tarih ve türde randevu sayısını alıyoruz
                    return count > 0;  // Eğer sayı 0'dan büyükse, aynı türde randevu var demektir
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Randevu kontrol edilirken bir hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }


        // Hayvanları ComboBox'a yüklemek için fonksiyon
        // Hayvanları ComboBox'a yüklemek için fonksiyon
        private void HayvanlariGetir()
        {
            int userId = frmGirisYap.userId; // Giriş yapan kullanıcı ID'si
            string query = "SELECT petid, hayvanAdi FROM EvcilHayvanlarTablosu WHERE sahipUserId = @userId"; // Kullanıcıya ait hayvanları getir

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<dynamic> hayvanlar = new List<dynamic>();

                        while (reader.Read())
                        {
                            hayvanlar.Add(new
                            {
                                PetId = reader["petid"],  // petid'yi tutuyoruz
                                HayvanAdi = reader["hayvanAdi"].ToString() // Hayvan adını tutuyoruz
                            });
                        }

                        if (hayvanlar.Count > 0)
                        {
                            // Hayvanlar varsa ComboBox'a yükle
                            comboBoxHayvanlar.DataSource = hayvanlar;
                            comboBoxHayvanlar.DisplayMember = "HayvanAdi";  // Görünürde sadece hayvan ismi
                            comboBoxHayvanlar.ValueMember = "PetId";  // Arka planda ise petid tutulur
                        }
                        else
                        {
                            // Hayvan yoksa uyarı ver
                            MessageBox.Show("Randevu alabileceğiniz herhangi bir evcil hayvan bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            comboBoxHayvanlar.Enabled = false; // ComboBox'u pasif yap
                            btn_RandevuEkle.Enabled = false; // Randevu Ekle butonunu da pasif yap
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hayvanlar yüklenirken bir hata oluştu: " + ex.Message);
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
