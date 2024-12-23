using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmAdminÜrünEkle : Form
    {
        public frmAdminÜrünEkle()
        {
            InitializeComponent();
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private void frmAdminÜrünEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hyvEkle_Click(object sender, EventArgs e)
        {
           UrunEkle();
        }

        private void UrunEkle()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_name.Text) ||
                    string.IsNullOrEmpty(tb_fiyat.Text) ||
                    string.IsNullOrEmpty(tb_stok.Text) ||
                    pictureBox1.Image == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz ve bir resim seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string urunAdi = tb_name.Text;
                double urunFiyat = Convert.ToDouble(tb_fiyat.Text);
                int urunStok = Convert.ToInt32(tb_stok.Text);
                string fotoPath = System.IO.Path.GetFileName(pictureBox1.ImageLocation); // Fotoğraf dosya ismini al

                string query = "INSERT INTO urunler (urunadi, fiyat, stok, foto) VALUES (@urun, @fiyat, @stok, @foto)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@urun", urunAdi);
                    cmd.Parameters.AddWithValue("@fiyat", urunFiyat);
                    cmd.Parameters.AddWithValue("@stok", urunStok);
                    cmd.Parameters.AddWithValue("@foto", fotoPath); // Sadece fotoğraf ismini kaydet

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // Fotoğrafı uygulamanın kaynak klasörüne kopyala
                    string targetPath = System.IO.Path.Combine(Application.StartupPath, "Resources", fotoPath);
                    System.IO.File.Copy(pictureBox1.ImageLocation, targetPath, true);

                    MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen doğru formatta sayı değerleri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Fotoğraf Seç";
                openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName; // PictureBox'a fotoğraf ekle
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
    
}
