
using pooResistor.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistor
{
    class Program
    {
        static void Main(string[] args)
        {
            Resistor r1 = new Resistor(30.0, 5.0);
            
            Resistor r2 = new Resistor(20.0 ,1.0);
            
            Resistor r3;
            r3 = r1.resistorSerie(r2);

            Resistor r4;
            r4 = r1.resistorParalelo(r2);

            r1.imprime();
            Console.ReadLine();
            r2.imprime();
            Console.ReadLine();
            r3.imprime();
            Console.ReadLine();
            r4.imprime();
            Console.ReadLine();

        }
    }
}