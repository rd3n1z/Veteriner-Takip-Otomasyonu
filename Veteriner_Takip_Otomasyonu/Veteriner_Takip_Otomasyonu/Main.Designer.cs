using System;

namespace Veteriner_Takip_Otomasyonu
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnOzellikler = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btnAsi = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnEvcil = new System.Windows.Forms.Button();
            this.btnUrn = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "paw.png");
            this.ımageList1.Images.SetKeyName(1, "animal.png");
            this.ımageList1.Images.SetKeyName(2, "dog.png");
            this.ımageList1.Images.SetKeyName(3, "log-out.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageIndex = 2;
            this.label3.ImageList = this.ımageList1;
            this.label3.Location = new System.Drawing.Point(169, 11);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(190, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "    petvet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "telefon.png");
            this.ımageList2.Images.SetKeyName(1, "telefonn.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(892, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOzellikler
            // 
            this.btnOzellikler.BackColor = System.Drawing.Color.Transparent;
            this.btnOzellikler.FlatAppearance.BorderSize = 0;
            this.btnOzellikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOzellikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOzellikler.Location = new System.Drawing.Point(1021, 14);
            this.btnOzellikler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOzellikler.Name = "btnOzellikler";
            this.btnOzellikler.Size = new System.Drawing.Size(123, 41);
            this.btnOzellikler.TabIndex = 11;
            this.btnOzellikler.Text = "Özellikler";
            this.btnOzellikler.UseVisualStyleBackColor = false;
            this.btnOzellikler.Click += new System.EventHandler(this.btnOzellikler_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.btnAsi);
            this.panel_menu.Controls.Add(this.btnMusteri);
            this.panel_menu.Controls.Add(this.btnEvcil);
            this.panel_menu.Controls.Add(this.btnUrn);
            this.panel_menu.Controls.Add(this.btnFatura);
            this.panel_menu.Controls.Add(this.btnRandevu);
            this.panel_menu.Location = new System.Drawing.Point(784, 49);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(453, 360);
            this.panel_menu.TabIndex = 17;
            this.panel_menu.Visible = false;
            // 
            // btnAsi
            // 
            this.btnAsi.BackColor = System.Drawing.Color.White;
            this.btnAsi.FlatAppearance.BorderSize = 0;
            this.btnAsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsi.ImageKey = "syringe.png";
            this.btnAsi.ImageList = this.ımageList3;
            this.btnAsi.Location = new System.Drawing.Point(0, 297);
            this.btnAsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsi.Name = "btnAsi";
            this.btnAsi.Size = new System.Drawing.Size(453, 62);
            this.btnAsi.TabIndex = 1;
            this.btnAsi.Text = "       Aşı Takvimi\r\n       Aşıları kolayca takip edin.";
            this.btnAsi.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAsi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsi.UseVisualStyleBackColor = false;
            this.btnAsi.Click += new System.EventHandler(this.btnAsi_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "customer-centricity.png");
            this.ımageList3.Images.SetKeyName(1, "customer-target.png");
            this.ımageList3.Images.SetKeyName(2, "love.png");
            this.ımageList3.Images.SetKeyName(3, "heart-rate.png");
            this.ımageList3.Images.SetKeyName(4, "hearts.png");
            this.ımageList3.Images.SetKeyName(5, "heart.png");
            this.ımageList3.Images.SetKeyName(6, "love (1).png");
            this.ımageList3.Images.SetKeyName(7, "calendar.png");
            this.ımageList3.Images.SetKeyName(8, "calendar (1).png");
            this.ımageList3.Images.SetKeyName(9, "money.png");
            this.ımageList3.Images.SetKeyName(10, "credit-card.png");
            this.ımageList3.Images.SetKeyName(11, "credit-card (1).png");
            this.ımageList3.Images.SetKeyName(12, "box.png");
            this.ımageList3.Images.SetKeyName(13, "delivery-time.png");
            this.ımageList3.Images.SetKeyName(14, "box (1).png");
            this.ımageList3.Images.SetKeyName(15, "delivery-box.png");
            this.ımageList3.Images.SetKeyName(16, "syringe.png");
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.White;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.ImageKey = "customer-centricity.png";
            this.btnMusteri.ImageList = this.ımageList3;
            this.btnMusteri.Location = new System.Drawing.Point(0, -1);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(453, 62);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "       Müşteriler\r\n       Kolay müşteri yönetimi.\r\n";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Visible = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnEvcil
            // 
            this.btnEvcil.BackColor = System.Drawing.Color.White;
            this.btnEvcil.FlatAppearance.BorderSize = 0;
            this.btnEvcil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvcil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvcil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvcil.ImageKey = "heart.png";
            this.btnEvcil.ImageList = this.ımageList3;
            this.btnEvcil.Location = new System.Drawing.Point(0, 59);
            this.btnEvcil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvcil.Name = "btnEvcil";
            this.btnEvcil.Size = new System.Drawing.Size(453, 62);
            this.btnEvcil.TabIndex = 5;
            this.btnEvcil.Text = "       Evcil Hayvanlar\r\n       Evcil hayvanları detaylı yönetin.";
            this.btnEvcil.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEvcil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvcil.UseVisualStyleBackColor = false;
            this.btnEvcil.Click += new System.EventHandler(this.btnEvcil_Click);
            // 
            // btnUrn
            // 
            this.btnUrn.BackColor = System.Drawing.Color.White;
            this.btnUrn.FlatAppearance.BorderSize = 0;
            this.btnUrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrn.ImageKey = "box (1).png";
            this.btnUrn.ImageList = this.ımageList3;
            this.btnUrn.Location = new System.Drawing.Point(0, 238);
            this.btnUrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrn.Name = "btnUrn";
            this.btnUrn.Size = new System.Drawing.Size(453, 62);
            this.btnUrn.TabIndex = 4;
            this.btnUrn.Text = "       Ürünler\r\n       Ürünlerinizi ve stoklarınızı anlık takip edin.";
            this.btnUrn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUrn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrn.UseVisualStyleBackColor = false;
            this.btnUrn.Click += new System.EventHandler(this.btnUrn_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.White;
            this.btnFatura.FlatAppearance.BorderSize = 0;
            this.btnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFatura.ImageKey = "credit-card.png";
            this.btnFatura.ImageList = this.ımageList3;
            this.btnFatura.Location = new System.Drawing.Point(0, 175);
            this.btnFatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(453, 53);
            this.btnFatura.TabIndex = 3;
            this.btnFatura.Text = "       Faturalar ve Ödemeler\r\n       Gelirlerinizi ve alacaklarınızı takip edin.\r" +
    "\n\r\n\r\n";
            this.btnFatura.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.White;
            this.btnRandevu.FlatAppearance.BorderSize = 0;
            this.btnRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevu.ImageKey = "calendar (1).png";
            this.btnRandevu.ImageList = this.ımageList3;
            this.btnRandevu.Location = new System.Drawing.Point(0, 118);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(453, 62);
            this.btnRandevu.TabIndex = 2;
            this.btnRandevu.Text = "       Randevular\r\n       Randevularınızı kaçırmayın.";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRandevu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevu.UseVisualStyleBackColor = false;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(163, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1547, 830);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageKey = "log-out.png";
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(1635, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 69);
            this.btnExit.TabIndex = 19;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Veteriner_Takip_Otomasyonu.Properties.Resources.ne;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.btnOzellikler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOzellikler;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btnAsi;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnEvcil;
        private System.Windows.Forms.Button btnUrn;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
    }
}

