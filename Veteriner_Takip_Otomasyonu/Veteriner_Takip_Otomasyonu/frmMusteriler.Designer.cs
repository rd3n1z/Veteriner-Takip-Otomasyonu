namespace Veteriner_Takip_Otomasyonu
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            this.txtBox_AramaMotoru = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_YeniMusteri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_musSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_AramaMotoru
            // 
            this.txtBox_AramaMotoru.BackColor = System.Drawing.Color.White;
            this.txtBox_AramaMotoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_AramaMotoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_AramaMotoru.ForeColor = System.Drawing.Color.Black;
            this.txtBox_AramaMotoru.Location = new System.Drawing.Point(12, 12);
            this.txtBox_AramaMotoru.Multiline = true;
            this.txtBox_AramaMotoru.Name = "txtBox_AramaMotoru";
            this.txtBox_AramaMotoru.Size = new System.Drawing.Size(599, 41);
            this.txtBox_AramaMotoru.TabIndex = 0;
            this.txtBox_AramaMotoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_AramaMotoru.TextChanged += new System.EventHandler(this.txtBox_AramaMotoru_TextChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "search.png");
            this.ımageList1.Images.SetKeyName(1, "search (1).png");
            this.ımageList1.Images.SetKeyName(2, "search (2).png");
            this.ımageList1.Images.SetKeyName(3, "search (3).png");
            this.ımageList1.Images.SetKeyName(4, "search (4).png");
            this.ımageList1.Images.SetKeyName(5, "plus-sign.png");
            this.ımageList1.Images.SetKeyName(6, "health.png");
            this.ımageList1.Images.SetKeyName(7, "trash.png");
            this.ımageList1.Images.SetKeyName(8, "refresh.png");
            // 
            // btn_YeniMusteri
            // 
            this.btn_YeniMusteri.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_YeniMusteri.FlatAppearance.BorderSize = 0;
            this.btn_YeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YeniMusteri.ForeColor = System.Drawing.Color.White;
            this.btn_YeniMusteri.ImageKey = "health.png";
            this.btn_YeniMusteri.ImageList = this.ımageList1;
            this.btn_YeniMusteri.Location = new System.Drawing.Point(1580, 11);
            this.btn_YeniMusteri.Name = "btn_YeniMusteri";
            this.btn_YeniMusteri.Size = new System.Drawing.Size(290, 56);
            this.btn_YeniMusteri.TabIndex = 2;
            this.btn_YeniMusteri.Text = "    Yeni Müşteri";
            this.btn_YeniMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_YeniMusteri.UseVisualStyleBackColor = false;
            this.btn_YeniMusteri.Click += new System.EventHandler(this.btn_YeniMusteri_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Thistle;
            this.button1.ImageKey = "search (3).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(617, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 4;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1857, 653);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_musSil
            // 
            this.btn_musSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_musSil.FlatAppearance.BorderSize = 0;
            this.btn_musSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musSil.ForeColor = System.Drawing.Color.White;
            this.btn_musSil.ImageKey = "trash.png";
            this.btn_musSil.ImageList = this.ımageList1;
            this.btn_musSil.Location = new System.Drawing.Point(228, 718);
            this.btn_musSil.Name = "btn_musSil";
            this.btn_musSil.Size = new System.Drawing.Size(210, 53);
            this.btn_musSil.TabIndex = 19;
            this.btn_musSil.Text = "Müşteri Sil";
            this.btn_musSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_musSil.UseVisualStyleBackColor = false;
            this.btn_musSil.Click += new System.EventHandler(this.btn_musSil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "refresh.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 718);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 53);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sayfayı Yenile";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_musSil);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_YeniMusteri);
            this.Controls.Add(this.txtBox_AramaMotoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_AramaMotoru;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_YeniMusteri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_musSil;
        private System.Windows.Forms.Button button2;
    }
}