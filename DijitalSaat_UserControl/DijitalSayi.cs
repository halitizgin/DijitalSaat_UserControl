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
    public partial class DijitalSayi : UserControl
    {
        public DijitalSayi()
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
                dijitalRakam1.Renk = this.renk;
                dijitalRakam2.Renk = this.renk;
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
                    sayi = value;
                    dijitalRakam1.Rakam = this.sayi / 10;
                    dijitalRakam2.Rakam = this.sayi % 10;
                    dijitalRakam1.Renk = this.Renk;
                    dijitalRakam2.Renk = this.Renk;
                }
            }
        }
        

        private void DijitalSayi_Load(object sender, EventArgs e)
        {
            this.Renk = Color.Red;
            this.Sayi = 0;
        }

        private void dijitalRakam2_Load(object sender, EventArgs e)
        {

        }

        private void dijitalRakam1_Load(object sender, EventArgs e)
        {

        }
    }
}
