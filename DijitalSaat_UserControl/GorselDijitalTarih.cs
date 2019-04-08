using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalSaat_UserControl
{
    public partial class GorselDijitalTarih : UserControl
    {
        public GorselDijitalTarih()
        {
            InitializeComponent();
            Gun1.BackColor = Color.Transparent;
            Gun2.BackColor = Color.Transparent;
            Ay1.BackColor = Color.Transparent;
            Ay2.BackColor = Color.Transparent;
            Yil1.BackColor = Color.Transparent;
            Yil2.BackColor = Color.Transparent;
            Yil3.BackColor = Color.Transparent;
            Yil4.BackColor = Color.Transparent;
            Saat1.BackColor = Color.Transparent;
            Saat2.BackColor = Color.Transparent;
            Dakika1.BackColor = Color.Transparent;
            Dakika2.BackColor = Color.Transparent;
            Saniye1.BackColor = Color.Transparent;
            Saniye2.BackColor = Color.Transparent;
            this.Tema = Temalar.Kırmızı;
            this.Tarih = DateTime.Now;
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
                    int gun = tarih.Day;
                    int gun1 = gun / 10;
                    int gun2 = gun % 10;
                    int ay = tarih.Month;
                    int ay1 = ay / 10;
                    int ay2 = ay % 10;
                    int yil = tarih.Year;
                    int sene1 = yil / 100;
                    int sene2 = yil % 100;
                    int yil1 = sene1 / 10;
                    int yil2 = sene1 % 10;
                    int yil3 = sene2 / 10;
                    int yil4 = sene2 % 10;
                    int saat = tarih.Hour;
                    int saat1 = saat / 10;
                    int saat2 = saat % 10;
                    int dakika = tarih.Minute;
                    int dakika1 = dakika / 10;
                    int dakika2 = dakika % 10;
                    int saniye = tarih.Second;
                    int saniye1 = saniye / 10;
                    int saniye2 = saniye % 10;

                    Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun1);
                    Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun2);
                    Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay1);
                    Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay2);
                    Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil1);
                    Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil2);
                    Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil3);
                    Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil4);
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat1);
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat2);
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika1);
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika2);
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye1);
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye2);
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "TarihArkaplan");
                }
                else
                {
                    Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "TarihArkaplan");
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
                if (value == Temalar.Kırmızı || value == Temalar.Yeşil || value == Temalar.LCD || value == Temalar.Mavi)
                {
                    if (this.Aktiflik == true)
                    {
                        tema = value;
                        int gun = tarih.Day;
                        int gun1 = gun / 10;
                        int gun2 = gun % 10;
                        int ay = tarih.Month;
                        int ay1 = ay / 10;
                        int ay2 = ay % 10;
                        int yil = tarih.Year;
                        int sene1 = yil / 100;
                        int sene2 = yil % 100;
                        int yil1 = sene1 / 10;
                        int yil2 = sene1 % 10;
                        int yil3 = sene2 / 10;
                        int yil4 = sene2 % 10;
                        int saat = tarih.Hour;
                        int saat1 = saat / 10;
                        int saat2 = saat % 10;
                        int dakika = tarih.Minute;
                        int dakika1 = dakika / 10;
                        int dakika2 = dakika % 10;
                        int saniye = tarih.Second;
                        int saniye1 = saniye / 10;
                        int saniye2 = saniye % 10;

                        Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun1);
                        Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun2);
                        Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay1);
                        Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay2);
                        Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil1);
                        Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil2);
                        Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil3);
                        Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil4);
                        Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat1);
                        Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat2);
                        Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika1);
                        Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika2);
                        Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye1);
                        Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye2);
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "TarihArkaplan");
                    }
                    else
                    {
                        Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    }
                }
            }
        }

        private DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }
            set 
            {
                if (this.Aktiflik == true)
                {
                    tarih = value;
                    int gun = tarih.Day;
                    int gun1 = gun / 10;
                    int gun2 = gun % 10;
                    int ay = tarih.Month;
                    int ay1 = ay / 10;
                    int ay2 = ay % 10;
                    int yil = tarih.Year;
                    int sene1 = yil / 100;
                    int sene2 = yil % 100;
                    int yil1 = sene1 / 10;
                    int yil2 = sene1 % 10;
                    int yil3 = sene2 / 10;
                    int yil4 = sene2 % 10;
                    int saat = tarih.Hour;
                    int saat1 = saat / 10;
                    int saat2 = saat % 10;
                    int dakika = tarih.Minute;
                    int dakika1 = dakika / 10;
                    int dakika2 = dakika % 10;
                    int saniye = tarih.Second;
                    int saniye1 = saniye / 10;
                    int saniye2 = saniye % 10;

                    Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun1);
                    Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + gun2);
                    Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay1);
                    Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + ay2);
                    Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil1);
                    Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil2);
                    Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil3);
                    Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + yil4);
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat1);
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saat2);
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika1);
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + dakika2);
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye1);
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + saniye2);
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "TarihArkaplan");
                }
                else
                {
                    Gun1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Gun2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Ay1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Ay2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Yil4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saat1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saat2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Dakika1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Dakika2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saniye1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Saniye2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "TarihArkaplan");
                }
            }
        }
        

        private void GorselDijitalTarih_Load(object sender, EventArgs e)
        {

        }

        private void Yil2_Click(object sender, EventArgs e)
        {

        }
    }
}
