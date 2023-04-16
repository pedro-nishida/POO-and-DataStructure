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
            pictureBox1.Image = Properties.Resources.branco;
        }

        private void radioButton_retangulo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.retangulo;
        }

        private void radioButton_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.circulo;
        }

        private void radioButton_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image= Properties.Resources.triangulo;
        }

        private void radioButton_Quadrado_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.quadrado;
        }
    }
}
