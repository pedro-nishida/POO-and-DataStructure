using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_AlunoMatéria
{
    internal class Aluno
    {
        // atributos
        private string nome;
        private string numMatrícula;
        private int periodo;
        public Materia[] lista_materia; 

        public string Nome { get => nome; set => nome = value; }
        public string NumMatrícula { get => numMatrícula; set => numMatrícula = value; }
        public int Periodo { get => periodo; set => periodo = value; }

        // metodos
        public Aluno() // construtor default - aridade 1;
        {
            nome = string.Empty;
            numMatrícula = string.Empty;
            periodo = 0;
        } 

        public Aluno(string nome, string numMatrícula, int periodo)
        {
            this.nome = nome;
            this.numMatrícula = numMatrícula;
            this.periodo = periodo;
            lista_materia = new Materia[8];
        }

    } // fim da classe Aluno
}
