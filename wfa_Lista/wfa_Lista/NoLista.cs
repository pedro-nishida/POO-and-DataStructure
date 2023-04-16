using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_Lista
{
    internal class NoLista
    {
        //atributos
        private NoLista previo;
        private int info;
        private NoLista prox;


        //construtor
        public NoLista() //default
        {
            this.info = 0;
            this.prox = null;
            this.previo = null;
        }

        public NoLista(int info) //parametrizado
        {
            this.info = info;
            this.prox = null;
            this.previo = null;
        }
        

        //getters and setters
        public int Info { get => info; set => info = value; }
        internal NoLista Previo { get => previo; set => previo = value; }
        internal NoLista Prox { get => prox; set => prox = value; }
    }
}
