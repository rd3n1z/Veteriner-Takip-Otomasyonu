
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmAdminEvcilEkle : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmAdminEvcilEkle()
        {
            InitializeComponent();
            SahipleriGetir();
            AddHoverEffect(btn_hyvEkle);
            AddHoverEffect(btnSelectFile);
        }

        private bool IsValidAge(string age)
        {
            // Yaş yalnızca rakamlardan oluşmalı, harfler veya özel karakterler olmamalı
            var regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
            return !regex.IsMatch(age);
        }

        private bool ContainsNonAlphabet(string name)
        {
            // Türkçe karakterler ve alfabetik harfleri kabul eden regex
            string pattern = @"[^a-zA-ZçÇşŞüÜöÖğĞıİ ]"; // Türkçe karakterler de dahil
            return Regex.IsMatch(name, pattern);
        }
        private void AddHoverEffect(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(1, 53, 89); // Hover arka plan rengi
                btn.ForeColor = Color.FromArgb(235, 235, 235); // Yazı rengi değişir
                btn.FlatAppearance.BorderColor = Color.FromArgb(2, 80, 158); // Çerçeve rengini hover'a uyumlu yap
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(0, 102, 204); // Normal arka plan
                btn.ForeColor = Color.White; // Yazı rengini eski haline getir
                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 204); // Çerçeve rengini geri al
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string getAnimalPhoto()
        {
            string path = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Varsayılan açılacak dizin
                openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Tüm Dosyalar (*.*)|*.*"; // Filtreler
                openFileDialog.FilterIndex = 1; // Varsayılan filtre
                openFileDialog.RestoreDirectory = true; // Dizin seçimini hatırlasın mı?

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    pictureBox1.ImageLocation = path;
                }
            }

            return path;
        }

        private void SahipleriGetir()
        {
            string sahipQuery = "SELECT kullanici_adi, userid FROM kullanici_giris";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sahipQuery, con))
            {
                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<dynamic> sahipler = new List<dynamic>();
                        while (reader.Read())
                        {
                            sahipler.Add(new
                            {
                                sahipid = reader["userid"],
                                sahipAdi = reader["kullanici_adi"].ToString()
                            });
                        }

                        cb_Sahip.DataSource = sahipler;
                        cb_Sahip.DisplayMember = "sahipAdi";
                        cb_Sahip.ValueMember = "sahipid";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hayvanlar yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void HayvanEkle()
        {
            string name = txtBox_Name.Text.Trim();
            int age = int.Parse(txtBox_Age.Text.Trim());
            string gender = cb_Cinsiyet.SelectedItem.ToString();
            string species = cb_Tur.SelectedItem.ToString();
            string avatarTuru = "";
            int userid = (int)cb_Sahip.SelectedValue;


            switch (species)
            {
                case "Kedi": avatarTuru = "kedi"; break;
                case "Ördek": avatarTuru = "ordek"; break;
                case "Köpek": avatarTuru = "kopek"; break;
                case "Hamster": avatarTuru = "hamster"; break;
                case "Fare": avatarTuru = "fare"; break;
                case "Tavşan": avatarTuru = "tavsan"; break;
                case "Tavuk": avatarTuru = "tavuk"; break;
                case "Kuş": avatarTuru = "kus"; break;
                default: avatarTuru = "default"; break;
            }

            string insertQuery = "INSERT INTO EvcilHayvanlarTablosu (hayvanAdi, yas, cinsiyet, turu, sahipUserId, avatarTuru, hayvanFoto) " +
                                     "VALUES (@hayvanAdi, @yas, @cinsiyet, @tur, @sahipId, @avatarTuru, @foto)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@hayvanAdi", name);
                    cmd.Parameters.AddWithValue("@yas", age);
                    cmd.Parameters.AddWithValue("@cinsiyet", gender);
                    cmd.Parameters.AddWithValue("@tur", species);
                    cmd.Parameters.AddWithValue("@sahipId", userid);
                    if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                    {
                        cmd.Parameters.AddWithValue("@foto", pictureBox1.ImageLocation);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value); // Eğer fotoğraf seçilmemişse null olarak kaydedilir.
                    }
                    cmd.Parameters.AddWithValue("@avatarTuru", avatarTuru);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Evcil hayvan başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            getAnimalPhoto();
        }

        private void btn_hyvEkle_Click(object sender, EventArgs e)
        {
            // Yaşın geçerli olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBox_Age.Text) || IsValidAge(txtBox_Age.Text))
            {
                MessageBox.Show("Lütfen geçerli bir yaş giriniz.");
                return;
            }

            // İsim alanının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBox_Name.Text))
            {
                MessageBox.Show("Lütfen ismini giriniz.");
                return;
            }

            // İsimde geçersiz karakter olup olmadığını kontrol et
            if (ContainsNonAlphabet(txtBox_Name.Text))
            {
                MessageBox.Show("Lütfen isme yalnızca harf ve boşluk giriniz.");
                return;
            }


            // Cinsiyet ve Tür seçimi yapılmış mı kontrol et
            if (cb_Cinsiyet.SelectedIndex == -1 || cb_Tur.SelectedIndex == -1 || cb_Sahip.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tür, sahip veya cinsiyet seçimini boş bırakmayınız!", "Uyarı");
                return;
            }
            HayvanEkle();
        }

        private void frmAdminEvcilEkle_Load(object sender, EventArgs e)
        {

        }
    } 
}
