namespace Veteriner_Takip_Otomasyonu
{
    partial class frmEvcilHayvanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvcilHayvanlar));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBox_AramaMotoru = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_hyvEkle = new System.Windows.Forms.Button();
            this.btn_hyvSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search (3).png");
            this.imageList1.Images.SetKeyName(1, "search (2).png");
            this.imageList1.Images.SetKeyName(2, "health.png");
            this.imageList1.Images.SetKeyName(3, "computer-icons-scalable-vector-graphics-avatar-emoticon-png-favpng-209NAXaV1ZBQdY" +
        "GrU7nNbMxpX.jpg");
            this.imageList1.Images.SetKeyName(4, "refresh.png");
            this.imageList1.Images.SetKeyName(5, "trash.png");
            this.imageList1.Images.SetKeyName(6, "arrow.png");
            this.imageList1.Images.SetKeyName(7, "trash2.png");
            this.imageList1.Images.SetKeyName(8, "add.png");
            // 
            // txtBox_AramaMotoru
            // 
            this.txtBox_AramaMotoru.BackColor = System.Drawing.Color.White;
            this.txtBox_AramaMotoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_AramaMotoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_AramaMotoru.ForeColor = System.Drawing.Color.Black;
            this.txtBox_AramaMotoru.Location = new System.Drawing.Point(203, 26);
            this.txtBox_AramaMotoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_AramaMotoru.Multiline = true;
            this.txtBox_AramaMotoru.Name = "txtBox_AramaMotoru";
            this.txtBox_AramaMotoru.Size = new System.Drawing.Size(599, 47);
            this.txtBox_AramaMotoru.TabIndex = 5;
            this.txtBox_AramaMotoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_AramaMotoru.TextChanged += new System.EventHandler(this.txtBox_AramaMotoru_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 96);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1353, 617);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            // btn_hyvEkle
            // 
            this.btn_hyvEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_hyvEkle.FlatAppearance.BorderSize = 0;
            this.btn_hyvEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hyvEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hyvEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_hyvEkle.ImageKey = "add.png";
            this.btn_hyvEkle.ImageList = this.imageList1;
            this.btn_hyvEkle.Location = new System.Drawing.Point(1081, 718);
            this.btn_hyvEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hyvEkle.Name = "btn_hyvEkle";
            this.btn_hyvEkle.Size = new System.Drawing.Size(291, 57);
            this.btn_hyvEkle.TabIndex = 12;
            this.btn_hyvEkle.Text = "Yeni Evcil Hayvan Ekle";
            this.btn_hyvEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hyvEkle.UseVisualStyleBackColor = false;
            this.btn_hyvEkle.Click += new System.EventHandler(this.btn_hyvEkle_Click);
            // 
            // btn_hyvSil
            // 
            this.btn_hyvSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btn_hyvSil.FlatAppearance.BorderSize = 0;
            this.btn_hyvSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hyvSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hyvSil.ForeColor = System.Drawing.Color.Black;
            this.btn_hyvSil.ImageKey = "trash2.png";
            this.btn_hyvSil.ImageList = this.imageList1;
            this.btn_hyvSil.Location = new System.Drawing.Point(665, 718);
            this.btn_hyvSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hyvSil.Name = "btn_hyvSil";
            this.btn_hyvSil.Size = new System.Drawing.Size(211, 53);
            this.btn_hyvSil.TabIndex = 18;
            this.btn_hyvSil.Text = "Hayvan Sil";
            this.btn_hyvSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hyvSil.UseVisualStyleBackColor = false;
            this.btn_hyvSil.Click += new System.EventHandler(this.btn_hyvSil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageKey = "arrow.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(431, 718);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sayfayı Yenile";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "search (3).png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(801, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEvcilHayvanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 782);
            this.Controls.Add(this.btn_hyvEkle);
            this.Controls.Add(this.btn_hyvSil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_AramaMotoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEvcilHayvanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_AramaMotoru;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btn_hyvEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_hyvSil;
    }
}