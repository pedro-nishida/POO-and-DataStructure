using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_geometria
{
    internal class Quadrado : Formas
    {
        // atributos
        private double lado;

        public double Lado { get => lado; set => lado = value; }
    
        // costrutor
        public Quadrado(string _nome, double _lado) : base(_nome)
        {
            lado = _lado;
        }

        // métodos
        public override double area()
        {
            return Math.Pow(lado, 2);
        }
    
    } // fim da classe Quadrado
}
