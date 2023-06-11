using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaAgain.cs
{
    internal class NoPilha
    {
        //atributos
        private int valor;
        private NoPilha anterior;

        //propriedades
        public int Valor { get => valor; set => valor = value; }
        public NoPilha Anterior { get => anterior; set => anterior = value; }

        //construtores
        public NoPilha()
        {
            this.valor = 0;
            this.anterior = null;
        }

        public NoPilha(int valor)
        {
            this.valor = valor;
            this.anterior = null;
        }

        public NoPilha(int valor, NoPilha anterior)
        {
            this.valor = valor;
            this.anterior = anterior;
        }

    }
}
