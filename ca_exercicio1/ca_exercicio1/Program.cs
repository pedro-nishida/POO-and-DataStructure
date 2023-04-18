using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_exercicio1
{
    internal class Program
    {
        static bool VerificadorSintaxe(string expression)
        {
            DynamicStack stack = new DynamicStack();

            foreach (char ch in expression)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }

                    char chaveAberta = stack.Pop();
                    if ((ch == ')' && chaveAberta != '(') ||
                        (ch == ']' && chaveAberta != '[') ||
                        (ch == '}' && chaveAberta != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty();
        }


        static void Main(string[] args)
        {
            string expression1 = "{ 5* [ a + b ] - d * (c - a) + log10 }";
            string expression2 = "{ 5* [ a + b ] - d * (c - a] + log10 }";

            Console.WriteLine("Verificando Sintaxe da expreção 1: "+ expression1);
            Console.WriteLine(VerificadorSintaxe(expression1) ? "Sintaxe está correta." : "Sintexe está incorreta.");
            Console.ReadLine();

            Console.WriteLine("\nVerifying syntax for expression 2:");
            Console.WriteLine(VerificadorSintaxe(expression2) ? "Sintaxe está correta." : "Sintexe está incorreta.");
            Console.ReadLine();
        }
    }
}
