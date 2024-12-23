namespace Veteriner_Takip_Otomasyonu
{
    partial class frmEvcilHayvanEkleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvcilHayvanEkleme));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Tur = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_hyvEkle = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHayvanAdiHata = new System.Windows.Forms.Label();
            this.lblTurHata = new System.Windows.Forms.Label();
            this.lblCinsiyetHata = new System.Windows.Forms.Label();
            this.lblYasHata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "search (3).png");
            this.imageList2.Images.SetKeyName(1, "search (2).png");
            this.imageList2.Images.SetKeyName(2, "health.png");
            this.imageList2.Images.SetKeyName(3, "computer-icons-scalable-vector-graphics-avatar-emoticon-png-favpng-209NAXaV1ZBQdY" +
        "GrU7nNbMxpX.jpg");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            this.imageList1.Images.SetKeyName(1, "eye-close.png");
            this.imageList1.Images.SetKeyName(2, "eye-open.png");
            this.imageList1.Images.SetKeyName(3, "log-out.png");
            this.imageList1.Images.SetKeyName(4, "plus.png");
            this.imageList1.Images.SetKeyName(5, "medical-symbol.png");
            this.imageList1.Images.SetKeyName(6, "camera.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(422, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Hayvan Fotoğrafı Ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 40);
            this.label7.TabIndex = 51;
            this.label7.Text = "HAYVAN EKLE";
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Age.Location = new System.Drawing.Point(78, 433);
            this.txtBox_Age.Multiline = true;
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(214, 32);
            this.txtBox_Age.TabIndex = 60;
            this.txtBox_Age.TextChanged += new System.EventHandler(this.txtBox_Age_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Yaş";
            // 
            // cb_Cinsiyet
            // 
            this.cb_Cinsiyet.FormattingEnabled = true;
            this.cb_Cinsiyet.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cb_Cinsiyet.Location = new System.Drawing.Point(78, 356);
            this.cb_Cinsiyet.Name = "cb_Cinsiyet";
            this.cb_Cinsiyet.Size = new System.Drawing.Size(214, 24);
            this.cb_Cinsiyet.TabIndex = 58;
            this.cb_Cinsiyet.TextChanged += new System.EventHandler(this.cb_Cinsiyet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 57;
            this.label3.Text = "Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "Cinsiyet";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Name.Location = new System.Drawing.Point(78, 196);
            this.txtBox_Name.Multiline = true;
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(214, 29);
            this.txtBox_Name.TabIndex = 55;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hayvan Adı";
            // 
            // cb_Tur
            // 
            this.cb_Tur.FormattingEnabled = true;
            this.cb_Tur.Items.AddRange(new object[] {
            "Köpek",
            "Kedi",
            "Hamster",
            "Fare",
            "Tavşan",
            "Tavuk",
            "Ördek",
            "Kuş"});
            this.cb_Tur.Location = new System.Drawing.Point(78, 276);
            this.cb_Tur.Name = "cb_Tur";
            this.cb_Tur.Size = new System.Drawing.Size(214, 24);
            this.cb_Tur.TabIndex = 53;
            this.cb_Tur.TextChanged += new System.EventHandler(this.cb_Tur_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.exit__2_;
            this.pictureBox2.Location = new System.Drawing.Point(722, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_hyvEkle
            // 
            this.btn_hyvEkle.BackColor = System.Drawing.Color.Black;
            this.btn_hyvEkle.FlatAppearance.BorderSize = 0;
            this.btn_hyvEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hyvEkle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hyvEkle.ForeColor = System.Drawing.Color.White;
            this.btn_hyvEkle.ImageKey = "medical-symbol.png";
            this.btn_hyvEkle.ImageList = this.imageList1;
            this.btn_hyvEkle.Location = new System.Drawing.Point(118, 497);
            this.btn_hyvEkle.Name = "btn_hyvEkle";
            this.btn_hyvEkle.Size = new System.Drawing.Size(133, 52);
            this.btn_hyvEkle.TabIndex = 61;
            this.btn_hyvEkle.Text = "Ekle";
            this.btn_hyvEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hyvEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hyvEkle.UseVisualStyleBackColor = false;
            this.btn_hyvEkle.Click += new System.EventHandler(this.btn_hyvEkle_Click_1);
            // 
            // logo
            // 
            this.logo.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.kedii;
            this.logo.Location = new System.Drawing.Point(32, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 80);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 52;
            this.logo.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Black;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.ImageKey = "camera.png";
            this.btnSelectFile.ImageList = this.imageList1;
            this.btnSelectFile.Location = new System.Drawing.Point(427, 462);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(237, 52);
            this.btnSelectFile.TabIndex = 49;
            this.btnSelectFile.Text = "Fotoğraf Seç";
            this.btnSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblHayvanAdiHata
            // 
            this.lblHayvanAdiHata.AutoSize = true;
            this.lblHayvanAdiHata.ForeColor = System.Drawing.Color.Red;
            this.lblHayvanAdiHata.Location = new System.Drawing.Point(88, 229);
            this.lblHayvanAdiHata.Name = "lblHayvanAdiHata";
            this.lblHayvanAdiHata.Size = new System.Drawing.Size(44, 16);
            this.lblHayvanAdiHata.TabIndex = 63;
            this.lblHayvanAdiHata.Text = "label1";
            this.lblHayvanAdiHata.Visible = false;
            // 
            // lblTurHata
            // 
            this.lblTurHata.AutoSize = true;
            this.lblTurHata.ForeColor = System.Drawing.Color.Red;
            this.lblTurHata.Location = new System.Drawing.Point(88, 306);
            this.lblTurHata.Name = "lblTurHata";
            this.lblTurHata.Size = new System.Drawing.Size(44, 16);
            this.lblTurHata.TabIndex = 64;
            this.lblTurHata.Text = "label8";
            this.lblTurHata.Visible = false;
            // 
            // lblCinsiyetHata
            // 
            this.lblCinsiyetHata.AutoSize = true;
            this.lblCinsiyetHata.ForeColor = System.Drawing.Color.Red;
            this.lblCinsiyetHata.Location = new System.Drawing.Point(88, 383);
            this.lblCinsiyetHata.Name = "lblCinsiyetHata";
            this.lblCinsiyetHata.Size = new System.Drawing.Size(44, 16);
            this.lblCinsiyetHata.TabIndex = 65;
            this.lblCinsiyetHata.Text = "label9";
            this.lblCinsiyetHata.Visible = false;
            // 
            // lblYasHata
            // 
            this.lblYasHata.AutoSize = true;
            this.lblYasHata.ForeColor = System.Drawing.Color.Red;
            this.lblYasHata.Location = new System.Drawing.Point(88, 469);
            this.lblYasHata.Name = "lblYasHata";
            this.lblYasHata.Size = new System.Drawing.Size(51, 16);
            this.lblYasHata.TabIndex = 66;
            this.lblYasHata.Text = "label10";
            this.lblYasHata.Visible = false;
            // 
            // frmEvcilHayvanEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(797, 627);
            this.Controls.Add(this.lblYasHata);
            this.Controls.Add(this.lblCinsiyetHata);
            this.Controls.Add(this.lblTurHata);
            this.Controls.Add(this.lblHayvanAdiHata);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_hyvEkle);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Cinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Tur);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvcilHayvanEkleme";
            this.Text = "Evcil Hayvan Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_hyvEkle;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Tur;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHayvanAdiHata;
        private System.Windows.Forms.Label lblTurHata;
        private System.Windows.Forms.Label lblCinsiyetHata;
        private System.Windows.Forms.Label lblYasHata;
    }
}