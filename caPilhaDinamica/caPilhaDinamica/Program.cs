using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();// criando pilha
            p.push(1);
            p.push(2);
            p.push(3);
            p.push(4);
            p.push(5);
            p.push(6);
            p.push(7);

            p.imprimePilha();
            Console.ReadLine();

            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
            Console.WriteLine("Desempilhando o..." + p.pop());
            Console.ReadLine();
        }
    }
}
