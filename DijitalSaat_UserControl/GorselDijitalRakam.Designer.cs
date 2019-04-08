namespace DijitalSaat_UserControl
{
    partial class GorselDijitalRakam
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
            this.Rakam1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rakam1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rakam1
            // 
            this.Rakam1.Location = new System.Drawing.Point(7, 11);
            this.Rakam1.Name = "Rakam1";
            this.Rakam1.Size = new System.Drawing.Size(41, 59);
            this.Rakam1.TabIndex = 0;
            this.Rakam1.TabStop = false;
            // 
            // GorselDijitalRakam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Rakam1);
            this.Name = "GorselDijitalRakam";
            this.Size = new System.Drawing.Size(55, 82);
            this.Load += new System.EventHandler(this.GorselDijitalRakam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rakam1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Rakam1;
    }
}
