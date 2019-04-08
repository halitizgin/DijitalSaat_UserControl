using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace DijitalSaat_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void dijitalSayi1_Load(object sender, EventArgs e)
        {

        }

        private void dijitalSaat2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            gorselDijitalTarih1.Tarih = DateTime.Now;
            if (gorselDijitalTarih1.Tema == GorselDijitalTarih.Temalar.Kırmızı)
            {
                gorselDijitalTarih1.Tema = GorselDijitalTarih.Temalar.LCD;
            }
            else if (gorselDijitalTarih1.Tema == GorselDijitalTarih.Temalar.LCD)
            {
                gorselDijitalTarih1.Tema = GorselDijitalTarih.Temalar.Mavi;
            }
            else if (gorselDijitalTarih1.Tema == GorselDijitalTarih.Temalar.Mavi)
            {
                gorselDijitalTarih1.Tema = GorselDijitalTarih.Temalar.Yeşil;
            }
            else if (gorselDijitalTarih1.Tema == GorselDijitalTarih.Temalar.Yeşil)
            {
                gorselDijitalTarih1.Tema = GorselDijitalTarih.Temalar.Kırmızı;
            }
        }

        private void gorselDijitalTarih1_Load(object sender, EventArgs e)
        {
            
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dijital Saat User Control v4.00\n\nhttp://www.kodevreni.com\n\nHazırlayan: Ready", "Dijital Saat User Control Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("http://www.kodevreni.com");
        }
    }
}
