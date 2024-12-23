using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmEvcilHayvanBilgileriGoruntule : Form
    {
        public int HayvanId { get; set; }
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmEvcilHayvanBilgileriGoruntule()
        {
            InitializeComponent();
        }

        private void frmEvcilHayvanBilgileriGoruntule_Load(object sender, EventArgs e)
        {
            LoadPetDetails();
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

        private void btn_Duzen_Click(object sender, EventArgs e)
        {
            change_Age.Visible = true;
            change_Gender.Visible = true;
            change_Name.Visible = true;
            change_Species.Visible = true;

            txtBox_Age.Visible = true;
            txtBox_Name.Visible = true;
            cb_Cinsiyet.Visible = true;
            cb_Tur.Visible = true; 

            btn_Kyt.Visible = true;

            label5.Visible = true;
            pictureBox2.Visible = true;
            btnSelectFile.Visible = true;
            btn_Iptal.Visible = true;
        }

        private void btn_Kyt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && ContainsNonAlphabet(txtBox_Name.Text))
            {
                MessageBox.Show("İsim yalnızca harflerden oluşmalı.", "Geçersiz İsim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yaş doğrulama
            if (!string.IsNullOrWhiteSpace(txtBox_Age.Text) && !IsValidAge(txtBox_Age.Text))
            {
                MessageBox.Show("Yaş yalnızca rakamlardan oluşmalıdır.", "Geçersiz Yaş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HayvanGuncelle();

            change_Age.Visible = false;
            change_Gender.Visible = false;
            change_Name.Visible = false;
            change_Species.Visible = false;

            txtBox_Age.Visible = false;
            txtBox_Name.Visible = false;
            cb_Cinsiyet.Visible = false;
            cb_Tur.Visible = false;

            btn_Kyt.Visible = false;
            label5.Visible = false;
            pictureBox2.Visible = false;
            btnSelectFile.Visible = false;
            btn_Iptal.Visible = false;

            // Bilgileri güncel haliyle yeniden yükle
            LoadPetDetails();
        }

        private void LoadPetDetails()
        {
            string query = "SELECT * FROM EvcilHayvanlarTablosu JOIN kullanici_giris k ON EvcilHayvanlarTablosu.sahipUserId = k.userid WHERE petid = @petid";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@petid", HayvanId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Hayvanın bilgilerini güncel olarak göster
                        lbl_hyvAd.Text = "Ad: " + reader["hayvanAdi"].ToString();
                        lbl_hyvTur.Text = "Tür: " + reader["turu"].ToString();
                        lbl_hyvYas.Text = "Yaş: " + reader["yas"].ToString();
                        lbl_Cinsiyet.Text = "Cinsiyet: " + reader["cinsiyet"].ToString();
                        lbl_Sahip.Text = "Sahibi: " + reader["ad"].ToString().Trim() + " " + reader["soyad"].ToString().Trim();

                        // Fotoğrafı güncel olarak göster
                        string hayvanFoto = reader["hayvanFoto"].ToString();
                        if (!string.IsNullOrEmpty(hayvanFoto) && File.Exists(hayvanFoto))
                        {
                            pictureBox1.ImageLocation = hayvanFoto;
                        }
                        else
                        {
                            string avatarTuru = reader["avatarTuru"].ToString();
                            string avatarPath = GetAvatarImagePath(avatarTuru);

                            if (File.Exists(avatarPath))
                            {
                                pictureBox1.Image = Image.FromFile(avatarPath);
                            }
                            else
                            {
                                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "default-avatar.png"));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hayvan bilgileri bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hayvan bilgileri alınamadı: " + ex.Message);
                }
            }
        }

        private bool IsValidAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age)) // Eğer yaş boşsa geçerli say
                return true;

            var regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
            return regex.IsMatch(age);
        }

        private bool ContainsNonAlphabet(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) // Eğer isim boşsa geçerli say
                return false;

            string pattern = @"[^a-zA-ZçÇşŞüÜöÖğĞıİ ]"; // Türkçe karakterler dahil
            return Regex.IsMatch(name, pattern);
        }

        private void HayvanGuncelle()
        {
            var queryParts = new List<string>(); // Dinamik sorgu oluşturmak için liste
            var parameters = new Dictionary<string, object>(); // Parametreleri saklama
            string query;

            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text)) // İsim değişmişse
            {
                queryParts.Add("hayvanAdi = @hayvanAdi");
                parameters["@hayvanAdi"] = txtBox_Name.Text.Trim();
            }

            if (!string.IsNullOrWhiteSpace(txtBox_Age.Text) && int.TryParse(txtBox_Age.Text.Trim(), out int age)) // Yaş değişmişse
            {
                queryParts.Add("yas = @yas");
                parameters["@yas"] = age;
            }

            if (cb_Cinsiyet.SelectedIndex != -1) // Cinsiyet değişmişse
            {
                queryParts.Add("cinsiyet = @cinsiyet");
                parameters["@cinsiyet"] = cb_Cinsiyet.SelectedItem.ToString();
            }

            if (cb_Tur.SelectedIndex != -1) // Tür değişmişse
            {
                queryParts.Add("turu = @tur");
                string species = cb_Tur.SelectedItem.ToString();
                parameters["@tur"] = species;

                // Avatar türünü ayarla
                string avatarTuru;
                switch (species)
                {
                    case "Kedi":
                        avatarTuru = "kedi";
                        break;
                    case "Ördek":
                        avatarTuru = "ordek";
                        break;
                    case "Köpek":
                        avatarTuru = "kopek";
                        break;
                    case "Hamster":
                        avatarTuru = "hamster";
                        break;
                    case "Fare":
                        avatarTuru = "fare";
                        break;
                    case "Tavşan":
                        avatarTuru = "tavsan";
                        break;
                    case "Tavuk":
                        avatarTuru = "tavuk";
                        break;
                    case "Kuş":
                        avatarTuru = "kus";
                        break;
                    default:
                        avatarTuru = "default";
                        break;
                }
                queryParts.Add("avatarTuru = @avatarTuru");
                parameters["@avatarTuru"] = avatarTuru;
            }

            if (!string.IsNullOrEmpty(pictureBox2.ImageLocation)) // Fotoğraf değişmişse
            {
                queryParts.Add("hayvanFoto = @foto");
                parameters["@foto"] = pictureBox2.ImageLocation;
            }

            // Eğer hiçbir alan değişmemişse güncellemeye gerek yok
            if (queryParts.Count == 0)
            {
                MessageBox.Show("Güncelleme için hiçbir bilgi değiştirilmedi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sorguyu oluştur
            query = "UPDATE EvcilHayvanlarTablosu SET " + string.Join(", ", queryParts) + " WHERE petid = @petid";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Parametreleri komuta ekle
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.Parameters.AddWithValue("@petid", HayvanId); // Hayvan ID'sini ekle

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Evcil hayvan bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    pictureBox2.ImageLocation = path;
                }
            }

            return path;
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            change_Age.Visible = false;
            change_Gender.Visible = false;
            change_Name.Visible = false;
            change_Species.Visible = false;

            txtBox_Age.Visible = false;
            txtBox_Name.Visible = false;
            cb_Cinsiyet.Visible = false;
            cb_Tur.Visible = false;

            btn_Kyt.Visible = false;

            label5.Visible = false;
            pictureBox2.Visible = false;
            btnSelectFile.Visible = false;
            btn_Iptal.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Kyt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && ContainsNonAlphabet(txtBox_Name.Text))
            {
                MessageBox.Show("İsim yalnızca harflerden oluşmalı.", "Geçersiz İsim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yaş doğrulama
            if (!string.IsNullOrWhiteSpace(txtBox_Age.Text) && !IsValidAge(txtBox_Age.Text))
            {
                MessageBox.Show("Yaş yalnızca rakamlardan oluşmalıdır.", "Geçersiz Yaş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HayvanGuncelle();

            change_Age.Visible = false;
            change_Gender.Visible = false;
            change_Name.Visible = false;
            change_Species.Visible = false;

            txtBox_Age.Visible = false;
            txtBox_Name.Visible = false;
            cb_Cinsiyet.Visible = false;
            cb_Tur.Visible = false;

            btn_Kyt.Visible = false;
            label5.Visible = false;
            pictureBox2.Visible = false;
            btnSelectFile.Visible = false;
            btn_Iptal.Visible = false;

            // Bilgileri güncel haliyle yeniden yükle
            LoadPetDetails();

        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            getAnimalPhoto();
        }
    }
}
