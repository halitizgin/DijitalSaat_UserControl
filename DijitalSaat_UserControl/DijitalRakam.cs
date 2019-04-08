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
    public partial class DijitalRakam : UserControl
    {
        public DijitalRakam()
        {
            InitializeComponent();
            this.Renk = Color.Red;
            Yak(a, b, c, d, e, f);
        }

        private Color renk;

        public Color Renk
        {
            get { return renk; }
            set 
            { 
                renk = value;
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
                    rakam = value;
                    switch (rakam)
                    {
                        case 0:
                            Yak(a, b, c, d, e, f);
                            break;
                        case 1:
                            Yak(e, f);
                            break;
                        case 2:
                            Yak(a, f, h, c, d);
                            break;
                        case 3:
                            Yak(a, f, h, e, d);
                            break;
                        case 4:
                            Yak(b, h, f, e);
                            break;
                        case 5:
                            Yak(a, b, h, e, d);
                            break;
                        case 6:
                            Yak(a, b, c, d, e, h);
                            break;
                        case 7:
                            Yak(a, f, e);
                            break;
                        case 8:
                            Yak(a, b, c, d, e, f, h);
                            break;
                        case 9:
                            Yak(a, b, d, e, f, h);
                            break;
                    }
                }
            }
        }

        private void Yak(params Panel[] yakilacaklar)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = SystemColors.Control;
            }
            foreach (Panel panel in yakilacaklar)
            {
                panel.BackColor = this.renk;
            }
        }

        private void DijitalRakam_Load(object sender, EventArgs e)
        {

        }
    }
}
