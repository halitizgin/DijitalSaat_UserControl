namespace DijitalSaat_UserControl
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gorselDijitalTarih1 = new DijitalSaat_UserControl.GorselDijitalTarih();
            this.gorselDijitalYil1 = new DijitalSaat_UserControl.GorselDijitalYil();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_2);
            // 
            // gorselDijitalTarih1
            // 
            this.gorselDijitalTarih1.Aktiflik = true;
            this.gorselDijitalTarih1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gorselDijitalTarih1.BackgroundImage")));
            this.gorselDijitalTarih1.Location = new System.Drawing.Point(1, 28);
            this.gorselDijitalTarih1.Name = "gorselDijitalTarih1";
            this.gorselDijitalTarih1.Size = new System.Drawing.Size(371, 139);
            this.gorselDijitalTarih1.TabIndex = 0;
            this.gorselDijitalTarih1.Tarih = new System.DateTime(2015, 1, 26, 16, 24, 6, 0);
            this.gorselDijitalTarih1.Tema = DijitalSaat_UserControl.GorselDijitalTarih.Temalar.Kırmızı;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 168);
            this.Controls.Add(this.gorselDijitalTarih1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GorselDijitalYil gorselDijitalYil1;
        private System.Windows.Forms.Timer timer1;
        private GorselDijitalTarih gorselDijitalTarih1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

