using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_AlunoMatéria
{
    internal class Materia
    {
        // atributos
        private string nome;
        private string codigo;

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //metodos
        public Materia() //construtor default - aridade 1
        {
            nome = string.Empty;
            codigo = string.Empty;
        }

        public Materia(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

    }//fim da clase materia
}
