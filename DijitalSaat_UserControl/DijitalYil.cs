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
    public partial class DijitalYil : UserControl
    {
        public DijitalYil()
        {
            InitializeComponent();
        }

        private Color renk;

        public Color Renk
        {
            get { return renk; }
            set 
            { 
                renk = value;
                dijitalSayi1.Renk = this.renk;
                dijitalSayi2.Renk = this.renk;
            }
        }
        

        private int yil;

        public int Yil
        {
            get { return yil; }
            set 
            { 
                yil = value;
                int yil1 = yil / 100;
                int yil2 = yil % 100;
                dijitalSayi1.Sayi = yil1;
                dijitalSayi2.Sayi = yil2;
            }
        }
        

        private void DijitalYil_Load(object sender, EventArgs e)
        {
            this.Yil = 2014;
            this.Renk = Color.Red;
        }
    }
}
