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
    public partial class GorselDijitalRakam : UserControl
    {
        public GorselDijitalRakam()
        {
            InitializeComponent();
            Rakam1.BackColor = Color.Transparent;
            this.Tema = Temalar.Kırmızı;
            this.Rakam = 0;
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
                    this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "RakamArkaplan");
                    Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + rakam);
                }
                else
                {
                    Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
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
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "RakamArkaplan");
                        Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + rakam);
                    }
                    else
                    {
                        Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    }
                }
            }
        }

        private int rakam;

        public int Rakam
        {
            get { return rakam; }
            set 
            {
                if (value >= 0 && value <= 9)
                {
                    if (this.Aktiflik == false)
                    {
                        rakam = value;
                        this.BackgroundImage = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "RakamArkaplan");
                        Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema.ToString() + rakam);
                    }
                    else
                    {
                        Rakam1.Image = (Bitmap)DijitalSaat_UserControl.Properties.Resources.ResourceManager.GetObject(this.tema + "BoşNumara");
                    }
                }
            }
        }
        private void GorselDijitalRakam_Load(object sender, EventArgs e)
        {

        }
    }
}
