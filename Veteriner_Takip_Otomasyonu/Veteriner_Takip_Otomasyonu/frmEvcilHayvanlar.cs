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
    public partial class frmEvcilHayvanlar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmEvcilHayvanlar()
        {
            InitializeComponent();
            ShowPets();
        }

        private void ShowPets()
        {
            int userId = frmGirisYap.userId;
            string query;
            string arama = txtBox_AramaMotoru.Text;

            // Kullanıcı rolü admin mi?
            bool isAdmin = frmGirisYap.userRole == "admin"; // Admin kontrolü

            if (isAdmin) // Eğer kullanıcı adminse, tüm evcil hayvanları getir
            {
                if (string.IsNullOrEmpty(arama))
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu"; // Admin tüm evcil hayvanları görebilir
                }
                else
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE hayvanAdi LIKE @arama";
                }
            }
            else // Kullanıcı normalse, sadece kendi evcil hayvanlarını görebilir
            {
                if (string.IsNullOrEmpty(arama))
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE sahipUserId = @userId";
                }
                else
                {
                    query = "SELECT * FROM EvcilHayvanlarTablosu WHERE sahipUserId = @userId AND hayvanAdi LIKE @arama";
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
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
                            Panel petPanel = new Panel();
                            petPanel.Size = new Size(200, 270);
                            petPanel.Margin = new Padding(10);

                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Size = new Size(120, 120);



                            string hayvanFoto = reader["hayvanFoto"].ToString();
                            if (!string.IsNullOrEmpty(hayvanFoto) && File.Exists(hayvanFoto))
                            {
                                pictureBox.ImageLocation = hayvanFoto;
                            }
                            else
                            {
                                string avatarTuru = reader["avatarTuru"].ToString();
                                string avatarPath = GetAvatarImagePath(avatarTuru);
                                if (File.Exists(avatarPath))
                                {
                                    pictureBox.Image = Image.FromFile(avatarPath);
                                }
                                else
                                {
                                    pictureBox.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "default-avatar.png"));
                                }
                            }

                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            Label petNameLabel = new Label();
                            petNameLabel.Text = reader["hayvanAdi"].ToString();
                            petNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                            petNameLabel.Dock = DockStyle.Bottom;
                            petNameLabel.ForeColor = Color.Black;
                            petNameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                            petNameLabel.BackColor = Color.FromArgb(144, 238, 144);
                            petNameLabel.Padding = new Padding(5);
                            petNameLabel.Height = 40;
                            petNameLabel.BorderStyle = BorderStyle.None;
                            petNameLabel.Margin = new Padding(0);
                            petNameLabel.Cursor = Cursors.Hand;
                            petNameLabel.Tag = reader["petid"].ToString();

                            CheckBox petCheckBox = new CheckBox();
                            petCheckBox.Location = new Point(10, 10);  // Checkbox'ın yerini belirliyoruz
                            petCheckBox.Text = "Seç";
                            petCheckBox.Dock = DockStyle.Bottom;  // Label'ın hemen altına eklenmesi için DockStyle.Bottom
                            petCheckBox.Tag = reader["petid"].ToString();

                            // Önce checkbox'ı ekliyoruz
                            petPanel.Controls.Add(petCheckBox);

                            // Sonra label'ı ekliyoruz
                            petPanel.Controls.Add(petNameLabel);

                            petNameLabel.Click += (s, args) =>
                            {
                                Label clickedLabel = s as Label;
                                if (clickedLabel != null)
                                {
                                    int hayvanId = Convert.ToInt32(clickedLabel.Tag);

                                    frmEvcilHayvanBilgileriGoruntule frm = new frmEvcilHayvanBilgileriGoruntule();
                                    frm.HayvanId = hayvanId;
                                    frm.ShowDialog();
                                }
                            };

                            petPanel.Controls.Add(pictureBox);
                            flowLayoutPanel1.Controls.Add(petPanel);
                            flowLayoutPanel1.AutoScroll = true;
                            flowLayoutPanel1.WrapContents = true;

                            pictureBox.Location = new Point(
                                (petPanel.Width - pictureBox.Width) / 2, // Center horizontally
                                (petPanel.Height - pictureBox.Height - petNameLabel.Height - 10) / 2 // Center vertically with padding
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }


        private bool HayvaninRandevusuVarMi(int petId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM randevular WHERE petid = @petId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    try
                    {
                        conn.Open();
                        int randevuSayisi = (int)cmd.ExecuteScalar();
                        return randevuSayisi > 0; // Eğer randevu varsa true döner
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Randevu kontrolü sırasında bir hata oluştu: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private string GetAvatarImagePath(string avatarTuru)
        {
            // Avatarları dinamik bir şekilde dönüyoruz
            var avatarDictionary = new Dictionary<string, string>()
            {
                { "kedi", "cat.jpg" },
                { "kopek", "dog.jpg" },
                { "ordek", "civciv.jpg" },
                { "hamster", "hamster.jpg" },
                { "fare", "fare.jpg" },
                { "tavsan", "tavsan.jpg" },
                { "tavuk", "horoz.jpg" },
                { "kus", "kus.jpg" }
            };

            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (avatarDictionary.ContainsKey(avatarTuru.ToLower()))
            {
                return Path.Combine(basePath, avatarDictionary[avatarTuru.ToLower()]);
            }
            else
            {
                return Path.Combine(basePath, "cat.jpg");
            }
        }

        private void btn_hyvEkle_Click(object sender, EventArgs e)
        {
            if(frmGirisYap.userRole.ToString() == "admin")
            {
                frmAdminEvcilEkle frmAdminEvcil = new frmAdminEvcilEkle();
                frmAdminEvcil.Show();
            }
            else
            {

                frmEvcilHayvanEkleme frmEvcil = new frmEvcilHayvanEkleme();
                frmEvcil.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPets();
        }

        private void txtBox_AramaMotoru_TextChanged(object sender, EventArgs e)
        {
            ShowPets();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPets();
        }

        private void btn_hyvSil_Click(object sender, EventArgs e)
        {
            var selectedPets = flowLayoutPanel1.Controls.OfType<Panel>()
                                   .Where(p => p.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Checked) != null)
                                   .Select(p => p.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Checked).Tag.ToString())
                                   .ToList();

            if (selectedPets.Count == 0)
            {
                MessageBox.Show("Silmek için en az bir hayvan seçmelisiniz.");
                return;
            }

            DialogResult result = MessageBox.Show("Seçilen hayvanları silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (string petIdString in selectedPets)
                {
                    int petId = Convert.ToInt32(petIdString);

                    // Hayvanın ismini alıyoruz
                    string petName = GetPetNameById(petId);

                    // Hayvanın randevusu olup olmadığını kontrol et
                    if (HayvaninRandevusuVarMi(petId))
                    {
                        MessageBox.Show($"{petName} randevusu olduğu için silinemiyor.");
                        continue; // Bu hayvanı silmiyoruz, diğerlerini silmeye devam ediyoruz
                    }

                    DeletePet(petId);
                }

                ShowPets(); // Silme işleminden sonra tekrar pet'leri gösteriyoruz
            }
        }

        private void DeletePet(int petId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Önce Asilar tablosundaki ilgili kaydı siliyoruz
                string deleteAsilarQuery = "DELETE FROM Asilar WHERE petid = @petId";

                using (SqlCommand cmd = new SqlCommand(deleteAsilarQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    try
                    {
                        conn.Open();
                        // Asilar tablosundan kaydı sil
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Asilar tablosundan silme işlemi sırasında bir hata oluştu: " + ex.Message);
                        return;
                    }
                }

                // Ardından EvcilHayvanlarTablosu'ndan hayvanı siliyoruz
                string deletePetQuery = "DELETE FROM EvcilHayvanlarTablosu WHERE petid = @petId";

                using (SqlCommand cmd = new SqlCommand(deletePetQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hayvan başarıyla silindi!");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hayvan silinirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private string GetPetNameById(int petId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT hayvanAdi FROM EvcilHayvanlarTablosu WHERE petid = @petId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@petId", petId);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteScalar()?.ToString(); // Hayvan adı döner
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hayvan adı alınırken bir hata oluştu: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
