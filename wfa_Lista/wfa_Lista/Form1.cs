using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Lista
{
    public partial class Form1 : Form
    {
        Lista n1 = new Lista();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_insertFIM_Click_1(object sender, EventArgs e)
        {
            n1.Lista_insere_fim(Convert.ToInt32(txb_Num.Text));
            txb_Num.Text = "";
        }

        private void button_remove_MouseClick(object sender, MouseEventArgs e)
        {
            txb_Lista.Text = n1.Lista_print();
            MessageBox.Show("Escoklha um número para ser removido");

            int temp = Convert.ToInt32(txb_Num.Text);
        }

        private void button_limpar_MouseClick(object sender, MouseEventArgs e)
        {
            txb_Lista.Text = string.Empty;
            txb_Num.Text = string.Empty;
        }

        private void button_okRemove_MouseClick(object sender, MouseEventArgs e)
        {
            int temp = Convert.ToInt32(txb_Num.Text);

            //achar referencia de temp na lista
            n1.remove(temp);

            MessageBox.Show("Número removido com sucesso");
        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            txb_Lista.Text = n1.Lista_print();
        }
    }
}
