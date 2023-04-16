using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            // CRIE UMA PILHA
            Pilha p1 = new Pilha();
            //

            float aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Inserir elemento na pilha");
                Console.WriteLine(" [2] - Remover elemento da pilha");
                Console.WriteLine(" [3] - Imprimir todos elementos da pilha");
                Console.WriteLine(" [4] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite o elemento a ser inserido:\n");
                        char elemento = Convert.ToChar(Console.ReadLine());
                        // INSIRA O ELEMENTO NA PILHA
                        p1.insere(elemento);
                        //
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Um elemento foi removido");
                        Console.WriteLine("Removeu o ");
                        // REMOVA O ELEMENTO DA PILHA
                        p1.remove();
                        //
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("A pilha encontra-se na seguinte disposição :\n");
                        // IMPRIMA A PILHA
                        p1.imprime();
                        //
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        aux = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;
                }


            }

        }
    }
}
