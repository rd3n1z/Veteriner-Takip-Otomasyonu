namespace Veteriner_Takip_Otomasyonu
{
    partial class frmAnaEkran
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
            this.lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.btn_petsView = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_viewDates = new System.Windows.Forms.Button();
            this.btn_invoices = new System.Windows.Forms.Button();
            this.btn_vaccine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ad_Soyad
            // 
            this.lbl_Ad_Soyad.AutoSize = true;
            this.lbl_Ad_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad_Soyad.Location = new System.Drawing.Point(1092, 200);
            this.lbl_Ad_Soyad.Name = "lbl_Ad_Soyad";
            this.lbl_Ad_Soyad.Size = new System.Drawing.Size(92, 32);
            this.lbl_Ad_Soyad.TabIndex = 1;
            this.lbl_Ad_Soyad.Text = "label1";
            this.lbl_Ad_Soyad.Click += new System.EventHandler(this.lbl_Ad_Soyad_Click);
            // 
            // btn_petsView
            // 
            this.btn_petsView.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_petsView.FlatAppearance.BorderSize = 0;
            this.btn_petsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_petsView.ForeColor = System.Drawing.Color.White;
            this.btn_petsView.ImageKey = "(none)";
            this.btn_petsView.Location = new System.Drawing.Point(876, 763);
            this.btn_petsView.Name = "btn_petsView";
            this.btn_petsView.Size = new System.Drawing.Size(210, 60);
            this.btn_petsView.TabIndex = 10;
            this.btn_petsView.Text = "Evcil Hayvanlarını Görüntüle";
            this.btn_petsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_petsView.UseVisualStyleBackColor = false;
            this.btn_petsView.Click += new System.EventHandler(this.btn_petsView_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.ImageKey = "health.png";
            this.btn_buy.Location = new System.Drawing.Point(660, 763);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(210, 60);
            this.btn_buy.TabIndex = 11;
            this.btn_buy.Text = "Ürün Satın Al";
            this.btn_buy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_viewDates
            // 
            this.btn_viewDates.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_viewDates.FlatAppearance.BorderSize = 0;
            this.btn_viewDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_viewDates.ForeColor = System.Drawing.Color.White;
            this.btn_viewDates.ImageKey = "health.png";
            this.btn_viewDates.Location = new System.Drawing.Point(444, 763);
            this.btn_viewDates.Name = "btn_viewDates";
            this.btn_viewDates.Size = new System.Drawing.Size(210, 60);
            this.btn_viewDates.TabIndex = 12;
            this.btn_viewDates.Text = "Randevuları Görüntüle";
            this.btn_viewDates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_viewDates.UseVisualStyleBackColor = false;
            this.btn_viewDates.Click += new System.EventHandler(this.btn_viewDates_Click);
            // 
            // btn_invoices
            // 
            this.btn_invoices.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_invoices.FlatAppearance.BorderSize = 0;
            this.btn_invoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_invoices.ForeColor = System.Drawing.Color.White;
            this.btn_invoices.ImageKey = "health.png";
            this.btn_invoices.Location = new System.Drawing.Point(228, 763);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(210, 60);
            this.btn_invoices.TabIndex = 13;
            this.btn_invoices.Text = "Faturaları Görüntüle";
            this.btn_invoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_invoices.UseVisualStyleBackColor = false;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // btn_vaccine
            // 
            this.btn_vaccine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_vaccine.FlatAppearance.BorderSize = 0;
            this.btn_vaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vaccine.ForeColor = System.Drawing.Color.White;
            this.btn_vaccine.ImageKey = "health.png";
            this.btn_vaccine.Location = new System.Drawing.Point(12, 763);
            this.btn_vaccine.Name = "btn_vaccine";
            this.btn_vaccine.Size = new System.Drawing.Size(210, 60);
            this.btn_vaccine.TabIndex = 14;
            this.btn_vaccine.Text = "Aşı Takvimi";
            this.btn_vaccine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_vaccine.UseVisualStyleBackColor = false;
            this.btn_vaccine.Click += new System.EventHandler(this.btn_vaccine_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 745);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veteriner_Takip_Otomasyonu.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(1098, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Rol.Location = new System.Drawing.Point(1092, 249);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(92, 32);
            this.lbl_Rol.TabIndex = 16;
            this.lbl_Rol.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(1092, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "Müşterileri Görüntüle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 835);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_vaccine);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_viewDates);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_petsView);
            this.Controls.Add(this.lbl_Ad_Soyad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Ad_Soyad;
        private System.Windows.Forms.Button btn_petsView;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_viewDates;
        private System.Windows.Forms.Button btn_invoices;
        private System.Windows.Forms.Button btn_vaccine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Button button1;
    }
}