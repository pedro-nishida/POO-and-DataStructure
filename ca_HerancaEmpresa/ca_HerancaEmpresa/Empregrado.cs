using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_HerancaEmpresa
{
    internal class Empregrado
    {
        // atributos
        private string nome;  // protected, atributo pode ser acessado diretamente por classes derivadas (filhas, subclasses)
        private string secao;
        private double salario;

        protected string Nome { get => nome; set => nome = value; }
        protected string Secao { get => secao; set => secao = value; }
        protected double Salario { get => salario; set => salario = value; }
        


        // metodos
        public Empregrado() // construtor default - aridade 0
        {
            nome = string.Empty;
            secao = string.Empty;
            salario = double.NaN;
        }

        public Empregrado(string nome, string secao, double salario)
        {
            this.nome = nome;
            this.secao = secao;
            this.salario = salario;
        }

        public virtual void aumentaSalario(double porcentual)
        {
            salario *= 1 + porcentual / 100;
        }


    } //fim da classe empregado
}
