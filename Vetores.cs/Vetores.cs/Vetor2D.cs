using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vetores.cs
{
    class Vetor2D
    {
        //atributos
        private double coordenada_x;
        private double coordenada_y;

        public double Coordenada_x { get => coordenada_x; set => coordenada_x = value; }
        public double Coordenada_y { get => coordenada_y; set => coordenada_y = value; }

        //métodos
        public Vetor2D() {  // default
            coordenada_x = 0.0;
            coordenada_y = 0.0;
        }

        public Vetor2D(double _x, double _y) //nota: underscore para indicar o programador da inicialização da variável.
        {
            coordenada_x = _x;
            coordenada_y = _y;
        }

        //INPUT do Teclado como parâmetros:
        public Vetor2D(string str) //nota foi usado string para diferenciar o construtor dos anteriores.
        {
            Console.WriteLine("Input do Teclado");

            Console.WriteLine("Entre o valor da abscissa: ");
            coordenada_x = Convert.ToDouble(
                Console.ReadLine()
                );

            Console.WriteLine("Entre o valor da ordenada: ");
            coordenada_y = Convert.ToDouble( 
                Console.ReadLine()
                );
        }

        public double produtoEscalar(Vetor2D vetor)
        {
            return ((coordenada_x * vetor.coordenada_x) + (coordenada_y * vetor.coordenada_y));
        }

        public Vetor2D SomaVetorial(Vetor2D vetor)
        {
            Vetor2D soma = new Vetor2D(coordenada_x + vetor.coordenada_x, coordenada_y + vetor.coordenada_y);
            return soma;
        }
    } // FIM DA CLASSE VETORE 2D
}
