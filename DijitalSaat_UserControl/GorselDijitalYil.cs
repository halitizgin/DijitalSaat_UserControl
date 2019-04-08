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
    public partial class GorselDijitalYil : UserControl
    {
        public GorselDijitalYil()
        {
            InitializeComponent();
            this.Tema = Temalar.Kırmızı;
            this.Yil = 2015;
            Sene1.BackColor = Color.Transparent;
            Sene2.BackColor = Color.Transparent;
            Sene3.BackColor = Color.Transparent;
            Sene4.BackColor = Color.Transparent;
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
                    int sene = yil;
                    int sene_1 = sene / 1000;
                    int sene_2 = sene % 1000;
                    int sene1 = sene_1 % 10;
                    int sene2 = sene_1 / 10;
                    int sene3 = sene_2 / 10;
                    int sene4 = sene_2 % 10;

                    Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene1);
                    Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene2);
                    Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene3);
                    Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene4);
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "YılArkaplan");
                }
                else
                {
                    Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
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
                        int sene = yil;
                        int sene_1 = sene / 1000;
                        int sene_2 = sene % 1000;
                        int sene1 = sene_1 % 10;
                        int sene2 = sene_1 / 10;
                        int sene3 = sene_2 / 10;
                        int sene4 = sene_2 % 10;

                        Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene1);
                        Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene2);
                        Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene3);
                        Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene4);
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "YılArkaplan");
                    }
                    else
                    {
                        Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                        Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    }
                }
            }
        }

        private int yil;

        public int Yil
        {
            get { return yil; }
            set 
            {
                if (this.Aktiflik == true)
                {
                    yil = value;
                    int sene = yil;
                    int sene_1 = sene / 1000;
                    int sene_2 = sene % 1000;
                    int sene1 = sene_1 % 10;
                    int sene2 = sene_1 / 10;
                    int sene3 = sene_2 / 10;
                    int sene4 = sene_2 % 10;

                    Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene1);
                    Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene2);
                    Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene3);
                    Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema.ToString() + sene4);
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "YılArkaplan");
                }
                else
                {
                    Sene1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene2.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene3.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                    Sene4.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.Tema + "BoşNumara");
                }
            }
        }
        

        private void GorselDijitalYil_Load(object sender, EventArgs e)
        {

        }
    }
}
