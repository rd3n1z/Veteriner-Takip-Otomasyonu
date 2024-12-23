using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmEvcilHayvanEkleme : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmEvcilHayvanEkleme()
        {
            InitializeComponent();
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

        private void HayvanEkle()
        {
            string name = txtBox_Name.Text.Trim();
            int age = int.Parse(txtBox_Age.Text.Trim());
            string gender = cb_Cinsiyet.SelectedItem.ToString();
            string species = cb_Tur.SelectedItem.ToString();
            string avatarTuru = "";
            int userId = frmGirisYap.userId; // Kullanıcı ID'si giriş ekranından alınır.

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
                    cmd.Parameters.AddWithValue("@sahipId", userId);
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

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            getAnimalPhoto();
        }

        private void btn_hyvEkle_Click_1(object sender, EventArgs e)
        {

            // Uyarı label'larını temizle
            lblHayvanAdiHata.Text = "";
            lblHayvanAdiHata.Visible = true;
            lblYasHata.Text = "";
            lblYasHata.Visible = true;
            lblCinsiyetHata.Text = "";
            lblCinsiyetHata.Visible = true;
            lblTurHata.Text = "";
            lblTurHata.Visible = true;


            bool hasError = false;

            // Hayvan Adı alanının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBox_Name.Text))
            {
                lblHayvanAdiHata.Text = "Hayvan Adı alanı boş olamaz.";
                hasError = true;
            }
            else if (ContainsNonAlphabet(txtBox_Name.Text))
            {
                lblHayvanAdiHata.Text = "Lütfen isme yalnızca harf ve boşluk giriniz.";
                hasError = true;
            }

            // Yaş alanının boş veya geçerli olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtBox_Age.Text))
            {
                lblYasHata.Text = "Yaş alanı boş olamaz.";
                hasError = true;
            }
            else if (IsValidAge(txtBox_Age.Text))
            {
                lblYasHata.Text = "Lütfen geçerli bir yaş giriniz.";
                hasError = true;
            }

            // Cinsiyet seçimi yapılmış mı kontrol et
            if (cb_Cinsiyet.SelectedIndex == -1)
            {
                lblCinsiyetHata.Text = "Cinsiyet alanı boş olamaz.";
                hasError = true;
            }

            // Tür seçimi yapılmış mı kontrol et
            if (cb_Tur.SelectedIndex == -1)
            {
                lblTurHata.Text = "Tür alanı boş olamaz.";
                hasError = true;
            }

            // Eğer bir hata varsa, işlemi durdur
            if (hasError) return;

            // Hayvanı ekle
            HayvanEkle();
        }
    
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && !ContainsNonAlphabet(txtBox_Name.Text))
            {
                lblHayvanAdiHata.Text = "";
                lblHayvanAdiHata.Visible = false;
            }
        }

        private void cb_Tur_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && !ContainsNonAlphabet(txtBox_Name.Text))
            {
                lblTurHata.Text = "";
                lblTurHata.Visible = false;
            }
        }

        private void cb_Cinsiyet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && !ContainsNonAlphabet(txtBox_Name.Text))
            {
                lblCinsiyetHata.Text = "";
                lblCinsiyetHata.Visible = false;
            }
        }

        private void txtBox_Age_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) && !ContainsNonAlphabet(txtBox_Name.Text))
            {
                lblYasHata.Text = "";
                lblYasHata.Visible = false;
            }
        }
    }
}
