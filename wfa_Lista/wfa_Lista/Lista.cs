using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Lista
{
    internal class Lista
    {
        //atributos
        NoLista Inicio;
        NoLista Fim;

        internal NoLista Inicio1 { get => Inicio; set => Inicio = value; }
        internal NoLista Fim1 { get => Fim; set => Fim = value; }
        
        //metodos
        //*costrutor
        public Lista() 
        {
            Inicio = null; 
            Fim = null;
        }

        //functions

        //insert a number into the queue
        public void Lista_insere_fim(int num_input)
        {
            NoLista novoNo = new NoLista(num_input);

            if(Lista_estaVazia())
            {
                Inicio = novoNo; Fim = novoNo;
            }
            else
            {
                Fim.Prox = novoNo;
                novoNo.Previo = Fim;
                Fim = novoNo;
            }
        }

        public bool Lista_estaVazia()
        {
            if (Inicio == null && Fim == null)
                return true;
            else
                return false;
        }

        public void remove(int n)
        {
            NoLista no_a_ser_removido = achaNo(n);

            if (no_a_ser_removido != null)
            {
                if (no_a_ser_removido == Inicio)
                {
                    Inicio = Inicio.Prox;
                    Inicio.Previo = null;
                }
                else if (no_a_ser_removido == Fim)
                {
                    Fim = Fim.Previo;
                    Fim.Prox = null;
                }
                else // o nó vai ser removido do meio
                {
                    (no_a_ser_removido.Previo).Prox = no_a_ser_removido.Prox;
                    (no_a_ser_removido.Prox).Previo = no_a_ser_removido.Previo;
                }
            } 
            
            else
                Console.WriteLine("Nó não encontrado");
        }

        public NoLista achaNo(int n) 
        {
            NoLista temp = Inicio;
            while(temp != null)
            {
                if (temp.Info == n)
                    return temp;
                else
                    temp = temp.Prox;
            }

            return null;
        }

        public string Lista_print()
        {
            string Lista = "";
            NoLista temp = Inicio;

            if (!Lista_estaVazia()) {
                
                while (temp != null)
                {
                    Lista += " " + Convert.ToString(temp.Info);
                    temp = temp.Prox;
                }
                return Lista;

            } 
            else
            {
                MessageBox.Show("A lista está vazia");
                return null;
            }
        }



    }// fim da classe
}
