using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class NoPilha
    {
        //atributo
        private int info;
        private NoPilha prox;

        //metodo
        public NoPilha()
        {
            prox = null;
        }

        public NoPilha(int _info)
        {
            info = _info;
            prox = null;
        }
        
        public NoPilha(int _info, NoPilha _proxy)
        {
            info = _info;
            prox = _proxy;
        }

        // getter & setters
        public int Info { get => info; set => info = value; }
        internal NoPilha Prox { get => prox; set => prox = value; }
        
    }
}
