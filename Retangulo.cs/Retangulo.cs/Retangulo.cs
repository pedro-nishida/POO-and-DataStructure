using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo215
{
    class Retangulo
    {
        //  atributos 
        private int comprimento;
        private int altura;


        // métodos
        public void imprime()
        {
            Console.WriteLine("Comprimento: " + comprimento);
            Console.WriteLine("Altura: " + altura);
        }

        public void mudaComprimento(int novoComp)
        {
            comprimento = novoComp;
        }

        public void mudaAltura(int novaAlt)
        {
            altura = novaAlt;
        }


    } // fim da classe Retangulo
}
