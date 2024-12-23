namespace Veteriner_Takip_Otomasyonu
{
    partial class frmUrunDuzenle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmb_urunler = new System.Windows.Forms.ComboBox();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.tb_urunAdi = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_urunler
            // 
            this.cmb_urunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_urunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_urunler.ForeColor = System.Drawing.Color.Black;
            this.cmb_urunler.Location = new System.Drawing.Point(512, 218);
            this.cmb_urunler.Name = "cmb_urunler";
            this.cmb_urunler.Size = new System.Drawing.Size(436, 24);
            this.cmb_urunler.TabIndex = 0;
            this.cmb_urunler.SelectedIndexChanged += new System.EventHandler(this.cmb_urunler_SelectedIndexChanged);
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdi.Location = new System.Drawing.Point(402, 272);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(94, 22);
            this.lbl_urunAdi.TabIndex = 1;
            this.lbl_urunAdi.Text = "Ürün Adı:";
            // 
            // tb_urunAdi
            // 
            this.tb_urunAdi.Location = new System.Drawing.Point(512, 272);
            this.tb_urunAdi.Multiline = true;
            this.tb_urunAdi.Name = "tb_urunAdi";
            this.tb_urunAdi.Size = new System.Drawing.Size(436, 39);
            this.tb_urunAdi.TabIndex = 2;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fiyat.Location = new System.Drawing.Point(436, 331);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(60, 22);
            this.lbl_fiyat.TabIndex = 3;
            this.lbl_fiyat.Text = "Fiyat:";
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(512, 333);
            this.tb_fiyat.Multiline = true;
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(436, 39);
            this.tb_fiyat.TabIndex = 4;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stok.Location = new System.Drawing.Point(440, 390);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(56, 22);
            this.lbl_stok.TabIndex = 5;
            this.lbl_stok.Text = "Stok:";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(512, 390);
            this.tb_stok.Multiline = true;
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(436, 39);
            this.tb_stok.TabIndex = 6;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(619, 471);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(213, 49);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürün Seç :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 67);
            this.panel1.TabIndex = 9;
            this.panel1.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(535, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Düzenleme İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.exit__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1427, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmUrunDuzenle
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1486, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_urunler);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.tb_urunAdi);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.tb_fiyat);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.btn_guncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Düzenleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmb_urunler;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.TextBox tb_urunAdi;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Button btn_guncelle;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
