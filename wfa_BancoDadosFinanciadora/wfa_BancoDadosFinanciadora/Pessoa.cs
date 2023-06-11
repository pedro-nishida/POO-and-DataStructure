using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaBancoDeDadosFinanciadora
{
    internal class Pessoa
    {
        private string cpf;
        private string nome;
        private double salario;

        public Pessoa()
        {
            cpf = string.Empty;
            nome = string.Empty;
            salario = 0.0;
        }

        //contrutor parametrizada
        public Pessoa(string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }

        public double calculaCred()
        {
            return 6 * salario;
        }
    }
}