namespace Veteriner_Takip_Otomasyonu
{
    partial class frmRandevuEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_RandevuEkle = new System.Windows.Forms.Button();
            this.comboBoxHayvanlar = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_Randevu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RandevuEkle
            // 
            this.btn_RandevuEkle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_RandevuEkle.FlatAppearance.BorderSize = 0;
            this.btn_RandevuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RandevuEkle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RandevuEkle.ForeColor = System.Drawing.Color.White;
            this.btn_RandevuEkle.ImageKey = "health.png";
            this.btn_RandevuEkle.Location = new System.Drawing.Point(652, 221);
            this.btn_RandevuEkle.Name = "btn_RandevuEkle";
            this.btn_RandevuEkle.Size = new System.Drawing.Size(196, 53);
            this.btn_RandevuEkle.TabIndex = 14;
            this.btn_RandevuEkle.Text = "Randevu Al";
            this.btn_RandevuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RandevuEkle.UseVisualStyleBackColor = false;
            this.btn_RandevuEkle.Click += new System.EventHandler(this.btn_RandevuEkle_Click);
            // 
            // comboBoxHayvanlar
            // 
            this.comboBoxHayvanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxHayvanlar.FormattingEnabled = true;
            this.comboBoxHayvanlar.Location = new System.Drawing.Point(41, 127);
            this.comboBoxHayvanlar.Name = "comboBoxHayvanlar";
            this.comboBoxHayvanlar.Size = new System.Drawing.Size(226, 33);
            this.comboBoxHayvanlar.TabIndex = 15;
            // 
            // dateTimePickerRandevuTarihi
            // 
            this.dateTimePickerRandevuTarihi.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerRandevuTarihi.Location = new System.Drawing.Point(324, 130);
            this.dateTimePickerRandevuTarihi.Name = "dateTimePickerRandevuTarihi";
            this.dateTimePickerRandevuTarihi.Size = new System.Drawing.Size(330, 30);
            this.dateTimePickerRandevuTarihi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Evcil Hayvanınızı Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bir tarih seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Zaman Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "09:00",
            "09:20",
            "09:40",
            "10:00",
            "10:20",
            "10:40",
            "11:00",
            "11:20",
            "11:40",
            "12:00",
            "12:20",
            "12:40",
            "13:00",
            "13:20",
            "13:40",
            "14:00",
            "14:20",
            "14:40",
            "15:00",
            "15:20",
            "15:40",
            "16:00"});
            this.comboBox1.Location = new System.Drawing.Point(41, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 33);
            this.comboBox1.TabIndex = 21;
            // 
            // cb_Randevu
            // 
            this.cb_Randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Randevu.FormattingEnabled = true;
            this.cb_Randevu.Items.AddRange(new object[] {
            "Kuduz Aşısı",
            "Bordotella Aşısı",
            "Corona Aşısı",
            "Karma Aşısı",
            "Acil Klinik",
            "Cerrahi",
            "Ortopedi",
            "Göz Hastalıkları",
            "Nöroloji",
            "Fizik Tedavi",
            "Doğum ve Jinekoloji",
            "İç Hastalıkları",
            "Kardioyoloji",
            "Aşı ve Mikroçip",
            "Kısırlaştırma",
            "Reprodüksiyon",
            "Davranış",
            "Beslenme ve Diyetetik"});
            this.cb_Randevu.Location = new System.Drawing.Point(324, 221);
            this.cb_Randevu.Name = "cb_Randevu";
            this.cb_Randevu.Size = new System.Drawing.Size(226, 33);
            this.cb_Randevu.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(320, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Randevu Türü:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 67);
            this.panel1.TabIndex = 24;
            this.panel1.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(178, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Randevu Alma Ekranı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.exit__2_;
            this.pictureBox1.Location = new System.Drawing.Point(818, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Randevu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerRandevuTarihi);
            this.Controls.Add(this.comboBoxHayvanlar);
            this.Controls.Add(this.btn_RandevuEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRandevuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randeu Alma Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RandevuEkle;
        private System.Windows.Forms.ComboBox comboBoxHayvanlar;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_Randevu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}