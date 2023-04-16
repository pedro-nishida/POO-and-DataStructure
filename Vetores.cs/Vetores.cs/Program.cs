using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetor2D vetorDefault = new Vetor2D();
            Vetor2D vetorParametro = new Vetor2D(10.0, 15.5);
            Vetor2D vetorTeclado = new Vetor2D("Dados pelo teclado: ");


            Console.WriteLine("Abicissa do v2: " + vetorParametro.Coordenada_x);

            Console.WriteLine("Produto Escalar entre v1 e v2: ");
            Console.WriteLine(vetorTeclado.produtoEscalar( vetorParametro ));
            Console.ReadLine();

            Console.WriteLine("Soma Vetorial entre v1 e v2");
            Console.WriteLine(vetorTeclado.SomaVetorial( vetorParametro ));
            Console.ReadLine();
        }
    }
}
