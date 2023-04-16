using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado[] arrayEmpregados = new Empregado[4];

            EmpregradoCLT e1 = new EmpregradoCLT("João", "489.234.543-90", 7.300, 25.5);

            Empregado_Horista e2 = new Empregado_Horista("Rosa", "456.987.234-67", 120.00, 120, 15);

            Empregado_Horista e3 = new Empregado_Horista("Carlos", "456.956.234-67", 120.00, 120, 15);

            EmpregradoCLT e4 = new EmpregradoCLT("Amanda", "475.234.543-90", 7.300, 25.5);

            arrayEmpregados[0] = e1;
            arrayEmpregados[1] = e2;
            arrayEmpregados[2] = e3;
            arrayEmpregados[3] = e4;

            //gerando forlha de pagamento 
            Console.WriteLine("**** FOLHA DE PAGAMENTO ****");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nome: " + arrayEmpregados[i].Nome + " ");
            };

            Console.ReadLine();
        }
    }
}
