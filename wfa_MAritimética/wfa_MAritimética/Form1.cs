using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_MAritimética
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txb_a.Text);
            double b = Convert.ToDouble(txb_b.Text);
            double c = Convert.ToDouble(txb_c.Text);

            double delta = ((b * b) - 4 * a * c);
            double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
            double x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

            txb_Delta.Text = Convert.ToString(delta);
            txb_x1.Text = Convert.ToString(x1);
            txb_x2.Text = Convert.ToString(x2);
        }
    }
}
