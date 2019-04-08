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
    public partial class DijitalSaat : UserControl
    {
        public DijitalSaat()
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
                dijitalSayi3.Renk = this.renk;
            }
        }

        private DateTime saat;

        public DateTime Saat
        {
            get { return saat; }
            set 
            {
                saat = value;
                dijitalSayi1.Sayi = this.saat.Hour;
                dijitalSayi2.Sayi = this.saat.Minute;
                dijitalSayi3.Sayi = this.saat.Second;
            }
        }
        

        private void DijitalSaat_Load(object sender, EventArgs e)
        {
            this.renk = Color.Red;
            this.saat = DateTime.Now;
            dijitalSayi1.Renk = Color.Red;
            dijitalSayi2.Renk = Color.Red;
            dijitalSayi3.Renk = Color.Red;
            dijitalSayi1.Sayi = DateTime.Now.Hour;
            dijitalSayi2.Sayi = DateTime.Now.Minute;
            dijitalSayi3.Sayi = DateTime.Now.Second;
        }

        private void DijitalSaat_Load_1(object sender, EventArgs e)
        {

        }

        private void dijitalSayi1_Load(object sender, EventArgs e)
        {

        }
    }
}