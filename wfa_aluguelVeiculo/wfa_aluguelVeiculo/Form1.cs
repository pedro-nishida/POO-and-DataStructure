using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfa_aluguelVeiculo
{
    public partial class Form1 : Form
    {
        //inicalizar lista de veículos
        List<Veiculo> listaVeiculos = new List<Veiculo>();

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Placa", 70);
            listView1.Columns.Add("Ano", 70);
            listView1.Columns.Add("Assentos", 70);
            listView1.Columns.Add("Eixos", 70);
            listView1.Columns.Add("Diária", 70);
        }

        private void rb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            //troca a imagem a partir do caminho relativo de "C:\Users\phfuj\source\repos\wfa_aluguelVeiculo\wfa_aluguelVeiculo\Caminhao.bmp"
            pb_Veiculo.Image = Properties.Resources.Onibus;


            label_QtdAssentos.Text = "Qnt de Assentos";
        }

        private void rb_Caminhao_CheckedChanged(object sender, EventArgs e)
        {
            //troca a imagem a partir do caminho relativo de "C:\Users\phfuj\source\repos\wfa_aluguelVeiculo\wfa_aluguelVeiculo\Caminhao.png"
            pb_Veiculo.Image = Properties.Resources.Caminhao;
            label_QtdAssentos.Text = "Eixos";
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            //verifica se txb_Placa, txb_AnoVeiculo, txb_QntAssento estão preenchidos então faz mensagem de alerta para prencher o item
            //se botão rb_Onibus estiver selecionado
            if (txb_AnoVeiculo == null || txb_Placa == null || txb_QntAssento == null)
            {
                MessageBox.Show("Você deve prencher todos os campos!");
            }
            else if (rb_Onibus.Checked)
            {
                //cria objeto Onibus
                Onibus onibus = new Onibus(txb_Placa.Text, Convert.ToInt32(txb_AnoVeiculo.Text), Convert.ToInt32(txb_QntAssento.Text));

                //adiciona objeto na lista
                listaVeiculos.Add(onibus);

            }
            //se botao rb_Caminhao estiver selecionado
            else if (rb_Caminhao.Checked)
            {
                //cria objeto Caminhao
                Caminhao caminhao = new Caminhao(txb_Placa.Text, Convert.ToInt32(txb_AnoVeiculo.Text), Convert.ToInt32(txb_QntAssento.Text));
                //adiciona objeto na lista
                listaVeiculos.Add(caminhao);
            }

            //atualizar o listView com os dados do caminhãos separando cada coluna os atributos (Placa, Ano, Assento, Eixos, Diária)
            foreach (Veiculo veiculo in listaVeiculos)
            {
                //cria um array de string com 5 posições
                string[] linha = new string[5];
                //atribui os valores do objeto veiculo nas posições do array
                linha[0] = veiculo.placa;
                linha[1] = veiculo.anoVeiculo.ToString();
                if (veiculo is Onibus)
                {
                    linha[2] = ((Onibus)veiculo).QtdAssentos.ToString();
                    linha[3] = "0";
                    linha[4] = ((Onibus)veiculo).Aluguel().ToString();
                }
                else if (veiculo is Caminhao)
                {
                    linha[2] = "0";
                    linha[3] = ((Caminhao)veiculo).QtdEixos.ToString();
                    linha[4] = ((Caminhao)veiculo).Aluguel().ToString();
                }

                linha[4] = veiculo.Aluguel().ToString();
                //adiciona o array na listview
                listView1.Items.Add(new ListViewItem(linha));

                //display cada arrray da linha respectivamente em cH_placa, cH_ano, ch_assento, ch_eixo, ch_diaria

            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            //limprara todos os dados da listview e da lista de veículos
            txb_AnoVeiculo.Clear();
            txb_Placa.Clear();
            txb_QntAssento.Clear();

        }
    }
}
