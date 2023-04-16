using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPessoaFJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gerarGradeListViewPf();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelCPF_CNPJ.Text = "CNPJ";
            maskedTextBoxCPF_CNPJ.Mask = "00,000,000/0000-00";
        }

        private void radioButtonPFISICA_CheckedChanged(object sender, EventArgs e)
        {
            labelCPF_CNPJ.Text = "CPF";
            maskedTextBoxCPF_CNPJ.Mask = "000,000,000-00";
        }

        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxCPF_CNPJ.Text = "";
            textBoxNome.Text = "";
            textBoxCidade.Text = "";
        }

        private void buttonCADASTRAR_MouseClick(object sender, MouseEventArgs e)
        {
            if(radioButtonPFISICA.Checked == true)
            {
                MessageBox.Show("Cadastro Pessoa FÍSICA");

                // criar um objeto da classe PessoaFisica
                PessoaFisica pf = new PessoaFisica(textBoxNome.Text,
                    textBoxCidade.Text, maskedTextBoxCPF_CNPJ.Text);

                // Adicionar o objeto pf no array de Pessoas Físicas

                string[] clientePf = new string[3]; // Cria um vetor de Strings com 6 posicoes 
                
                // Insere cada atributo do objeto instanciado em uma posição determinada no vetor
                clientePf[0] = pf.Cpf;
                clientePf[1] = pf.Nome;
                clientePf[2] = pf.Cidade;

                //Insere o vetor criado com os dados do objeto em uma linha do ListView
                listViewCPF.Items.Add(new ListViewItem(clientePf));
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show("Cadastro Pessoa JURÍDICA");
            }

            else
            {
                MessageBox.Show("SEM SELEÇÃO");
            }
        }

        // Geração de Grades do List View
        public void gerarGradeListViewPf()// Gera as grades do List View PF
        {
            listViewCPF.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            listViewCPF.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            listViewCPF.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            listViewCPF.View = View.Details;
        }
    }
}
