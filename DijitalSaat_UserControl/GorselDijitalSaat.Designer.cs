namespace DijitalSaat_UserControl
{
    partial class GorselDijitalSaat
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
            this.Saat1 = new System.Windows.Forms.PictureBox();
            this.Saat2 = new System.Windows.Forms.PictureBox();
            this.Dakika2 = new System.Windows.Forms.PictureBox();
            this.Dakika1 = new System.Windows.Forms.PictureBox();
            this.Saniye2 = new System.Windows.Forms.PictureBox();
            this.Saniye1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Saat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saniye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saniye1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saat1
            // 
            this.Saat1.Enabled = false;
            this.Saat1.Location = new System.Drawing.Point(7, 10);
            this.Saat1.Name = "Saat1";
            this.Saat1.Size = new System.Drawing.Size(41, 59);
            this.Saat1.TabIndex = 0;
            this.Saat1.TabStop = false;
            // 
            // Saat2
            // 
            this.Saat2.Enabled = false;
            this.Saat2.Location = new System.Drawing.Point(48, 10);
            this.Saat2.Name = "Saat2";
            this.Saat2.Size = new System.Drawing.Size(41, 59);
            this.Saat2.TabIndex = 1;
            this.Saat2.TabStop = false;
            // 
            // Dakika2
            // 
            this.Dakika2.Enabled = false;
            this.Dakika2.Location = new System.Drawing.Point(135, 10);
            this.Dakika2.Name = "Dakika2";
            this.Dakika2.Size = new System.Drawing.Size(41, 59);
            this.Dakika2.TabIndex = 3;
            this.Dakika2.TabStop = false;
            // 
            // Dakika1
            // 
            this.Dakika1.Enabled = false;
            this.Dakika1.Location = new System.Drawing.Point(94, 10);
            this.Dakika1.Name = "Dakika1";
            this.Dakika1.Size = new System.Drawing.Size(41, 59);
            this.Dakika1.TabIndex = 2;
            this.Dakika1.TabStop = false;
            // 
            // Saniye2
            // 
            this.Saniye2.Enabled = false;
            this.Saniye2.Location = new System.Drawing.Point(200, 10);
            this.Saniye2.Name = "Saniye2";
            this.Saniye2.Size = new System.Drawing.Size(18, 27);
            this.Saniye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Saniye2.TabIndex = 5;
            this.Saniye2.TabStop = false;
            // 
            // Saniye1
            // 
            this.Saniye1.Enabled = false;
            this.Saniye1.Location = new System.Drawing.Point(182, 10);
            this.Saniye1.Name = "Saniye1";
            this.Saniye1.Size = new System.Drawing.Size(18, 27);
            this.Saniye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Saniye1.TabIndex = 4;
            this.Saniye1.TabStop = false;
            // 
            // GorselDijitalSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Saniye2);
            this.Controls.Add(this.Saniye1);
            this.Controls.Add(this.Dakika2);
            this.Controls.Add(this.Dakika1);
            this.Controls.Add(this.Saat2);
            this.Controls.Add(this.Saat1);
            this.Name = "GorselDijitalSaat";
            this.Size = new System.Drawing.Size(228, 82);
            this.Load += new System.EventHandler(this.GorselDijitalSaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Saat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saniye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saniye1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Saat1;
        private System.Windows.Forms.PictureBox Saat2;
        private System.Windows.Forms.PictureBox Dakika2;
        private System.Windows.Forms.PictureBox Dakika1;
        private System.Windows.Forms.PictureBox Saniye2;
        private System.Windows.Forms.PictureBox Saniye1;
    }
}
