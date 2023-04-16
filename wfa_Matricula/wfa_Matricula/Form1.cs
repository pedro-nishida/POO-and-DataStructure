using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_CadastroMateria
{
    public partial class Form1 : Form
    {
        //criando um array de objetos matéria
        Materia[] lista_materias = new Materia[8];
        int len_lista = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_reccord_Click(object sender, EventArgs e)
        {
            Materia m = new Materia(txb_Nome.Text, txb_Codigo.Text);

            lista_materias[len_lista] = m;
            len_lista++;
            
            //limpando as caixas de texto após criar o objetivo
            txb_Nome.Clear();
            txb_Codigo.Clear();

            MessageBox.Show("Materia Adicionada com Sucesso");
        }

        private void button_relatorio_Click(object sender, EventArgs e)
        {
            string relatorio = "";

            for(int i = 0; i < len_lista; i++)
            {
                relatorio = relatorio + lista_materias[i].Nome + " " + lista_materias[i].Codigo + "\r\n";
            }
            
            txb_relatorio.Text = relatorio;
        }
    }
}
