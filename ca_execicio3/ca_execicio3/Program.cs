using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_execicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<double> lD = new Lista<double>();

            lD.insere(2.5);
            lD.insere(8.9);
            lD.insere(4.3);
            lD.insere(3.8);
            lD.insere();

            //retorna pelo tamnaho da lista, cada item
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
