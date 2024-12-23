using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmUrunDuzenle : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private Dictionary<int, string> urunlerListesi = new Dictionary<int, string>(); // Ürün ID ve Adı eşleştirme

        public frmUrunDuzenle()
        {
            InitializeComponent();
            UrunleriYukle();
        }

        private void UrunleriYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT urunid, urunadi FROM urunler";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string urunAdi = reader.GetString(1);
                        urunlerListesi.Add(id, urunAdi);
                        cmb_urunler.Items.Add(urunAdi);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata: {ex.Message}");
            }
        }

        private void cmb_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenID = GetSelectedUrunID();
            if (secilenID != -1)
            {
                UrunBilgileriniGetir(secilenID);
            }
        }

        private int GetSelectedUrunID()
        {
            foreach (var item in urunlerListesi)
            {
                if (item.Value == cmb_urunler.SelectedItem.ToString())
                    return item.Key;
            }
            return -1;
        }

        private void UrunBilgileriniGetir(int urunID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT urunadi, fiyat, stok FROM urunler WHERE urunid = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", urunID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tb_urunAdi.Text = reader.GetString(0);
                        tb_fiyat.Text = reader.GetDecimal(1).ToString();
                        tb_stok.Text = reader.GetInt32(2).ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilgiler getirilirken hata: {ex.Message}");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int secilenID = GetSelectedUrunID();
            string yeniAd = tb_urunAdi.Text;
            decimal yeniFiyat = Convert.ToDecimal(tb_fiyat.Text);
            int yeniStok = Convert.ToInt32(tb_stok.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE urunler SET urunadi = @urunadi, fiyat = @fiyat, stok = @stok WHERE urunid = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@urunadi", yeniAd);
                    cmd.Parameters.AddWithValue("@fiyat", yeniFiyat);
                    cmd.Parameters.AddWithValue("@stok", yeniStok);
                    cmd.Parameters.AddWithValue("@id", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla güncellendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında hata: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
