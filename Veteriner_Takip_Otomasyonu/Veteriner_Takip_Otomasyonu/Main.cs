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

namespace Veteriner_Takip_Otomasyonu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (frmGirisYap.userRole == "admin")
            {
                btnMusteri.Visible = true;
            }

            panel2.Visible = false;
            btnExit.Visible = false;
        }

        private void btnOzellikler_Click(object sender, EventArgs e)
        {
            if (panel_menu.Visible == false)
            {
                panel_menu.Visible = true;
            }
            else if (panel_menu.Visible == true)
            {
                panel_menu.Visible = false;

            }
        }
        private void ShowFormInPanel(Form childForm)
        {
            // Çocuk form ayarları
            childForm.TopLevel = false; // Form bağımsız değil, ana forma bağlı
            childForm.FormBorderStyle = FormBorderStyle.None; // Çerçeve kaldır
            childForm.Dock = DockStyle.Fill; // Panelin tamamını doldur

            // Paneli temizle ve yeni formu ekle
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(childForm);

            childForm.Show(); // Formu göster
            btnExit.Visible = panel2.Visible;
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriler frmMusteriler = new frmMusteriler();
            ShowFormInPanel(frmMusteriler);
        }

        private void btnEvcil_Click(object sender, EventArgs e)
        {
            frmEvcilHayvanlar frmEvcilHayvanlar = new frmEvcilHayvanlar();
            ShowFormInPanel(frmEvcilHayvanlar);
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            frmRandevular frmRandevular = new frmRandevular();
            ShowFormInPanel(frmRandevular);
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            frmFaturalarveÖdemeler frmFaturalarveÖdemeler = new frmFaturalarveÖdemeler();
            ShowFormInPanel(frmFaturalarveÖdemeler);
        }

        private void btnUrn_Click(object sender, EventArgs e)
        {
            frmÜrünler frmÜrünler = new frmÜrünler();
            ShowFormInPanel(frmÜrünler);
        }

        private void btnAsi_Click(object sender, EventArgs e)
        {
            frmAşıTakvimi frmAşıTakvimi = new frmAşıTakvimi();
            ShowFormInPanel(frmAşıTakvimi);
        }

        private void CenterPanel(int margin)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Panelin genişliği ve yüksekliği
            int panelWidth = panel2.Width;
            int panelHeight = panel2.Height;

            // Panelin konumunu hesapla
            int panelX = (formWidth - panelWidth) / 2; // Ortada hizala
            int panelY = formHeight - panelHeight - margin; // Alt boşluğu belirle

            // Panelin konumunu ayarla
            panel2.Location = new Point(panelX, panelY);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CenterPanel(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

            // Butonun görünürlüğünü ayarla
            btnExit.Visible = panel2.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible =false;
            btnExit.Visible = panel2.Visible;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
