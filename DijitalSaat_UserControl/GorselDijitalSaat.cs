using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DijitalSaat_UserControl
{
    public partial class GorselDijitalSaat : UserControl
    {
        public GorselDijitalSaat()
        {
            InitializeComponent();
            Sure = DateTime.Now;
            Tema = Temalar.Kırmızı;
            Aktiflik = true;
            Saat1.BackColor = Color.Transparent;
            Saat2.BackColor = Color.Transparent;
            Dakika1.BackColor = Color.Transparent;
            Dakika2.BackColor = Color.Transparent;
            Saniye1.BackColor = Color.Transparent;
            Saniye2.BackColor = Color.Transparent;
        }

        private bool aktiflik;

        public bool Aktiflik
        {
            get { return aktiflik; }
            set 
            { 
                aktiflik = value;

                if (aktiflik == true)
                {
                    int saat = this.Sure.Hour;
                    int dakika = this.Sure.Minute;
                    int saniye = this.Sure.Second;

                    int saat1 = saat / 10;
                    int saat2 = saat % 10;
                    int dakika1 = dakika / 10;
                    int dakika2 = dakika % 10;
                    int saniye1 = saniye / 10;
                    int saniye2 = saniye % 10;

                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat1.ToString());
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat2.ToString());
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika1.ToString());
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika2.ToString());
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye1.ToString());
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye2.ToString());
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                }
                else
                {
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                }
            }
        }

        public enum Temalar
        {
            Kırmızı,
            Yeşil,
            LCD,
            Mavi
        }

        private Temalar tema;

        public Temalar Tema
        {
            get { return tema; }
            set 
            {
                if (value == Temalar.Kırmızı || value == Temalar.Yeşil || value == Temalar.Mavi || value == Temalar.LCD)
                {
                    if (this.Aktiflik == true)
                    {
                        tema = value;
                        int saat = this.Sure.Hour;
                        int dakika = this.Sure.Minute;
                        int saniye = this.Sure.Second;

                        int saat1 = saat / 10;
                        int saat2 = saat % 10;
                        int dakika1 = dakika / 10;
                        int dakika2 = dakika % 10;
                        int saniye1 = saniye / 10;
                        int saniye2 = saniye % 10;

                        Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat1.ToString());
                        Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat2.ToString());
                        Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika1.ToString());
                        Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika2.ToString());
                        Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye1.ToString());
                        Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye2.ToString());
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                    }
                    else
                    {
                        Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                    }
                }
            }
        }
        

        private DateTime sure;

        public DateTime Sure
        {
            get { return sure; }
            set 
            {
                if (this.Aktiflik == true)
                {
                    sure = value;
                    int saat = sure.Hour;
                    int dakika = sure.Minute;
                    int saniye = sure.Second;

                    int saat1 = saat / 10;
                    int saat2 = saat % 10;
                    int dakika1 = dakika / 10;
                    int dakika2 = dakika % 10;
                    int saniye1 = saniye / 10;
                    int saniye2 = saniye % 10;

                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat1.ToString());
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saat2.ToString());
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika1.ToString());
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + dakika2.ToString());
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye1.ToString());
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + saniye2.ToString());
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                }
                else
                {
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "Arkaplan");
                }
            }
        }

        private void GorselDijitalSaat_Load(object sender, EventArgs e)
        {
            
        }
    }
}
