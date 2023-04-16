using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    internal class Empregado
    {
        //atributos
        protected string nome;
        protected string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        //métodos
        public Empregado() // default - aridade 0 
        {
        }

        public Empregado(string _nome, string _cpf) 
        {
            nome = _nome;
            cpf = _cpf;
        }
        
        public virtual double salario_liquido()
        {
            return 1000.00;
        }

    } // fim da lista
}
