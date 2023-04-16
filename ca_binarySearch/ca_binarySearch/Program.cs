using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Busca binária
    /*
     Localizar um número em um array de inteiros ordenados
        Se x percence a -> return a[i]=x
        se x não pertence a -> return -1
     */


namespace ca_binarySearch
{
    class BuscaBinariaRecursiva
    {
        static int BuscaBinaria(int[] array, int valor, int inicio, int fim)
        {
            if (inicio > fim)
            {
                return -1;
            }

            int meio = (inicio + fim) / 2;

            if (array[meio] == valor)
            {
                return array[meio];
            }
            else if (valor < array[meio])
            {
                return BuscaBinaria(array, valor, inicio, meio - 1);
            }
            else
            {
                return BuscaBinaria(array, valor, meio + 1, fim);
            }
        }

        static void Main()
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29};
            Console.WriteLine("Escolha um número de 0 a 30");
            int valorBuscado = 0;
            valorBuscado = Convert.ToInt32(Console.ReadLine());

            int resultado = BuscaBinaria(array, valorBuscado, 0, array.Length - 1);

            if (resultado != -1)
            {
                Console.WriteLine("O valor {0} foi encontrado no array.", resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O valor {0} não foi encontrado no array.", valorBuscado);
                Console.ReadLine();
            }
        }
    }

}
