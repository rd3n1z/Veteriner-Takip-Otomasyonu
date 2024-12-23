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
    public partial class frmGirisYap : Form
    {
        public static string LoggedInUserEmail { get; set; }
        public static int userId { get; set; }
        public static string userRole { get; set; }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmGirisYap()
        {
            InitializeComponent();
            InitializePlaceholders();
        }
        private void InitializePlaceholders()
        {
            SetPlaceholder(txtBox_Eposta, "E-posta");
            SetPlaceholder(txtBox_Parola, "Parola", true);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifreUnuttumSayfasi frmSifreUnuttumSayfasi = new frmSifreUnuttumSayfasi();
            frmSifreUnuttumSayfasi.Show();
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
                    if (isPassword) textBox.PasswordChar = '*'; // Placeholder kaldırıldığında şifre gizli olmalı
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Silver;
                    if (isPassword) textBox.PasswordChar = '\0'; // Placeholder göründüğünde gizleme kaldırılmalı
                }
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.ShowDialog();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            userLogin();
        }


       
        private void userLogin()
        {

            string email = txtBox_Eposta.Text;
            string passwd = txtBox_Parola.Text;

            // Önceki hata mesajlarını gizleyelim
            lblEpostaHata.Visible = false;
            lblParolaHata.Visible = false;

            bool hasError = false;

            // E-posta alanının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(email) || email == "E-posta")
            {
                lblEpostaHata.Text = "E-posta alanı boş olamaz.";
                lblEpostaHata.Visible = true;
                hasError = true;

            }


            // Parola alanının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(passwd) || passwd == "Parola")
            {
                lblParolaHata.Text = "Parola alanı boş olamaz.";
                lblParolaHata.Visible = true;
                hasError = true;
            }

            // Eğer bir hata varsa, fonksiyonu erken bitirelim ve login işlemini yapmayalım
            if (hasError)
            {
                return;
            }
       

            string query = "SELECT COUNT(*) FROM kullanici_giris WHERE kullanici_sifre = @sifre AND email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", passwd);

                try
                {
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar(); // Kullanıcı doğrulama

                    if (count > 0)
                    {
                        // Kullanıcının ID ve rol bilgilerini almak için sorgu yap
                        string userQuery = "SELECT userid, rol FROM kullanici_giris WHERE email = @email";
                        SqlCommand userCommand = new SqlCommand(userQuery, conn);

                        userCommand.Parameters.AddWithValue("@email", email);

                        using (SqlDataReader reader = userCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                frmGirisYap.userId = reader.GetInt32(0); // İlk sütun: UserID
                                frmGirisYap.userRole = reader.GetString(1); // İkinci sütun: userRole

                                frmGirisYap.LoggedInUserEmail = email;

                                DialogResult result = MessageBox.Show("Hoşgeldiniz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                                Main main = new Main();
                                main.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre veya email hatalı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }


        private void btnShowHide_Click_1(object sender, EventArgs e)
        {

            if (txtBox_Parola.Text == "Parola" || string.IsNullOrWhiteSpace(txtBox_Parola.Text))
            {
                // Eğer Placeholder varsa, PasswordChar kullanılmasın.
                txtBox_Parola.PasswordChar = '\0';
                txtBox_Parola.ForeColor = Color.Silver;
                btnShowHide.Image = imageList1.Images[2]; // Gözü kapalı yap
            }
            else
            {
                // Placeholder yoksa, PasswordChar ile gizle/göster.
                if (txtBox_Parola.PasswordChar == '*')
                {
                    txtBox_Parola.PasswordChar = '\0';  // Şifreyi görünür yap
                    btnShowHide.Image = imageList1.Images[1]; // Gözü açık yap
                }
                else
                {
                    txtBox_Parola.PasswordChar = '*';  // Şifreyi gizle
                    btnShowHide.Image = imageList1.Images[2]; // Gözü kapalı yap
                }
            }
        }

        private void txtBox_Eposta_TextChanged(object sender, EventArgs e)
        {

            // Eğer e-posta boşsa veya placeholder içeriği varsa, hata mesajını gizle
            if (string.IsNullOrWhiteSpace(txtBox_Eposta.Text) || txtBox_Eposta.Text == "E-posta")
            {
                lblEpostaHata.Visible = false;
                return;
            }

            // Eğer e-posta "@" sembolü içermiyorsa, hata mesajını göster
            if (!txtBox_Eposta.Text.Contains("@"))
            {
                lblEpostaHata.Text = "Geçerli bir e-posta giriniz.";
                lblEpostaHata.Visible = true;
            }
            else
            {
                lblEpostaHata.Visible = false; // "@ varsa hata mesajını gizle"
            }
        }
    
        private void txtBox_Parola_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Parola.Text) && txtBox_Parola.Text != "Parola")
            {
                lblParolaHata.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
                // Form1'i aç
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); // Mevcut formu gizlemek için
            }

    }
    }

