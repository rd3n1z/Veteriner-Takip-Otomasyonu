using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmÜrünler : Form
    {
        private List<Urun> sepet = new List<Urun>();
        public class Urun
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal Fiyat { get; set; }
            public int Stok { get; set; }
        }

        public frmÜrünler()
        {
            InitializeComponent();
            UrunleriGoster();
            if(frmGirisYap.userRole == "admin")
            {
                button3.Visible = true;
                btn_urunekle.Visible = true;
            }
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Ürünleri gösterme metodu
        private void UrunleriGoster(string searchQuery = "")
        {
            string query = "SELECT urunid, urunadi, fiyat, stok, foto FROM urunler WHERE stok > 0";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " AND urunadi LIKE @searchQuery";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                }

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    flowLayoutPanel_urunler.Controls.Clear();

                    while (reader.Read())
                    {
                        // Ürünleri eklemeye devam et
                        int urunId = Convert.ToInt32(reader["urunid"]);
                        string urunAdi = reader["urunadi"].ToString();
                        decimal fiyat = Convert.ToDecimal(reader["fiyat"]);
                        int stok = Convert.ToInt32(reader["stok"]);
                        string fotoUrl = reader["foto"].ToString();

                        // Ürün paneli oluştur
                        Panel urunPanel = new Panel();
                        urunPanel.Size = new Size(220, 300);
                        urunPanel.BorderStyle = BorderStyle.FixedSingle;
                        urunPanel.Margin = new Padding(10);

                        PictureBox pbUrunResmi = new PictureBox();
                        pbUrunResmi.Size = new Size(200, 150);
                        pbUrunResmi.ImageLocation = @"Resources\" + fotoUrl;
                        pbUrunResmi.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbUrunResmi.Dock = DockStyle.Top;
                        pbUrunResmi.Click += (sender, e) => SepeteEkle(urunId);
                        urunPanel.Controls.Add(pbUrunResmi);

                        Label lblUrunAdi = new Label();
                        lblUrunAdi.Text = urunAdi;
                        lblUrunAdi.Dock = DockStyle.Top;
                        lblUrunAdi.Font = new Font("Arial", 14, FontStyle.Bold);
                        urunPanel.Controls.Add(lblUrunAdi);

                        Label lblFiyat = new Label();
                        lblFiyat.Text = $"Fiyat: {fiyat:C}";
                        lblFiyat.Dock = DockStyle.Top;
                        lblFiyat.Font = new Font("Arial", 12);
                        urunPanel.Controls.Add(lblFiyat);

                        Label lblStok = new Label();
                        lblStok.Text = $"Stok: {stok}";
                        lblStok.Dock = DockStyle.Top;
                        lblStok.Font = new Font("Arial", 12);
                        urunPanel.Controls.Add(lblStok);

                        flowLayoutPanel_urunler.Controls.Add(urunPanel);
                        flowLayoutPanel_urunler.AutoScroll = true;
                    }
                }
            }
        }


        // Sepete ekleme metodu
        // Sepete ekleme metodu
        private void SepeteEkle(int urunId)
        {
            // Ürünün sepette olup olmadığını kontrol et
            if (sepet.Any(u => u.UrunID == urunId))
            {
                MessageBox.Show("Bu ürün zaten sepete eklenmiş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Eğer ürün zaten sepetteyse işlemi durdur
            }

            Urun secilenUrun = UrunleriGetirById(urunId); // Ürünü veritabanından al
            if (secilenUrun != null)
            {
                sepet.Add(secilenUrun);
                UpdateSepetGoruntule();
                MessageBox.Show($"{secilenUrun.UrunAdi} sepete eklendi!");
            }
        }


        // Sepetten çıkarma metodu
        private void BtnSepettenCikart_Click(object sender, EventArgs e)
        {
            // Tüm ürünleri sepetteki listeden çıkar
            sepet.Clear();
            MessageBox.Show("Sepetteki tüm ürünler çıkarıldı!");

            // Sepeti ve toplam tutarı güncelle
            UpdateSepetGoruntule();
        }

        // Sepet ve toplam tutarı görüntüleme metodu
        // Sepet ve toplam tutarı görüntüleme metodu
        // Sepet ve toplam tutarı görüntüleme metodu
        private void UpdateSepetGoruntule()
        {
            // Paneli tamamen temizle
            panelSepet.Controls.Clear();
            decimal toplamTutar = 0;

            // Eğer sepette ürün varsa, her birini göster
            if (sepet.Count > 0)
            {
                foreach (Urun urun in sepet)
                {
                    Label lblUrunSepet = new Label();
                    lblUrunSepet.Text = $"{urun.UrunAdi} - {urun.Fiyat:C}";
                    lblUrunSepet.Dock = DockStyle.Top;
                    lblUrunSepet.Font = new Font("Arial", 16, FontStyle.Bold);
                    panelSepet.Controls.Add(lblUrunSepet);
                    toplamTutar += urun.Fiyat;
                }
            }
            else
            {
                // Sepet boşsa bir uyarı göster
                Label lblSepetBos = new Label();
                lblSepetBos.Text = "Sepetiniz Boş!";
                lblSepetBos.Dock = DockStyle.Top;
                lblSepetBos.Font = new Font("Arial", 14, FontStyle.Italic);
                panelSepet.Controls.Add(lblSepetBos);
            }

            // Toplam tutarı güncelle
            lblToplamTutar.Text = $"Toplam: {toplamTutar:C}";
        }



        private Urun UrunleriGetirById(int urunId)
        {
            Urun urun = null;
            string query = "SELECT urunid, urunadi, fiyat, stok FROM urunler WHERE urunid = @urunId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@urunId", urunId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        urun = new Urun
                        {
                            UrunID = Convert.ToInt32(reader["urunid"]),
                            UrunAdi = reader["urunadi"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["fiyat"]),
                            Stok = Convert.ToInt32(reader["stok"])
                        };
                    }
                }
            }
            return urun;
        }

        // Fatura oluşturma metodu
        private void FaturaOlustur(decimal toplamTutar, int userId)
        {
            // Create invoice
            int faturaId = CreateInvoice(userId, toplamTutar);

            if (faturaId > 0)
            {
                // Now insert the products in the invoice details
                AddInvoiceDetails(faturaId);
                MessageBox.Show($"Fatura oluşturuluyor. Toplam Tutar: {toplamTutar:C}");
            }
            else
            {
                MessageBox.Show("Fatura oluşturulurken bir hata oluştu.");
            }
        }

        private int CreateInvoice(int userId, decimal toplamTutar)
        {
            string query = "INSERT INTO faturalar (userid, toplamtutar, tarih) OUTPUT INSERTED.faturaId VALUES (@userId, @toplamTutar, @tarih)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.Date);

                conn.Open();
                var result = cmd.ExecuteScalar();

                return Convert.ToInt32(result); // Return the generated faturaId
            }
        }

        private void AddInvoiceDetails(int faturaId)
        {
            string query = "INSERT INTO FaturaDetaylari (FaturaID, UrunID, Miktar, Fiyat) VALUES (@faturaId, @urunId, @miktar, @fiyat)";
            string stokGuncelleQuery = "UPDATE urunler SET stok = stok - @miktar WHERE urunid = @urunId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlCommand stokCmd = new SqlCommand(stokGuncelleQuery, conn)) // Stok güncelleme komutu
            {
                conn.Open();

                foreach (Urun urun in sepet)
                {
                    // Fatura detayları için ürün ekleme
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@faturaId", faturaId);
                    cmd.Parameters.AddWithValue("@urunId", urun.UrunID);
                    cmd.Parameters.AddWithValue("@miktar", 1); // Miktar 1 olarak kabul ediliyor
                    cmd.Parameters.AddWithValue("@fiyat", urun.Fiyat);
                    cmd.ExecuteNonQuery();

                    // Stok güncelleme
                    stokCmd.Parameters.Clear();
                    stokCmd.Parameters.AddWithValue("@urunId", urun.UrunID);
                    stokCmd.Parameters.AddWithValue("@miktar", 1); // Aynı miktarı düşüyoruz
                    stokCmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_SatinAl_Click(object sender, EventArgs e)
        {
            // Sepet işlemleri
            if (sepet.Count == 0)
            {
                MessageBox.Show("Lütfen ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer sepet boşsa işlem durur
            }

            decimal toplamTutar = sepet.Sum(urun => urun.Fiyat);
            FaturaOlustur(toplamTutar, frmGirisYap.userId);

            // Sepeti temizle
            sepet.Clear();
            UpdateSepetGoruntule();

            // Ürün listesini yeniden göster
            UrunleriGoster(); // Bu satır ürün listesini günceller
        }


        private void txtBox_AramaMotoru_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtBox_AramaMotoru.Text.Trim();
            UrunleriGoster(searchQuery);  // Call UrunleriGoster with the search query
        }

        private void frmÜrünler_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmAdminÜrünEkle adminÜrünEkle = new frmAdminÜrünEkle();
            adminÜrünEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunleriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUrunDuzenle frmUrunDuzenle = new frmUrunDuzenle();
            frmUrunDuzenle.ShowDialog();
        }

        private void btn_urunekle_Click(object sender, EventArgs e)
        {
            frmAdminÜrünEkle adminÜrünEkle = new frmAdminÜrünEkle();
            adminÜrünEkle.ShowDialog();
        }
    }
}
