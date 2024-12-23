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
    public partial class frmFaturalarveÖdemeler : Form
    {
        public frmFaturalarveÖdemeler()
        {
            InitializeComponent();
            FaturalariGoster();
            this.WindowState = FormWindowState.Maximized;
  
        }

        private void frmFaturalarveÖdemeler_Load(object sender, EventArgs e)
        {

        }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private void FaturalariGoster()
        {

            string query = @"
    SELECT f.faturaId, f.toplamtutar, f.tarih, k.ad, k.soyad
    FROM faturalar f
    INNER JOIN kullanici_giris k ON f.userid = k.userid
    WHERE (@userRole = 'admin' OR f.userid = @userid)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", frmGirisYap.userId);
                cmd.Parameters.AddWithValue("@userRole", frmGirisYap.userRole);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // FlowLayoutPanel'i temizle
                    flowLayoutPanel_Faturalar.Controls.Clear();

                    while (reader.Read())
                    {
                        // Fatura bilgilerini al
                        int faturaId = Convert.ToInt32(reader["faturaId"]);
                        decimal toplamTutar = Convert.ToDecimal(reader["toplamtutar"]);
                        DateTime tarih = Convert.ToDateTime(reader["tarih"]);
                        string kullaniciAdi = reader["ad"].ToString().Trim();
                        string kullaniciSoyadi = reader["soyad"].ToString().Trim();

                        // Fatura paneli oluştur
                        Panel faturaPanel = new Panel();
                        faturaPanel.Size = new Size(300, 200);  // Yüksekliği biraz artırdım
                        faturaPanel.BorderStyle = BorderStyle.FixedSingle;
                        faturaPanel.BackColor = Color.LightGray;
                        faturaPanel.Margin = new Padding(10);

                        // Fatura ID
                        Label lblFaturaId = new Label();
                        lblFaturaId.Text = $"Fatura ID: {faturaId}";
                        lblFaturaId.Font = new Font("Arial", 12, FontStyle.Bold);
                        lblFaturaId.Dock = DockStyle.Top;
                        faturaPanel.Controls.Add(lblFaturaId);

                        // Toplam Tutar
                        Label lblToplamTutar = new Label();
                        lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C}";
                        lblToplamTutar.Font = new Font("Arial", 12);
                        lblToplamTutar.Dock = DockStyle.Top;
                        faturaPanel.Controls.Add(lblToplamTutar);

                        // Tarih
                        Label lblTarih = new Label();
                        lblTarih.Text = $"Tarih: {tarih:dd/MM/yyyy}";
                        lblTarih.Font = new Font("Arial", 12);
                        lblTarih.Dock = DockStyle.Top;
                        faturaPanel.Controls.Add(lblTarih);

                        // Kullanıcı Adı ve Soyadı
                        Label lblKullanici = new Label();
                        lblKullanici.Text = $"Kullanıcı: {kullaniciAdi} {kullaniciSoyadi}";
                        lblKullanici.Font = new Font("Arial", 12);
                        lblKullanici.Dock = DockStyle.Top;
                        faturaPanel.Controls.Add(lblKullanici);

                        // Detayları Görüntüle butonu
                        Button btnDetayGor = new Button();
                        btnDetayGor.Text = "Detayları Gör";
                        btnDetayGor.Tag = faturaId;
                        btnDetayGor.Click += BtnDetayGor_Click;
                        btnDetayGor.Dock = DockStyle.Bottom;
                        faturaPanel.Controls.Add(btnDetayGor);

                        // Paneli FlowLayoutPanel'e ekle
                        flowLayoutPanel_Faturalar.Controls.Add(faturaPanel);
                        flowLayoutPanel_Faturalar.AutoScroll = true;
                    }
                }
            }
        }

        private void BtnDetayGor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int faturaId = (int)btn.Tag;
            FaturaDetaylariniGoster(faturaId);
        }

        private void FaturaDetaylariniGoster(int faturaId)
        {
            string query = "SELECT urunler.urunadi, FaturaDetaylari.Miktar, FaturaDetaylari.Fiyat " +
                           "FROM FaturaDetaylari " +
                           "INNER JOIN urunler ON FaturaDetaylari.UrunID = urunler.urunid " +
                           "WHERE FaturaDetaylari.FaturaID = @faturaId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@faturaId", faturaId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Fatura detaylarını göstermek için bir form oluştur
                    Form detayForm = new Form();
                    detayForm.Text = "Fatura Detayları";
                    detayForm.Size = new Size(500, 350);  // Boyutunu ayarladım
                    detayForm.StartPosition = FormStartPosition.CenterParent;

                    // FormBorderStyle'ı FixedToolWindow olarak ayarla
                    detayForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;

                    // Form arka plan rengini belirleyin
                    detayForm.BackColor = Color.LightBlue;  // Burada istediğiniz rengi seçebilirsiniz

                    detayForm.Padding = new Padding(20);  // İç boşluk

                    // ListView ve Kapat butonu için bir Panel oluştur
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Fill;
                    panel.Padding = new Padding(10);
                    detayForm.Controls.Add(panel);

                    // ListView oluştur ve stilini belirle
                    ListView listView = new ListView();
                    listView.Dock = DockStyle.Fill;  // ListView'i panelin tamamına yay
                    listView.View = View.Details;
                    listView.FullRowSelect = true;
                    listView.GridLines = true;
                    listView.Columns.Add("Ürün Adı", 150);
                    listView.Columns.Add("Miktar", 100);
                    listView.Columns.Add("Fiyat", 100);

                    // ListView'e öğeleri ekle
                    while (reader.Read())
                    {
                        string urunAdi = reader["urunadi"].ToString();
                        int miktar = Convert.ToInt32(reader["miktar"]);
                        decimal fiyat = Convert.ToDecimal(reader["fiyat"]);

                        ListViewItem item = new ListViewItem(new[] { urunAdi, miktar.ToString(), fiyat.ToString("C") });
                        listView.Items.Add(item);
                    }

                    panel.Controls.Add(listView);

                    detayForm.ShowDialog();
                }
            }
        }
        private void flowLayoutPanel_Faturalar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
