namespace DijitalSaat_UserControl
{
    partial class DijitalTarih
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
            this.dijitalSaat1 = new DijitalSaat_UserControl.DijitalSaat();
            this.dijitalSayi1 = new DijitalSaat_UserControl.DijitalSayi();
            this.dijitalSayi2 = new DijitalSaat_UserControl.DijitalSayi();
            this.dijitalYil1 = new DijitalSaat_UserControl.DijitalYil();
            this.SuspendLayout();
            // 
            // dijitalSaat1
            // 
            this.dijitalSaat1.Location = new System.Drawing.Point(3, 246);
            this.dijitalSaat1.Name = "dijitalSaat1";
            this.dijitalSaat1.Renk = System.Drawing.Color.Red;
            this.dijitalSaat1.Saat = new System.DateTime(2014, 7, 12, 21, 16, 8, 638);
            this.dijitalSaat1.Size = new System.Drawing.Size(715, 183);
            this.dijitalSaat1.TabIndex = 0;
            // 
            // dijitalSayi1
            // 
            this.dijitalSayi1.Location = new System.Drawing.Point(3, 19);
            this.dijitalSayi1.Name = "dijitalSayi1";
            this.dijitalSayi1.Renk = System.Drawing.Color.Red;
            this.dijitalSayi1.Sayi = 0;
            this.dijitalSayi1.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi1.TabIndex = 1;
            // 
            // dijitalSayi2
            // 
            this.dijitalSayi2.Location = new System.Drawing.Point(260, 19);
            this.dijitalSayi2.Name = "dijitalSayi2";
            this.dijitalSayi2.Renk = System.Drawing.Color.Red;
            this.dijitalSayi2.Sayi = 0;
            this.dijitalSayi2.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi2.TabIndex = 1;
            // 
            // dijitalYil1
            // 
            this.dijitalYil1.Location = new System.Drawing.Point(518, 19);
            this.dijitalYil1.Name = "dijitalYil1";
            this.dijitalYil1.Size = new System.Drawing.Size(440, 178);
            this.dijitalYil1.TabIndex = 2;
            this.dijitalYil1.Yil = 0;
            // 
            // DijitalTarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dijitalYil1);
            this.Controls.Add(this.dijitalSayi2);
            this.Controls.Add(this.dijitalSayi1);
            this.Controls.Add(this.dijitalSaat1);
            this.Name = "DijitalTarih";
            this.Size = new System.Drawing.Size(973, 432);
            this.Load += new System.EventHandler(this.DijitalTarih_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DijitalSaat dijitalSaat1;
        private DijitalSayi dijitalSayi1;
        private DijitalSayi dijitalSayi2;
        private DijitalYil dijitalYil1;
    }
}
