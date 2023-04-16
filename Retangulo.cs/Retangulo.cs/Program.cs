using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // criando o objeto r1 da classe Retangulo
            Retangulo r1 = new Retangulo();

            // criando outro objeto (r2) da classe Retangulo
            Retangulo r2 = new Retangulo();
            Console.ReadLine();
            Console.WriteLine("Dados do r1");
            r1.imprime();
            Console.ReadLine();
            Console.WriteLine("Dados do r2");
            r2.imprime();

            Console.ReadLine();

            r1.mudaComprimento(10);
            r1.mudaAltura(5);
            r1.imprime();

            r2.mudaComprimento(20);
            r2.mudaAltura(15);
            r2.imprime();
            Console.ReadLine();
        }
    }
}
