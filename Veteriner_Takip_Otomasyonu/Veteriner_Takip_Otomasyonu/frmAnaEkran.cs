using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
            getUserData();
            if(frmGirisYap.userRole == "admin")
            {
                button1.Visible = true;
            }
        }

        public void RefreshPanel(Form childForm)
        {
            // Paneli temizle
            panel1.Controls.Clear();

            // Çocuk form ayarları
            childForm.TopLevel = false; // Form bağımsız değil, ana forma bağlı
            childForm.FormBorderStyle = FormBorderStyle.None; // Çerçeve kaldır
            childForm.Dock = DockStyle.Fill; // Panelin tamamını doldur

            // Yeni formu panelde göster
            panel1.Controls.Add(childForm);
            childForm.Show(); // Formu göster
        }


        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void getUserData()
        {
            int userid = frmGirisYap.userId;

            string query = "SELECT ad, soyad, email, rol FROM kullanici_giris WHERE email = @userEmail";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userEmail", frmGirisYap.LoggedInUserEmail); // Giriş yapan kullanıcının e-posta adresi

                try
                { 
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbl_Ad_Soyad.Text = reader["ad"].ToString().Trim() + " " + reader["soyad"].ToString().Trim();
                            lbl_Rol.Text = reader["rol"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı bilgileri alınamadı: " + ex.Message);
                }
            }
        }

        private void btn_viewDates_Click(object sender, EventArgs e)
        {
            frmRandevular frmRandevular= new frmRandevular();
            ShowFormInPanel(frmRandevular);
        }

        private void btn_petsView_Click(object sender, EventArgs e)
        {
            frmEvcilHayvanlar frmEvcilHayvanlar = new frmEvcilHayvanlar();
            ShowFormInPanel(frmEvcilHayvanlar);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frmÜrünler frmÜrünler = new frmÜrünler();
            ShowFormInPanel(frmÜrünler);
        }

        private void btn_vaccine_Click(object sender, EventArgs e)
        {
            frmAşıTakvimi frmAşıTakvimi = new frmAşıTakvimi();
            ShowFormInPanel(frmAşıTakvimi);
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            frmFaturalarveÖdemeler frmFaturalarveÖdemeler = new frmFaturalarveÖdemeler();
            ShowFormInPanel(frmFaturalarveÖdemeler);
        }

        //Seçilen formun panelde gösterilmesi
        private void ShowFormInPanel(Form childForm)
        {
            // Çocuk form ayarları
            childForm.TopLevel = false; // Form bağımsız değil, ana forma bağlı
            childForm.FormBorderStyle = FormBorderStyle.None; // Çerçeve kaldır
            childForm.Dock = DockStyle.Fill; // Panelin tamamını doldur

            // Paneli temizle ve yeni formu ekle
            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);

            childForm.Show(); // Formu göster
        }

        private void lbl_Ad_Soyad_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frmMusteriler frmMusteriler = new frmMusteriler();
            ShowFormInPanel(frmMusteriler);
        }
    }
}
