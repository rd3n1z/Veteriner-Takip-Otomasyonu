using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Veteriner_Takip_Otomasyonu.frmRandevular;
using System.IO;

namespace Veteriner_Takip_Otomasyonu
{
    
    public partial class frmAşıTakvimi : Form
    {
        public class Randevu
        {
            public string HayvanAdi { get; set; }
            public string Kullanici_Adi { get; set; }
            public DateTime Tarih { get; set; }
            public string Durum { get; set; }
            public string HayvanFoto { get; set; }
            public TimeSpan saat { get; set; }
            public string hayvanTur { get; set; }
            public string randevuTur { get; set; }
            public string avatarTur { get; set; }
            public int PetId { get; set; }
        }
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmAşıTakvimi()
        {
            InitializeComponent();
        }

        private void frmAşıTakvimi_Load(object sender, EventArgs e)
        {
            RandevulariGetirVeGoster();
        }

        private void RandevulariGetirVeGoster()
        {
            int userId = frmGirisYap.userId;  // Giriş yapan kullanıcı ID'sini alıyoruz
            string userRole = frmGirisYap.userRole; // Kullanıcı rolü (ör. admin, user)
            string aramaMetni = txtBox_AramaMotoru.Text.ToLower(); // Arama kutusundan girilen metin

            // Kullanıcı rolüne göre SQL sorgusunu oluştur
            string query = @"
            SELECT 
                h.hayvanAdi, 
                k.kullanici_adi, 
                r.tarih, 
                r.durum, 
                h.hayvanFoto,
                h.turu,
                r.saat,
                r.randevuTur,
                r.petid,
                h.avatarTuru
            FROM 
                randevular r
            JOIN 
                EvcilHayvanlarTablosu h ON r.petid = h.petid
            JOIN 
                kullanici_giris k ON r.kullaniciId = k.userid
            WHERE 
                (@userRole = 'admin' OR r.kullaniciId = @userId)
                AND (h.hayvanAdi LIKE @aramaMetni OR k.kullanici_adi LIKE @aramaMetni OR h.turu LIKE @aramaMetni) 
                AND AsiMi = 1 
                AND r.durum != 'Geçmiş' ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@userRole", userRole);
                cmd.Parameters.AddWithValue("@aramaMetni", "%" + aramaMetni + "%"); // Arama metni parametre olarak eklendi

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Randevu> randevuListesi = new List<Randevu>();

                        while (reader.Read())
                        {
                            Randevu randevu = new Randevu
                            {
                                HayvanAdi = reader["hayvanAdi"].ToString(),
                                Kullanici_Adi = reader["kullanici_adi"].ToString(),
                                Tarih = Convert.ToDateTime(reader["tarih"]),
                                Durum = reader["durum"].ToString(),
                                HayvanFoto = reader["hayvanFoto"].ToString(),
                                avatarTur = reader["avatarTuru"].ToString(),
                                hayvanTur = reader["turu"].ToString(),
                                saat = reader["saat"] != DBNull.Value ? (TimeSpan)reader["saat"] : TimeSpan.Zero,
                                randevuTur = reader["randevuTur"].ToString(),
                                PetId = Convert.ToInt32(reader["petid"])
                            };

                            randevuListesi.Add(randevu);
                        }

                        RandevulariGoster(randevuListesi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Randevular yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void RandevulariGoster(List<Randevu> randevuListesi)
        {
            flowLayoutPanel1.Controls.Clear(); // Eski randevuları temizle

            int userId = frmGirisYap.userId;
            string query;
            string arama = txtBox_AramaMotoru.Text;

            // Kullanıcı rolü admin mi?
            bool isAdmin = frmGirisYap.userRole == "admin"; // Admin kontrolü

            if (isAdmin) // Eğer kullanıcı adminse, tüm evcil hayvanları getir
            {
                if (string.IsNullOrEmpty(arama))
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu"; // Admin tüm evcil hayvanları görebilir
                }
                else
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE hayvanAdi LIKE @arama";
                }
            }
            else // Kullanıcı normalse, sadece kendi evcil hayvanlarını görebilir
            {
                if (string.IsNullOrEmpty(arama))
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE sahipUserId = @userId";
                }
                else
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE sahipUserId = @userId AND hayvanAdi LIKE @arama";
                }
            }

            foreach (var randevu in randevuListesi)
            {
                // Her bir randevu için daha büyük bir panel oluştur
                Panel pnl = new Panel
                {
                    AutoSize = true, // Dinamik boyut
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(255, 207, 74),
                };

                // Hayvan fotoğrafı
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    if (!string.IsNullOrEmpty(arama))
                    {
                        cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");
                    }
                    try
                    {
                        conn.Open();
                        pnl.Controls.Clear();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hayvanFoto = randevu.HayvanFoto; // Randevudan al
                                if (!string.IsNullOrEmpty(hayvanFoto) && File.Exists(hayvanFoto))
                                {
                                    // Fotoğraf varsa göster
                                    PictureBox pb = new PictureBox
                                    {
                                        ImageLocation = hayvanFoto,
                                        SizeMode = PictureBoxSizeMode.StretchImage,
                                        Size = new Size(100, 100),
                                        Location = new Point(10, 10)
                                    };
                                    pnl.Controls.Add(pb);
                                }
                                else
                                {
                                    // Fotoğraf yoksa türüne göre varsayılan avatar ekle
                                    string avatarPath = GetAvatarImagePath(randevu.avatarTur);
                                    if (File.Exists(avatarPath))
                                    {
                                        PictureBox pb = new PictureBox
                                        {
                                            Image = Image.FromFile(avatarPath),
                                            SizeMode = PictureBoxSizeMode.StretchImage,
                                            Size = new Size(100, 100),
                                            Location = new Point(10, 10)
                                        };
                                        pnl.Controls.Add(pb);
                                    }
                                    else
                                    {
                                        MessageBox.Show("avatar ftoosu yok amk");
                                    }

                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex);
                    }


                }

                // Randevu bilgileri
                Label lblBilgi = new Label
                {
                    Text = $"Hayvan: {randevu.HayvanAdi}\nKullanıcı: {randevu.Kullanici_Adi}\nTarih: {randevu.Tarih.ToString("dd MMM yyyy")}\nDurum: {randevu.Durum}\nRandevu Türü: {randevu.randevuTur}\nSaat: {randevu.saat.ToString(@"hh\:mm")}",
                    Location = new Point(120, 10),
                    Size = new Size(250, 150),  // Bilgi etiketini büyüttük
                    ForeColor = Color.DarkSlateGray,  // Metin rengini koyu yeşil yapıyoruz
                    Font = new Font("Arial", 10, FontStyle.Bold),  // Yazı tipini aynı bırakıyoruz
                    AutoSize = false,
                    BackColor = Color.FromArgb(255, 207, 74)// Manuel boyutlandırmayı etkin bırakıyoruz
                };
                pnl.Controls.Add(lblBilgi);

                if (randevu.Durum != "Geçmiş                   ")
                {
                    // İptal Et Butonu
                    Button btnIptal = new Button
                    {
                        Text = "İptal Et",
                        Size = new Size(100, 30),
                        Location = new Point(120, 180),
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 10, FontStyle.Bold)

                    };
                    btnIptal.Click += (sender, args) => IptalEt(randevu); // Butona tıklanınca IptalEt fonksiyonu çalışacak
                    pnl.Controls.Add(btnIptal);
                    btnIptal.FlatStyle = FlatStyle.Flat;
                    btnIptal.FlatAppearance.BorderSize = 0;
                }


                flowLayoutPanel1.AutoScroll = true;
                // FlowLayoutPanel'e ekliyoruz
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }
        private void IptalEt(Randevu randevu)
        {
            string query = @"
            DELETE randevular
            WHERE petid = @petid 
            AND tarih = @tarih 
            AND saat = @saat";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@petid", randevu.PetId);  // PetId'yi kullanıyoruz
                cmd.Parameters.AddWithValue("@tarih", randevu.Tarih);
                cmd.Parameters.AddWithValue("@saat", randevu.saat);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Randevu başarıyla iptal edildi.");
                        RandevulariGetirVeGoster(); // Randevuları tekrar göster
                    }
                    else
                    {
                        MessageBox.Show("Randevu iptal edilirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private string GetAvatarImagePath(string avatarTuru)
        {
            // Avatarları dinamik bir şekilde dönüyoruz
            var avatarDictionary = new Dictionary<string, string>()
            {
                { "kedi", "cat.jpg" },
                { "kopek", "dog.jpg" },
                { "ordek", "civciv.jpg" },
                { "hamster", "hamster.jpg" },
                { "fare", "fare.jpg" },
                { "tavsan", "tavsan.jpg" },
                { "tavuk", "horoz.jpg" },
                { "kus", "kus.jpg" }
            };

            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (avatarDictionary.ContainsKey(avatarTuru.ToLower()))
            {
                return Path.Combine(basePath, avatarDictionary[avatarTuru.ToLower()]);
            }
            else
            {
                return Path.Combine(basePath, "cat.jpg");
            }
        }
        private void txtBox_AramaMotoru_TextChanged(object sender, EventArgs e)
        {
            RandevulariGetirVeGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevulariGetirVeGoster();
        }

        private void btn_rndvAl_Click(object sender, EventArgs e)
        {
            frmRandevuEkle frm = new frmRandevuEkle();
            frm.ShowDialog();  // frm formunu modal (dialog) olarak göster
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
