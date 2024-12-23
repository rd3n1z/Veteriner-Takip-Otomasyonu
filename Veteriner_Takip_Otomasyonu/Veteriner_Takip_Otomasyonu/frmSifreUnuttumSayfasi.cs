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
    public partial class frmSifreUnuttumSayfasi : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmSifreUnuttumSayfasi()
        {
            InitializeComponent();
            InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtBox_Eposta, "E-posta");
            SetPlaceholder(txtBox_YeniParola, "Yeni Parola", true);
            SetPlaceholder(txtBox_YeniParolaTekrar, "Yeni Parola Tekrar", true);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGirisYap frmGirisYap = new frmGirisYap();
            frmGirisYap.Show();
        }
        //TextBox 'a yer tutucu(PlaceHolder) ekleme
        

        private void button7_Click(object sender, EventArgs e)
        {
            sifreSifirlama();
        }

        private void sifreSifirlama()
        {
            if(txtBox_YeniParola.Text == txtBox_YeniParolaTekrar.Text)
            {
                try
                {
                    string query = "UPDATE kullanici_giris SET kullanici_sifre = @sifre WHERE email = @email";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sifre", txtBox_YeniParola.Text);
                        cmd.Parameters.AddWithValue("@email", txtBox_Eposta.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Şifreniz başarı ile sıfırlandı.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Şifreleriniz aynı olmalıdır.");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPlaceholder(TextBox textBox, string placeholderText, bool isPassword = false)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Silver;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (isPassword)
                    textBox.PasswordChar = '*'; // Parolada yer tutucu kaldırıldığında gizleme etkinleştiriliyor
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Silver;
                    if (isPassword)
                        textBox.PasswordChar = '\0'; // Parola kutusuna yer tutucu geri döndüğünde gizleme kaldırılmalı
                }
            };
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            ToggleBothPasswordVisibility();
        }

        private void ToggleBothPasswordVisibility()
        {
            // Eğer Placeholder varsa, PasswordChar kullanılmasın.
            if ((txtBox_YeniParola.Text == "Yeni Parola" || string.IsNullOrWhiteSpace(txtBox_YeniParola.Text)) &&
                (txtBox_YeniParolaTekrar.Text == "Yeni Parola Tekrar" || string.IsNullOrWhiteSpace(txtBox_YeniParolaTekrar.Text)))
            {
                txtBox_YeniParola.PasswordChar = '\0';
                txtBox_YeniParolaTekrar.PasswordChar = '\0';
                txtBox_YeniParola.ForeColor = Color.Silver;
                txtBox_YeniParolaTekrar.ForeColor = Color.Silver;
                btnShowHide.Image = imageList1.Images[2]; // Gözü kapalı yap
            }
            else
            {
                // Placeholder yoksa, PasswordChar ile gizle/göster.
                if (txtBox_YeniParola.PasswordChar == '*' && txtBox_YeniParolaTekrar.PasswordChar == '*')
                {
                    txtBox_YeniParola.PasswordChar = '\0';          // Şifreyi görünür yap
                    txtBox_YeniParolaTekrar.PasswordChar = '\0';   // Şifreyi görünür yap
                    btnShowHide.Image = imageList1.Images[1];      // Gözü açık yap
                }
                else
                {
                    txtBox_YeniParola.PasswordChar = '*';          // Şifreyi gizle
                    txtBox_YeniParolaTekrar.PasswordChar = '*';    // Şifreyi gizle
                    btnShowHide.Image = imageList1.Images[2];      // Gözü kapalı yap
                }
            }
        }
    }
}

    
