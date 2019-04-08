namespace DijitalSaat_UserControl
{
    partial class DijitalSayi
    {
        /// <summary> 
        ///Gerekli designer değişkeni.
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - değiştirmeyin 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dijitalRakam1 = new DijitalSaat_UserControl.DijitalRakam();
            this.dijitalRakam2 = new DijitalSaat_UserControl.DijitalRakam();
            this.SuspendLayout();
            // 
            // dijitalRakam1
            // 
            this.dijitalRakam1.Location = new System.Drawing.Point(3, 3);
            this.dijitalRakam1.Name = "dijitalRakam1";
            this.dijitalRakam1.Rakam = 0;
            this.dijitalRakam1.Renk = System.Drawing.Color.Empty;
            this.dijitalRakam1.Size = new System.Drawing.Size(93, 172);
            this.dijitalRakam1.TabIndex = 0;
            this.dijitalRakam1.Load += new System.EventHandler(this.dijitalRakam1_Load);
            // 
            // dijitalRakam2
            // 
            this.dijitalRakam2.Location = new System.Drawing.Point(118, 5);
            this.dijitalRakam2.Name = "dijitalRakam2";
            this.dijitalRakam2.Rakam = 0;
            this.dijitalRakam2.Renk = System.Drawing.Color.Empty;
            this.dijitalRakam2.Size = new System.Drawing.Size(93, 172);
            this.dijitalRakam2.TabIndex = 1;
            this.dijitalRakam2.Load += new System.EventHandler(this.dijitalRakam2_Load);
            // 
            // DijitalSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dijitalRakam2);
            this.Controls.Add(this.dijitalRakam1);
            this.Name = "DijitalSayi";
            this.Size = new System.Drawing.Size(214, 177);
            this.Load += new System.EventHandler(this.DijitalSayi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DijitalRakam dijitalRakam1;
        private DijitalRakam dijitalRakam2;
    }
}
