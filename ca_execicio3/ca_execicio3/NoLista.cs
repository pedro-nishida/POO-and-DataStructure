using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_execicio3
{
    internal class NoLista<TAD>
    { 
        public NoLista(NoLista<TAD> previo, TAD info, NoLista<TAD> next)
        {
            Previo = previo;
            Info = info;
            Next = next;
        }


        public NoLista()
        {

        }

        //getters
        public NoLista<TAD> getPrevio()
        {
            return previo;
        }

        //setters]
        public void setPrevio(NoLista<TAD> previo)
        {
            this.previo = previo;
        }


        //metodos
        private NoLista<TAD> previo;
        private TAD info;
        private NoLista<TAD> next;

        internal NoLista<TAD> Previo { get => previo; set => previo = value; }
        public TAD Info { get => info; set => info = value; }
        internal NoLista<TAD> Next { get => next; set => next = value; }


    }
}
