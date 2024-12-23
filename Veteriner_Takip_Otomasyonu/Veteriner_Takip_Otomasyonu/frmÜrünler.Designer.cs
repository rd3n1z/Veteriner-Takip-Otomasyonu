namespace Veteriner_Takip_Otomasyonu
{
    partial class frmÜrünler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜrünler));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBox_AramaMotoru = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_urunler = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSepet = new System.Windows.Forms.Panel();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSepettenCikart = new System.Windows.Forms.Button();
            this.btn_SatinAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_urunekle = new System.Windows.Forms.Button();
            this.panelSepet.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "health.png");
            this.ımageList1.Images.SetKeyName(1, "search (3).png");
            this.ımageList1.Images.SetKeyName(2, "log-out.png");
            this.ımageList1.Images.SetKeyName(3, "medical-symbol.png");
            this.ımageList1.Images.SetKeyName(4, "minus.png");
            this.ımageList1.Images.SetKeyName(5, "refresh.png");
            this.ımageList1.Images.SetKeyName(6, "add-to-cart.png");
            // 
            // txtBox_AramaMotoru
            // 
            this.txtBox_AramaMotoru.BackColor = System.Drawing.Color.White;
            this.txtBox_AramaMotoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_AramaMotoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_AramaMotoru.ForeColor = System.Drawing.Color.Black;
            this.txtBox_AramaMotoru.Location = new System.Drawing.Point(160, 14);
            this.txtBox_AramaMotoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_AramaMotoru.Multiline = true;
            this.txtBox_AramaMotoru.Name = "txtBox_AramaMotoru";
            this.txtBox_AramaMotoru.Size = new System.Drawing.Size(599, 49);
            this.txtBox_AramaMotoru.TabIndex = 7;
            this.txtBox_AramaMotoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_AramaMotoru.TextChanged += new System.EventHandler(this.txtBox_AramaMotoru_TextChanged);
            // 
            // flowLayoutPanel_urunler
            // 
            this.flowLayoutPanel_urunler.Location = new System.Drawing.Point(12, 78);
            this.flowLayoutPanel_urunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_urunler.Name = "flowLayoutPanel_urunler";
            this.flowLayoutPanel_urunler.Size = new System.Drawing.Size(847, 694);
            this.flowLayoutPanel_urunler.TabIndex = 10;
            // 
            // panelSepet
            // 
            this.panelSepet.AutoScroll = true;
            this.panelSepet.Controls.Add(this.lblToplamTutar);
            this.panelSepet.Location = new System.Drawing.Point(864, 78);
            this.panelSepet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSepet.Name = "panelSepet";
            this.panelSepet.Size = new System.Drawing.Size(653, 528);
            this.panelSepet.TabIndex = 12;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(17, 21);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 29);
            this.lblToplamTutar.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageKey = "(yok)";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(1052, 733);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ürünleri Düzenle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "refresh.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(1052, 679);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = " Ürünleri Yenile";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSepettenCikart
            // 
            this.BtnSepettenCikart.BackColor = System.Drawing.Color.Black;
            this.BtnSepettenCikart.FlatAppearance.BorderSize = 0;
            this.BtnSepettenCikart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSepettenCikart.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSepettenCikart.ForeColor = System.Drawing.Color.White;
            this.BtnSepettenCikart.ImageKey = "minus.png";
            this.BtnSepettenCikart.ImageList = this.ımageList1;
            this.BtnSepettenCikart.Location = new System.Drawing.Point(1052, 610);
            this.BtnSepettenCikart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSepettenCikart.Name = "BtnSepettenCikart";
            this.BtnSepettenCikart.Size = new System.Drawing.Size(294, 65);
            this.BtnSepettenCikart.TabIndex = 13;
            this.BtnSepettenCikart.Text = " Tüm Ürünleri Çıkar";
            this.BtnSepettenCikart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSepettenCikart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSepettenCikart.UseVisualStyleBackColor = false;
            this.BtnSepettenCikart.Click += new System.EventHandler(this.BtnSepettenCikart_Click);
            // 
            // btn_SatinAl
            // 
            this.btn_SatinAl.BackColor = System.Drawing.Color.Black;
            this.btn_SatinAl.FlatAppearance.BorderSize = 0;
            this.btn_SatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SatinAl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SatinAl.ForeColor = System.Drawing.Color.White;
            this.btn_SatinAl.ImageKey = "add-to-cart.png";
            this.btn_SatinAl.ImageList = this.ımageList1;
            this.btn_SatinAl.Location = new System.Drawing.Point(864, 610);
            this.btn_SatinAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SatinAl.Name = "btn_SatinAl";
            this.btn_SatinAl.Size = new System.Drawing.Size(182, 65);
            this.btn_SatinAl.TabIndex = 11;
            this.btn_SatinAl.Text = "Satın Al";
            this.btn_SatinAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SatinAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SatinAl.UseVisualStyleBackColor = false;
            this.btn_SatinAl.Click += new System.EventHandler(this.btn_SatinAl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "search (3).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(760, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.BackColor = System.Drawing.Color.Black;
            this.btn_urunekle.FlatAppearance.BorderSize = 0;
            this.btn_urunekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunekle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunekle.ForeColor = System.Drawing.Color.White;
            this.btn_urunekle.ImageKey = "add-to-cart.png";
            this.btn_urunekle.ImageList = this.ımageList1;
            this.btn_urunekle.Location = new System.Drawing.Point(865, 679);
            this.btn_urunekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Size = new System.Drawing.Size(182, 65);
            this.btn_urunekle.TabIndex = 17;
            this.btn_urunekle.Text = "Ürün Ekle";
            this.btn_urunekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_urunekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_urunekle.UseVisualStyleBackColor = false;
            this.btn_urunekle.Visible = false;
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click);
            // 
            // frmÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1498, 881);
            this.Controls.Add(this.btn_urunekle);
            this.Controls.Add(this.panelSepet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSepettenCikart);
            this.Controls.Add(this.btn_SatinAl);
            this.Controls.Add(this.flowLayoutPanel_urunler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_AramaMotoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmÜrünler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmÜrünler_Load);
            this.panelSepet.ResumeLayout(false);
            this.panelSepet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_AramaMotoru;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_urunler;
        private System.Windows.Forms.Button btn_SatinAl;
        private System.Windows.Forms.Panel panelSepet;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button BtnSepettenCikart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_urunekle;
    }
}