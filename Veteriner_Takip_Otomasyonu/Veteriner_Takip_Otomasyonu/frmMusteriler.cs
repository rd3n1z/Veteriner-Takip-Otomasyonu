using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veteriner_Takip_Otomasyonu
{
    public partial class frmMusteriler : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public frmMusteriler()
        {
            InitializeComponent();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            string query;
            string arama = txtBox_AramaMotoru.Text;

            // Eğer arama boşsa tüm müşterileri getir, doluysa arama kriterine göre filtrele
            if (string.IsNullOrEmpty(arama))
            {
                query = "SELECT * FROM kullanici_giris WHERE rol = 'Müşteri'";
            }
            else
            {
                query = "SELECT * FROM kullanici_giris WHERE kullanici_adi LIKE @arama OR ad LIKE @arama OR soyad LIKE @arama OR email LIKE @arama;";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(arama))
                {
                    cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");
                }

                try
                {
                    conn.Open();
                    flowLayoutPanel1.Controls.Clear();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel customerPanel = new Panel();
                            customerPanel.Size = new Size(200, 270);
                            customerPanel.Margin = new Padding(10);

                            // Ad ve Soyadın İlk Harfini Al
                            string firstNameInitial = reader["ad"].ToString().Trim().Substring(0, 1).ToUpper();  // Adın ilk harfi
                            string lastNameInitial = reader["soyad"].ToString().Trim().Substring(0, 1).ToUpper(); // Soyadın ilk harfi
                            string initials = firstNameInitial + lastNameInitial; // İki harfi birleştir

                            Label initialsLabel = new Label();
                            initialsLabel.Text = initials;
                            initialsLabel.TextAlign = ContentAlignment.MiddleCenter;
                            initialsLabel.Font = new Font("Arial", 20, FontStyle.Bold);
                            initialsLabel.ForeColor = Color.White;
                            initialsLabel.BackColor = Color.FromArgb(0, 122, 255); // Arka plan rengi
                            initialsLabel.Size = new Size(90, 90); // Boyutunu küçült
                            initialsLabel.BorderStyle = BorderStyle.None;
                            initialsLabel.AutoSize = false; // Otomatik boyutlandırma kapalı
                            initialsLabel.Padding = new Padding(0); // İçeride boşluk bırakma

                            // Daireyi yuvarlak yapmak için Region ekliyoruz
                            var roundedRectangle = new Rectangle(0, 0, initialsLabel.Width, initialsLabel.Height);
                            var path = new System.Drawing.Drawing2D.GraphicsPath();
                            path.AddEllipse(roundedRectangle);
                            initialsLabel.Region = new Region(path);

                            // Dikey ve yatayda ortalamak için custom Location ayarları
                            initialsLabel.Location = new Point(
                                    (customerPanel.Width - initialsLabel.Width) / 2,
                                    (customerPanel.Height - initialsLabel.Height) / 2 - 30);

                            Label customerNameLabel = new Label();
                            customerNameLabel.Text = reader["ad"].ToString().Trim() + " " + reader["soyad"].ToString().Trim();
                            customerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                            customerNameLabel.Dock = DockStyle.Bottom;
                            customerNameLabel.ForeColor = Color.White;
                            customerNameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                            customerNameLabel.BackColor = Color.FromArgb(0, 122, 255);
                            customerNameLabel.Padding = new Padding(5);
                            customerNameLabel.Height = 40;
                            customerNameLabel.BorderStyle = BorderStyle.None;
                            customerNameLabel.Margin = new Padding(0);

                            CheckBox musteriCheckBox = new CheckBox();
                            musteriCheckBox.Location = new Point(10, 10);
                            musteriCheckBox.Text = "Seç";
                            musteriCheckBox.Dock = DockStyle.Bottom;
                            musteriCheckBox.Tag = reader["userid"];

                            // Kontrolleri panel'e ekleyelim
                            customerPanel.Controls.Add(customerNameLabel);
                            customerPanel.Controls.Add(initialsLabel); // Daireyi buraya ekliyoruz
                            customerPanel.Controls.Add(musteriCheckBox);
                            flowLayoutPanel1.Controls.Add(customerPanel);
                            flowLayoutPanel1.AutoScroll = true;
                            flowLayoutPanel1.WrapContents = true;

                            
                            if (reader["rol"].ToString().Trim() == "admin")
                            {
                                customerNameLabel.BackColor = Color.FromArgb(8, 50, 97);
                                initialsLabel.BackColor = Color.FromArgb(8, 50, 97);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }



        private void btn_YeniMusteri_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void btn_musSil_Click(object sender, EventArgs e)
        {
            // Seçilen müşteri ID'sini alın
            int selectedCustomerId = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel customerPanel)
                {
                    var checkBox = customerPanel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox != null && checkBox.Checked)
                    {
                        selectedCustomerId = Convert.ToInt32(checkBox.Tag);
                        break;
                    }
                }
            }

            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.");
                return;
            }

            var confirmation = MessageBox.Show("Bu müşteri ve ilişkili verileri silmek istediğinizden emin misiniz?",
                                               "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                // Silme işlemi yapalım
                DeleteCustomerAndRelatedData(selectedCustomerId);
            }
        }

        private void DeleteCustomerAndRelatedData(int customerId)
        {
            string query = @"
            BEGIN TRANSACTION;

            -- Randevular ile ilişkili pet verilerini sil
            DELETE FROM [dbo].[randevular] 
            WHERE [petid] IN (
                SELECT [petid] FROM [dbo].[EvcilHayvanlarTablosu] 
                WHERE [sahipUserId] = @customerId
            );

            -- Evcil hayvanların aşılarını sil
            DELETE FROM [dbo].[Asilar] 
            WHERE [petid] IN (
                SELECT [petid] FROM [dbo].[EvcilHayvanlarTablosu] 
                WHERE [sahipUserId] = @customerId
            );

            -- Evcil hayvanları sil
            DELETE FROM [dbo].[EvcilHayvanlarTablosu] 
            WHERE [sahipUserId] = @customerId;

            -- Müşteri ile ilişkili faturaları sil
            DELETE FROM [dbo].[faturalar] 
            WHERE [userid] = @customerId;

            -- Son olarak müşteri kaydını sil
            DELETE FROM [dbo].[kullanici_giris] 
            WHERE [userid] = @customerId;

            COMMIT TRANSACTION;
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri ve ilişkili veriler başarıyla silindi.");
                    ShowCustomers(); // Güncellenmiş müşteri listesi için tekrar göster
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void txtBox_AramaMotoru_TextChanged(object sender, EventArgs e)
        {
            ShowCustomers();
        }
    }
}
