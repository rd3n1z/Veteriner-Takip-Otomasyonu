using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmKayitOl : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmKayitOl()
        {
            InitializeComponent();
            InitializePlaceholders();

            // btnShowHide butonunun MouseDown ve MouseUp olaylarını bağlıyoruz
            btnShowHide.MouseDown += btnShowHide_MouseDown;
            btnShowHide.MouseUp += btnShowHide_MouseUp;
        }

        // Yer tutucuların başlatılması
        private void InitializePlaceholders()
        {
            SetPlaceholder(txtBox_Ad, "Ad");
            SetPlaceholder(txtBox_Soyad, "Soyad");
            SetPlaceholder(txtBox_Eposta, "E-posta");
            SetPlaceholder(txtBox_KullaniciAdi, "Kullanıcı Adı");
            SetPlaceholder(txtBox_Parola, "Parola", true); // Parola alanı için yer tutucu
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

        // btnShowHide butonuna basıldığında parolayı göstermek için MouseDown olayı
        private void btnShowHide_MouseDown(object sender, MouseEventArgs e)
        {
            txtBox_Parola.PasswordChar = '\0'; // Parolayı görünür yapıyoruz
        }

        // btnShowHide butonundan parmak çekildiğinde parolayı gizlemek için MouseUp olayı
        private void btnShowHide_MouseUp(object sender, MouseEventArgs e)
        {
            txtBox_Parola.PasswordChar = '*'; // Parolayı tekrar gizli hale getiriyoruz
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {

            ClearErrorMessages();

            bool isValid = true;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtBox_Ad.Text) || txtBox_Ad.Text == "Ad")
            {
                lblAdHata.Text = "Ad alanı boş olamaz!";
                lblAdHata.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBox_Soyad.Text) || txtBox_Soyad.Text == "Soyad")
            {
                lblSoyadHata.Text = "Soyad alanı boş olamaz!";
                lblSoyadHata.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBox_Eposta.Text) || txtBox_Eposta.Text == "E-posta")
            {
                lblEpostaHata.Text = "E-posta alanı boş olamaz!";
                lblEpostaHata.Visible = true;
                isValid = false;
            }
        

            else if (!IsValidEmail(txtBox_Eposta.Text))
            {
                lblEpostaHata.Text = "Geçerli bir E-posta adresi giriniz!";
                lblEpostaHata.Visible = true;
                isValid = false;
            }

            // Kullanılmış email kontrolü
            else if (IsUsedEmail(txtBox_Eposta.Text))
            {
                lblEpostaHata.Text = "Bu e-posta zaten kayıtlı";
                lblEpostaHata.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtBox_KullaniciAdi.Text) || txtBox_KullaniciAdi.Text == "Kullanıcı Adı")
            {
                lblKullaniciAdiHata.Text = "Kullanıcı adı alanı boş olamaz!";
                lblKullaniciAdiHata.Visible = true;
                isValid = false;
            }
            // Kullanılmış kullanıcı adı kontrolü
            else if (IsUsedUsername(txtBox_KullaniciAdi.Text))
            {
                lblKullaniciAdiHata.Text = "Bu kullanıcı adı çoktan kullanılmaktadır!";
                lblKullaniciAdiHata.Visible = true;
                isValid = false;
            }
            // Parola alanı kontrolü
            if (string.IsNullOrWhiteSpace(txtBox_Parola.Text) || txtBox_Parola.Text == "Parola")
            {
                lblParolaHata.Text = "Parola alanı boş olamaz!";
                lblParolaHata.Visible = true;
                isValid = false;
            }
            else
            {
                lblParolaHata.Visible = false;
            }

            if (!isValid)
                return;

            // Kullanıcıyı kaydet
            RegisterUser();
        }

        private void ClearErrorMessages()
        {
            lblAdHata.Visible = false;
            lblSoyadHata.Visible = false;
            lblEpostaHata.Visible = false;
            lblKullaniciAdiHata.Visible = false;
        }

        private void RegisterUser()
        {
            string query = "INSERT INTO kullanici_giris (kullanici_adi, kullanici_sifre, email, ad, soyad, rol) VALUES (@kullanici_adi, @kullanici_sifre, @email, @ad, @soyad, @rol)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@kullanici_adi", txtBox_KullaniciAdi.Text);
                    command.Parameters.AddWithValue("@kullanici_sifre", txtBox_Parola.Text);
                    command.Parameters.AddWithValue("@email", txtBox_Eposta.Text);
                    command.Parameters.AddWithValue("@ad", txtBox_Ad.Text);
                    command.Parameters.AddWithValue("@soyad", txtBox_Soyad.Text);
                    command.Parameters.AddWithValue("@rol", "Müşteri");
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Kayıt işlemi başarılı olduğunda kullanıcıya bilgi ver
                    DialogResult result = MessageBox.Show("Kayıt başarıyla oluşturuldu! Tamam'a tıklayarak anasayfaya dönün.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        // Kayıt sonrası Form1'e yönlendir
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide(); // Şu anki formu gizle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

    

        private bool IsUsedEmail(string email)
        {
            string query = "SELECT COUNT(*) FROM kullanici_giris WHERE email = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    return (int)command.ExecuteScalar() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool IsUsedUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM kullanici_giris WHERE kullanici_adi = @KullaniciAdi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", username);

                try
                {
                    conn.Open();
                    return (int)command.ExecuteScalar() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        private void txtBox_Ad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Ad.Text) && txtBox_Ad.Text != "Ad")
            {
                lblAdHata.Visible = false;
            }

        }

        private void txtBox_Soyad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Soyad.Text) && txtBox_Soyad.Text != "Soyad")
            {
                lblSoyadHata.Visible = false;
            }
        }

        private void txtBox_Eposta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Eposta.Text) && txtBox_Eposta.Text != "E-posta")
            {
                lblEpostaHata.Visible = false;
            }
        }

        private void txtBox_KullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_KullaniciAdi.Text) && txtBox_KullaniciAdi.Text != "Kullanıcı Adı")
            {
                lblKullaniciAdiHata.Visible = false;
            }
        }

        private void txtBox_Parola_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Parola.Text) && txtBox_Parola.Text != "Parola")
            {
                lblParolaHata.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Form1'i aç
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu gizlemek için
        }
    }
}
