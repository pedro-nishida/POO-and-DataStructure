using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_ContaEspecial
{
    public partial class Form1 : Form
    {
        Conta[] arrayContas = new Conta[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            label_Limite.Visible = false;
            txb_Limite.Visible = false;
        }

        private void rButton_Conta_CheckedChanged(object sender, EventArgs e)
        {
            label_Limite.Visible = false;
            txb_Limite.Visible = false;
        }

        private void rButton_cEspecial_CheckedChanged(object sender, EventArgs e)
        {
            label_Limite.Visible = true;
            txb_Limite.Visible = true;
        }

        private void button_Gravar_MouseClick(object sender, MouseEventArgs e)
        {
            // Regra de Negócio
            // Se o radio button de 'Conta' estiver selecionado, crie um objeto da classe
            //      Conta e insira em arrayContas
            // Se o radio button 'Conta_Especial' estiver selecionado, crie um objeto da
            //      classe ContaEspecial e insira em arrayContas()

            if (rButton_Conta.Checked == true)
            {
                Conta conta = new Conta(Convert.ToInt32(txb_numConta.Text),
                                    Convert.ToDouble(txb_saldo.Text));

                arrayContas[i] = conta;
                i++;
            }

            if (rButton_cEspecial.Checked == true)
            {
                Conta especial = new Conta_Especial(Convert.ToInt32(txb_numConta.Text),
                                    Convert.ToDouble(txb_saldo.Text),
                                    Convert.ToDouble(txb_Limite.Text));

                arrayContas[i] = especial;
                i++;
            }
        }
    }
}
