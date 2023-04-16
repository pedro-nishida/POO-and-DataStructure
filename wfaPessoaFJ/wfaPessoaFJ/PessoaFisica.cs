using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFJ
{
    class PessoaFisica : Pessoa
    {
        private string cpf;

        public PessoaFisica() : base()
        {

        }

        public PessoaFisica(string _nome, string _cidade,
            string _cpf) : base(_nome, _cidade)
        {
            cpf = _cpf;
        }

        public string Cpf { get => cpf; set => cpf = value; }
    }
}
