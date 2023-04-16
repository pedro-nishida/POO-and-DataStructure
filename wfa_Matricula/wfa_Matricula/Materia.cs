using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_CadastroMateria
{
    internal class Materia
    {
        // atributos
        private string nome;
        private string codigo;

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        // metodos
        public Materia() //default - aridade 0
        {
            Nome = "";
            codigo = "";
        }

        public Materia(string _nome, string _codigo) //aridade 2
        {
            Nome = _nome;
            Codigo = _codigo;
        }

    }
}
