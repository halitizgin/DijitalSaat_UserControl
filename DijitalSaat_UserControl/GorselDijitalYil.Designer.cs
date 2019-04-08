namespace DijitalSaat_UserControl
{
    partial class GorselDijitalYil
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
            this.Sene1 = new System.Windows.Forms.PictureBox();
            this.Sene2 = new System.Windows.Forms.PictureBox();
            this.Sene3 = new System.Windows.Forms.PictureBox();
            this.Sene4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sene1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene4)).BeginInit();
            this.SuspendLayout();
            // 
            // Sene1
            // 
            this.Sene1.Location = new System.Drawing.Point(26, 12);
            this.Sene1.Name = "Sene1";
            this.Sene1.Size = new System.Drawing.Size(41, 59);
            this.Sene1.TabIndex = 0;
            this.Sene1.TabStop = false;
            // 
            // Sene2
            // 
            this.Sene2.Location = new System.Drawing.Point(67, 12);
            this.Sene2.Name = "Sene2";
            this.Sene2.Size = new System.Drawing.Size(41, 59);
            this.Sene2.TabIndex = 1;
            this.Sene2.TabStop = false;
            // 
            // Sene3
            // 
            this.Sene3.Location = new System.Drawing.Point(108, 12);
            this.Sene3.Name = "Sene3";
            this.Sene3.Size = new System.Drawing.Size(41, 59);
            this.Sene3.TabIndex = 2;
            this.Sene3.TabStop = false;
            // 
            // Sene4
            // 
            this.Sene4.Location = new System.Drawing.Point(149, 12);
            this.Sene4.Name = "Sene4";
            this.Sene4.Size = new System.Drawing.Size(41, 59);
            this.Sene4.TabIndex = 3;
            this.Sene4.TabStop = false;
            // 
            // GorselDijitalYil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Sene4);
            this.Controls.Add(this.Sene3);
            this.Controls.Add(this.Sene2);
            this.Controls.Add(this.Sene1);
            this.Name = "GorselDijitalYil";
            this.Size = new System.Drawing.Size(228, 82);
            this.Load += new System.EventHandler(this.GorselDijitalYil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sene1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sene4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Sene1;
        private System.Windows.Forms.PictureBox Sene2;
        private System.Windows.Forms.PictureBox Sene3;
        private System.Windows.Forms.PictureBox Sene4;
    }
}
