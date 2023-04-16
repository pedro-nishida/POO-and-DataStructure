using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_geometria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_area_MouseClick(object sender, MouseEventArgs e)
        {
            if (rButton_quadrado.Checked == true)
            {
                Formas objformas = new Quadrado("Quadrado", Convert.ToDouble(tb_ladoQuadrado.Text));
                
            } else if (rButton_Retangulo.Checked == true)
            {
                Formas objformas = new Retangulo("Retangulo", Convert.ToDouble(tb_baseTriangulo));

                Mensagem
            }
        }

        //Metodos de Inserção de ListView
        private void InserirAreaQuadradoListView(Formas objformas)
        {
            string[] formasGeos = new string[6];

            formasGeos[0] = objformas.Nome;
            formasGeos[1] 
        }

        private void rButton_quadrado_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_forma.Image = Properties.
        }

        private void rButton_Retangulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rButton_triangulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rButton_circulo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
