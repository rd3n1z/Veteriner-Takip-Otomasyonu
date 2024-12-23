namespace Veteriner_Takip_Otomasyonu
{
    partial class frmAdminEvcilEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminEvcilEkle));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Tur = new System.Windows.Forms.ComboBox();
            this.cb_Sahip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_hyvEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Black;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.ImageKey = "camera (1).png";
            this.btnSelectFile.ImageList = this.ımageList1;
            this.btnSelectFile.Location = new System.Drawing.Point(427, 466);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(242, 60);
            this.btnSelectFile.TabIndex = 41;
            this.btnSelectFile.Text = "Fotoğraf Seç";
            this.btnSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "trash.png");
            this.ımageList1.Images.SetKeyName(1, "log-out.png");
            this.ımageList1.Images.SetKeyName(2, "exit (2).png");
            this.ımageList1.Images.SetKeyName(3, "camera (1).png");
            this.ımageList1.Images.SetKeyName(4, "medical-symbol.png");
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Age.Location = new System.Drawing.Point(91, 389);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(214, 23);
            this.txtBox_Age.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Yaş";
            // 
            // cb_Cinsiyet
            // 
            this.cb_Cinsiyet.FormattingEnabled = true;
            this.cb_Cinsiyet.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cb_Cinsiyet.Location = new System.Drawing.Point(91, 316);
            this.cb_Cinsiyet.Name = "cb_Cinsiyet";
            this.cb_Cinsiyet.Size = new System.Drawing.Size(214, 24);
            this.cb_Cinsiyet.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cinsiyet";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Name.Location = new System.Drawing.Point(91, 158);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(214, 23);
            this.txtBox_Name.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hayvan Adı";
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
            this.cb_Tur.Location = new System.Drawing.Point(91, 236);
            this.cb_Tur.Name = "cb_Tur";
            this.cb_Tur.Size = new System.Drawing.Size(214, 24);
            this.cb_Tur.TabIndex = 30;
            // 
            // cb_Sahip
            // 
            this.cb_Sahip.FormattingEnabled = true;
            this.cb_Sahip.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cb_Sahip.Location = new System.Drawing.Point(91, 466);
            this.cb_Sahip.Name = "cb_Sahip";
            this.cb_Sahip.Size = new System.Drawing.Size(214, 24);
            this.cb_Sahip.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(86, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sahibi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 40);
            this.label7.TabIndex = 45;
            this.label7.Text = "HAYVAN EKLE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.kedii;
            this.pictureBox2.Location = new System.Drawing.Point(32, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btn_hyvEkle
            // 
            this.btn_hyvEkle.BackColor = System.Drawing.Color.Black;
            this.btn_hyvEkle.FlatAppearance.BorderSize = 0;
            this.btn_hyvEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hyvEkle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hyvEkle.ForeColor = System.Drawing.Color.White;
            this.btn_hyvEkle.ImageKey = "medical-symbol.png";
            this.btn_hyvEkle.ImageList = this.ımageList1;
            this.btn_hyvEkle.Location = new System.Drawing.Point(91, 526);
            this.btn_hyvEkle.Name = "btn_hyvEkle";
            this.btn_hyvEkle.Size = new System.Drawing.Size(143, 60);
            this.btn_hyvEkle.TabIndex = 38;
            this.btn_hyvEkle.Text = "Ekle";
            this.btn_hyvEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hyvEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hyvEkle.UseVisualStyleBackColor = false;
            this.btn_hyvEkle.Click += new System.EventHandler(this.btn_hyvEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(422, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Hayvan Fotoğrafı Ekle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "exit (2).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(707, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 60);
            this.button1.TabIndex = 48;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdminEvcilEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(797, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Sahip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btn_hyvEkle);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Cinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Tur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminEvcilEkle";
            this.Text = "frmAdminEvcilEkle";
            this.Load += new System.EventHandler(this.frmAdminEvcilEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btn_hyvEkle;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Tur;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ComboBox cb_Sahip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}