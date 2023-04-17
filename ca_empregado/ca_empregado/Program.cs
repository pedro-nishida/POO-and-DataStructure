using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado[] arrayEmpregados = new Empregado[4];

            EmpregadoCLT e1 = new EmpregadoCLT("João",
                "489.234.543-90", 7300.00, 25.5);

            Empregado_Horista e2 = new Empregado_Horista("Rosa",
                "456.987.234-67", 120.00, 120, 15);

            Empregado_Horista e3 = new Empregado_Horista("Carlos",
                "456.956.234-67", 120.00, 80, 15);

            EmpregadoCLT e4 = new EmpregadoCLT("Amanda",
                "475.234.543-90", 8500.00, 25.5);


            arrayEmpregados[0] = e1;
            arrayEmpregados[1] = e2;
            arrayEmpregados[2] = e3;
            arrayEmpregados[3] = e4;

            // gerando a folha de pagamento:

            Console.WriteLine("*** FOLHA DE PAGAMENTO ***");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nome = " + arrayEmpregados[i].Nome + " "
                    + "Salario = " + arrayEmpregados[i].sal_liquido());
            }

            Console.ReadLine();



        }
    }
}
