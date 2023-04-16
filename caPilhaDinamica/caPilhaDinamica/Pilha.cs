using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class Pilha
    {
        // atributo
        private NoPilha topo;

        // métodos
        public Pilha() 
        {
            topo = null;
        }
        public bool estaVazia() 
        {
            return (topo == null);
        }
        
        public void push(int n)
        {
            NoPilha novoNo = new NoPilha(n);
            if (estaVazia())
                topo = novoNo;
            else
            {
                novoNo.Prox = topo; // Encademaento de nós
                topo = novoNo;
            }
        }

        public void imprimePilha()
        {
            if (estaVazia())
                Console.WriteLine("Pilha Vazia");
            else
            {
                NoPilha temp = topo;

                while(temp != null) // temp ==  true
                {
                    Console.WriteLine(temp.Info);
                    temp = temp.Prox;
                }
            }
        }

        public string pop()
        {
            if (estaVazia())
            {
                return "\nERRO: Pilha está vazia";
            }
            else
            {
                int _info = topo.Info;
                topo = topo.Prox;

                return Convert.ToString(_info);
            }
        }
    }   // fim da classe
}
