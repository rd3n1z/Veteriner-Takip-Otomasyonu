namespace Veteriner_Takip_Otomasyonu
{
    partial class frmGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisYap));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblParolaHata = new System.Windows.Forms.Label();
            this.lblEpostaHata = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtBox_Parola = new System.Windows.Forms.TextBox();
            this.txtBox_Eposta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.giris_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dog.png");
            this.imageList1.Images.SetKeyName(1, "eye-close.png");
            this.imageList1.Images.SetKeyName(2, "eye-open.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblParolaHata);
            this.panel1.Controls.Add(this.lblEpostaHata);
            this.panel1.Controls.Add(this.btnShowHide);
            this.panel1.Controls.Add(this.txtBox_Parola);
            this.panel1.Controls.Add(this.txtBox_Eposta);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.giris_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(412, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 440);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.exit__1_;
            this.pictureBox3.Location = new System.Drawing.Point(887, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblParolaHata
            // 
            this.lblParolaHata.AutoSize = true;
            this.lblParolaHata.ForeColor = System.Drawing.Color.Red;
            this.lblParolaHata.Location = new System.Drawing.Point(563, 202);
            this.lblParolaHata.Name = "lblParolaHata";
            this.lblParolaHata.Size = new System.Drawing.Size(44, 16);
            this.lblParolaHata.TabIndex = 32;
            this.lblParolaHata.Text = "label4";
            this.lblParolaHata.Visible = false;
            // 
            // lblEpostaHata
            // 
            this.lblEpostaHata.AutoSize = true;
            this.lblEpostaHata.ForeColor = System.Drawing.Color.Red;
            this.lblEpostaHata.Location = new System.Drawing.Point(563, 135);
            this.lblEpostaHata.Name = "lblEpostaHata";
            this.lblEpostaHata.Size = new System.Drawing.Size(44, 16);
            this.lblEpostaHata.TabIndex = 31;
            this.lblEpostaHata.Text = "label3";
            this.lblEpostaHata.Visible = false;
            // 
            // btnShowHide
            // 
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.ImageKey = "eye-open.png";
            this.btnShowHide.ImageList = this.imageList1;
            this.btnShowHide.Location = new System.Drawing.Point(873, 160);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(57, 41);
            this.btnShowHide.TabIndex = 30;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click_1);
            // 
            // txtBox_Parola
            // 
            this.txtBox_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Parola.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBox_Parola.Location = new System.Drawing.Point(558, 156);
            this.txtBox_Parola.Multiline = true;
            this.txtBox_Parola.Name = "txtBox_Parola";
            this.txtBox_Parola.Size = new System.Drawing.Size(309, 41);
            this.txtBox_Parola.TabIndex = 23;
            this.txtBox_Parola.Text = "Parola";
            this.txtBox_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Parola.TextChanged += new System.EventHandler(this.txtBox_Parola_TextChanged);
            // 
            // txtBox_Eposta
            // 
            this.txtBox_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_Eposta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBox_Eposta.Location = new System.Drawing.Point(558, 88);
            this.txtBox_Eposta.Multiline = true;
            this.txtBox_Eposta.Name = "txtBox_Eposta";
            this.txtBox_Eposta.Size = new System.Drawing.Size(309, 41);
            this.txtBox_Eposta.TabIndex = 22;
            this.txtBox_Eposta.Text = "E-posta";
            this.txtBox_Eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Eposta.TextChanged += new System.EventHandler(this.txtBox_Eposta_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(654, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 43);
            this.button3.TabIndex = 21;
            this.button3.Text = "Üye Ol";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hesabınız yoksa hemen üye olun.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(652, 319);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 18);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi unuttum!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.giris_btn.FlatAppearance.BorderSize = 0;
            this.giris_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.giris_btn.Location = new System.Drawing.Point(558, 251);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(309, 45);
            this.giris_btn.TabIndex = 18;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(635, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yapın";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.kedim;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 477);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "köpek.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(829, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGirisYap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Parola;
        private System.Windows.Forms.TextBox txtBox_Eposta;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblParolaHata;
        private System.Windows.Forms.Label lblEpostaHata;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}