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
    public partial class DijitalTarih : UserControl
    {
        public DijitalTarih()
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
                dijitalSaat1.Renk = this.renk;
                dijitalSayi1.Renk = this.renk;
                dijitalSayi2.Renk = this.renk;
            }
        }
        

        private DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }
            set 
            { 
                tarih = value;
                dijitalSaat1.Saat = DateTime.Now;
                dijitalSayi1.Sayi = DateTime.Now.Day;
                dijitalSayi2.Sayi = DateTime.Now.Month;
                dijitalYil1.Yil = DateTime.Now.Year;
            }
        }
        

        private void DijitalTarih_Load(object sender, EventArgs e)
        {
            dijitalSaat1.Saat = DateTime.Now;
            dijitalSayi1.Sayi = DateTime.Now.Day;
            dijitalSayi2.Sayi = DateTime.Now.Month;
            dijitalYil1.Yil = DateTime.Now.Year;
            this.Tarih = DateTime.Now;
            this.renk = Color.Red;
        }
    }
}
