using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace caMenu
{
    class Pilha
    {
        // elementos - atributos
        
        private char[] pilhaChar = new char[20];
        private int topo;

        // operadores - métodos

        // construtor
        public Pilha()
        {
            topo = -1;
        }

        bool estaVazia()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        public void insere(char c) // push
        {
            topo++;
            pilhaChar[topo] = c;
        }

        public char remove() // pop
        {
            char temp = pilhaChar[topo];
            topo--;
            return temp;
            
        }

        public void imprime()
        {
            int temp = topo;
            if (estaVazia())
                Console.WriteLine("A Pilha esta vazia");
            else
            {
                while (temp != -1)
                {
                    Console.WriteLine(pilhaChar[temp]);
                    Console.WriteLine();
                    temp--;
                }
            }
        }

        public (Pilha, Pilha) Varredura(Pilha principal)
        {
            
        }

        public void insereString()
        {
            float aux = 1;
            char input = pilhaChar[topo];

            while (aux != 0)
            {
                input = Convert.ToChar(Console.ReadLine());
                if (input != '\0') {
                    topo++;
                    pilhaChar[topo] = input;
                } else {
                    aux = 0;
                }
            }
        }

    } // fim da classe Pilha
}
