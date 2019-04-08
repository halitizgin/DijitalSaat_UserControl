namespace DijitalSaat_UserControl
{
    partial class DijitalSaat
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dijitalSayi3 = new DijitalSaat_UserControl.DijitalSayi();
            this.dijitalSayi2 = new DijitalSaat_UserControl.DijitalSayi();
            this.dijitalSayi1 = new DijitalSaat_UserControl.DijitalSayi();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // dijitalSayi3
            // 
            this.dijitalSayi3.Location = new System.Drawing.Point(504, 3);
            this.dijitalSayi3.Name = "dijitalSayi3";
            this.dijitalSayi3.Renk = System.Drawing.Color.Empty;
            this.dijitalSayi3.Sayi = 0;
            this.dijitalSayi3.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi3.TabIndex = 3;
            // 
            // dijitalSayi2
            // 
            this.dijitalSayi2.Location = new System.Drawing.Point(253, 3);
            this.dijitalSayi2.Name = "dijitalSayi2";
            this.dijitalSayi2.Renk = System.Drawing.Color.Empty;
            this.dijitalSayi2.Sayi = 0;
            this.dijitalSayi2.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi2.TabIndex = 1;
            // 
            // dijitalSayi1
            // 
            this.dijitalSayi1.Location = new System.Drawing.Point(3, 3);
            this.dijitalSayi1.Name = "dijitalSayi1";
            this.dijitalSayi1.Renk = System.Drawing.Color.Empty;
            this.dijitalSayi1.Sayi = 0;
            this.dijitalSayi1.Size = new System.Drawing.Size(214, 177);
            this.dijitalSayi1.TabIndex = 0;
            this.dijitalSayi1.Load += new System.EventHandler(this.dijitalSayi1_Load);
            // 
            // DijitalSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dijitalSayi3);
            this.Controls.Add(this.dijitalSayi2);
            this.Controls.Add(this.dijitalSayi1);
            this.Name = "DijitalSaat";
            this.Size = new System.Drawing.Size(715, 183);
            this.Load += new System.EventHandler(this.DijitalSaat_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private DijitalSayi dijitalSayi1;
        private DijitalSayi dijitalSayi2;
        private DijitalSayi dijitalSayi3;
        private System.Windows.Forms.Timer timer1;
    }
}
