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
    public partial class GorselDijitalSayi : UserControl
    {
        public GorselDijitalSayi()
        {
            InitializeComponent();
            Sayi1.BackColor = Color.Transparent;
            Sayi2.BackColor = Color.Transparent;
            this.Tema = Temalar.Kırmızı;
            this.Sayi = 0;
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
                    int numara1 = this.sayi / 10;
                    int numara2 = this.sayi % 10;

                    Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara1);
                    Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara2);
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
                }
                else
                {
                    Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
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
                        int numara1 = this.sayi / 10;
                        int numara2 = this.sayi % 10;

                        Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara1);
                        Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara2);
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
                    }
                    else
                    {
                        Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
                    }
                }

            }
        }

        private int sayi;

        public int Sayi
        {
            get { return sayi; }
            set 
            {  
                if (value >= 0 && value <= 99)
                {
                    if (this.Aktiflik == true)
                    {
                        sayi = value;
                        int numara1 = sayi / 10;
                        int numara2 = sayi % 10;

                        Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara1);
                        Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + numara2);
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
                    }
                    else
                    {
                        Sayi1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        Sayi2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "SayıArkaplan");
                    }
                }
            }
        }
        

        private void GorselDijitalSayi_Load(object sender, EventArgs e)
        {

        }
    }
}
