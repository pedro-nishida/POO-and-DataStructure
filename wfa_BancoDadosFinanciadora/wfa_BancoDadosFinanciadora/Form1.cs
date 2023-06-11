using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaBancoDeDadosFinanciadora;

namespace wfa_BancoDadosFinanciadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //função limpar textbox
        private void limpar_textBox()
        {
            maskedTextBox_Cpf.Text = "";
            textBox_Nome.Text = "";
            textBox_Salario.Text = "";
        }

        private void button_Inserir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(maskedTextBox_Cpf.Text, textBox_Nome.Text, Convert.ToDouble(textBox_Salario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria conexão com o banco

            conn.Open(); //abre a conexao com o banco

            string commandText = String.Format(
                "INSERT INTO cliente(cpf_cliente, nome_cliente, salario_cliente, credito_cliente) " +
                "VALUES('{0}','{1}','{2}','{3}')", objPessoa.Cpf, objPessoa.Nome, objPessoa.Salario, objPessoa.calculaCred());

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpar textbox
            limpar_textBox();

        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox_Cpf.Text;

            Pessoa objPessoa = new Pessoa(maskedTextBox_Cpf.Text, textBox_Nome.Text, Convert.ToDouble(textBox_Salario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            if (textBox_Nome.Text == "")
            {
                string commandText = String.Format("UPDATE cliente SET cpf_Cliente = '" + objPessoa.Cpf + "'', salario_cliente = " + objPessoa.Salario + " , credito_cliente = " + objPessoa.calculaCred()
                    + " Where cpf_Cliente = '" + cpf + "");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

            } else if (textBox_Salario.Text == "")
            {
                string commandText = String.Format("UPDATE cliente SET cpf_Cliente = '" + objPessoa.Cpf + "' , nome_cliente = '"
                    + objPessoa.Nome + " Where cpf_Cliente = '" + cpf + "");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }
            }
            //MessageBox.Show(commandText);

            con.Close();

            MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpar_textBox();
        }

        private void button_Exibir_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM cliente ORDER BY id_cliente";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView1.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox_Cpf.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            textBox_Nome.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            textBox_Salario.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}
