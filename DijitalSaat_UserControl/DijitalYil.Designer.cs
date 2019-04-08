namespace DijitalSaat_UserControl
{
    partial class DijitalYil
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
            this.dijitalSayi2 = new DijitalSaat_UserControl.DijitalSayi();
            this.dijitalSayi1 = new DijitalSaat_UserControl.DijitalSayi();
            this.SuspendLayout();
            // 
            // dijitalSayi2
            // 
            this.dijitalSayi2.Location = new System.Drawing.Point(227, 5);
            this.dijitalSayi2.Name = "dijitalSayi2";
            this.dijitalSayi2.Renk = System.Drawing.Color.Red;
            this.dijitalSayi2.Sayi = 0;
            this.dijitalSayi2.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi2.TabIndex = 0;
            // 
            // dijitalSayi1
            // 
            this.dijitalSayi1.Location = new System.Drawing.Point(3, 3);
            this.dijitalSayi1.Name = "dijitalSayi1";
            this.dijitalSayi1.Renk = System.Drawing.Color.Red;
            this.dijitalSayi1.Sayi = 0;
            this.dijitalSayi1.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi1.TabIndex = 0;
            // 
            // DijitalYil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dijitalSayi2);
            this.Controls.Add(this.dijitalSayi1);
            this.Name = "DijitalYil";
            this.Size = new System.Drawing.Size(440, 178);
            this.Load += new System.EventHandler(this.DijitalYil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DijitalSayi dijitalSayi1;
        private DijitalSayi dijitalSayi2;
    }
}
