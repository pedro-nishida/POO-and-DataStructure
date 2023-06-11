using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PilhaAgain.cs
{
    internal class Pilha
    {
        private NoPilha topo;
        private int porto;

        public int Porto { get => porto; set => porto = value; }
        internal NoPilha Topo { get => topo; set => topo = value; }
    
        //construtores
        public Pilha()
        {
            this.topo = null;
            this.porto = 0;
        }

        public Pilha(NoPilha topo, int porto)
        {
            this.topo = topo;
            this.porto = porto;
        }

        //metodos
        public bool IsEmpty()
        {
            return this.topo == null;
        }

        public void Push(int valor)
        {
            NoPilha novo = new NoPilha(valor);
            novo.Anterior = this.topo;
            this.topo = novo;
            this.porto++;
        }

        public void Pop()
        {
              if (!IsEmpty())
            {
                this.topo = this.topo.Anterior;
                this.porto--;
            }
        }

        public void print()
        {
            if (!IsEmpty())
            {
                NoPilha aux = this.topo;
                while (aux != null)
                {
                    Console.WriteLine(aux.Valor);
                    aux = aux.Anterior;
                }
            }
        }

        //fim da classe pilha
    }
}
