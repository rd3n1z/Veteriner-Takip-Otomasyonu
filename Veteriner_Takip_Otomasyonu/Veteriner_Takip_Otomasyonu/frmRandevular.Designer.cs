﻿namespace Veteriner_Takip_Otomasyonu
{
    partial class frmRandevular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevular));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_AramaMotoru = new System.Windows.Forms.TextBox();
            this.btn_rndvAl = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Gecmis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "health.png");
            this.ımageList1.Images.SetKeyName(1, "search (3).png");
            this.ımageList1.Images.SetKeyName(2, "search (2).png");
            this.ımageList1.Images.SetKeyName(3, "log-out.png");
            this.ımageList1.Images.SetKeyName(4, "add.png");
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
            this.button1.Location = new System.Drawing.Point(626, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtBox_AramaMotoru
            // 
            this.txtBox_AramaMotoru.BackColor = System.Drawing.Color.White;
            this.txtBox_AramaMotoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_AramaMotoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_AramaMotoru.ForeColor = System.Drawing.Color.Black;
            this.txtBox_AramaMotoru.Location = new System.Drawing.Point(21, 12);
            this.txtBox_AramaMotoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_AramaMotoru.Multiline = true;
            this.txtBox_AramaMotoru.Name = "txtBox_AramaMotoru";
            this.txtBox_AramaMotoru.Size = new System.Drawing.Size(599, 47);
            this.txtBox_AramaMotoru.TabIndex = 7;
            this.txtBox_AramaMotoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_AramaMotoru.TextChanged += new System.EventHandler(this.txtBox_AramaMotoru_TextChanged);
            // 
            // btn_rndvAl
            // 
            this.btn_rndvAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_rndvAl.FlatAppearance.BorderSize = 0;
            this.btn_rndvAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rndvAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rndvAl.ForeColor = System.Drawing.Color.White;
            this.btn_rndvAl.ImageKey = "add.png";
            this.btn_rndvAl.ImageList = this.ımageList1;
            this.btn_rndvAl.Location = new System.Drawing.Point(21, 724);
            this.btn_rndvAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rndvAl.Name = "btn_rndvAl";
            this.btn_rndvAl.Size = new System.Drawing.Size(200, 57);
            this.btn_rndvAl.TabIndex = 13;
            this.btn_rndvAl.Text = "Randevu Al";
            this.btn_rndvAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rndvAl.UseVisualStyleBackColor = false;
            this.btn_rndvAl.Click += new System.EventHandler(this.btn_rndvAl_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 66);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1421, 644);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btn_Gecmis
            // 
            this.btn_Gecmis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Gecmis.FlatAppearance.BorderSize = 0;
            this.btn_Gecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gecmis.ForeColor = System.Drawing.Color.White;
            this.btn_Gecmis.ImageKey = "search (2).png";
            this.btn_Gecmis.ImageList = this.ımageList1;
            this.btn_Gecmis.Location = new System.Drawing.Point(513, 715);
            this.btn_Gecmis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Gecmis.Name = "btn_Gecmis";
            this.btn_Gecmis.Size = new System.Drawing.Size(299, 57);
            this.btn_Gecmis.TabIndex = 14;
            this.btn_Gecmis.Text = "Geçmiş Randevuları Gör";
            this.btn_Gecmis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Gecmis.UseVisualStyleBackColor = false;
            this.btn_Gecmis.Click += new System.EventHandler(this.btn_Gecmis_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "search (2).png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(829, 715);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Aktif Randevuları Gör";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_rndvAl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Gecmis);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_AramaMotoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRandevular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRandevular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_AramaMotoru;
        private System.Windows.Forms.Button btn_rndvAl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Gecmis;
        private System.Windows.Forms.Button button2;
    }
}