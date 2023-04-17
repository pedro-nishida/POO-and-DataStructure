using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picBoxFIGURAS.Image = Properties.Resources.branco;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            picBoxFIGURAS.Image = Properties.Resources.circulo;
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            picBoxFIGURAS.Image = Properties.Resources.retangulo;
        }

        private void rbTrapezio_CheckedChanged(object sender, EventArgs e)
        {
            picBoxFIGURAS.Image = Properties.Resources.trapezio;

        }
    }
}
