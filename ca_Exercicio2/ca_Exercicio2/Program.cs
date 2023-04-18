using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ca_Exercicio2
{
    internal class Program
    {
        const int ParkingCapacity = 10;

        static string GenerateRandomLicensePlates(int n)
        {
            Random random = new Random();

            char letter1 = (char)random.Next('A', 'Z' + 1);
            char letter2 = (char)random.Next('A', 'Z' + 1);
            char letter3 = (char)random.Next('A', 'Z' + 1);
            int number = random.Next(1000);
            string placa = $"{letter1}{letter2}{letter3}-{number:D3}";

            return placa;
        }


        static void Main(string[] args)
        {
            DynamicStack parking = new DynamicStack();

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
                        string placa = GenerateRandomLicensePlates(1);
                        Console.Write("O carro que quer entrar é " + placa);
                        // INSIRA O ELEMENTO NA PILHA
                        if (parking.Size() < ParkingCapacity)
                        {
                            parking.Push(new Carro(placa));
                            Console.WriteLine($"Carro {placa} chegou. Temos {ParkingCapacity - parking.Size()} vagas restantes.");
                            Console.Clear();
                            break;
                        } else
                        {
                            Console.WriteLine($"Carro {placa} chegou, mas esta com estacionamento cheio");
                            Console.Clear();
                            break;
                        }
                       

                    case "2":
                        parking.Print();
                        Console.WriteLine("Qual carro vai ser removido: ");
                        string placa_pop = Console.ReadLine();
                        // REMOVA O ELEMENTO DA PILHA
                        parking.Pop(placa_pop);
                        //
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write($"Temos {ParkingCapacity - parking.Size()} vagas restantes. A pilha encontra-se na seguinte disposição :\n");
                        // IMPRIMIR A PILHA
                        parking.Print();
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
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }


            }  
        }

    }
}
