using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmFiyatSayfa : Form
    {
        public frmFiyatSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGirisYap frmGirisYap = new frmGirisYap();
            frmGirisYap.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
           frmMusteriler frmMusteriler = new frmMusteriler();
            frmMusteriler.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmEvcilHayvanlar frmEvcilHayvanlar = new frmEvcilHayvanlar();
            frmEvcilHayvanlar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmRandevular frmRandevular = new frmRandevular();  
            frmRandevular.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmFaturalarveÖdemeler frmFaturalarveÖdemeler = new frmFaturalarveÖdemeler();
            frmFaturalarveÖdemeler.Show();    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmÜrünler frmÜrünler = new frmÜrünler();
            frmÜrünler.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAşıTakvimi frmAşıTakvimi = new frmAşıTakvimi();
            frmAşıTakvimi.Show();
        }
    }
}
