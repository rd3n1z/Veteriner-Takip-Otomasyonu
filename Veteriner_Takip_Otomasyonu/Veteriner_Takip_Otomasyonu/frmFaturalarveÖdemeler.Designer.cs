namespace Veteriner_Takip_Otomasyonu
{
    partial class frmFaturalarveÖdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturalarveÖdemeler));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_AramaMotoru = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_Faturalar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "health.png");
            this.ımageList1.Images.SetKeyName(1, "search (2).png");
            this.ımageList1.Images.SetKeyName(2, "search (3).png");
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
            this.button1.Location = new System.Drawing.Point(1211, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 48);
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
            this.txtBox_AramaMotoru.Location = new System.Drawing.Point(612, 12);
            this.txtBox_AramaMotoru.Multiline = true;
            this.txtBox_AramaMotoru.Name = "txtBox_AramaMotoru";
            this.txtBox_AramaMotoru.Size = new System.Drawing.Size(599, 48);
            this.txtBox_AramaMotoru.TabIndex = 7;
            this.txtBox_AramaMotoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel_Faturalar
            // 
            this.flowLayoutPanel_Faturalar.Location = new System.Drawing.Point(12, 77);
            this.flowLayoutPanel_Faturalar.Name = "flowLayoutPanel_Faturalar";
            this.flowLayoutPanel_Faturalar.Size = new System.Drawing.Size(1858, 694);
            this.flowLayoutPanel_Faturalar.TabIndex = 12;
            this.flowLayoutPanel_Faturalar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Faturalar_Paint);
            // 
            // frmFaturalarveÖdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 770);
            this.Controls.Add(this.flowLayoutPanel_Faturalar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_AramaMotoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFaturalarveÖdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFaturalarveÖdemeler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_AramaMotoru;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Faturalar;
    }
}