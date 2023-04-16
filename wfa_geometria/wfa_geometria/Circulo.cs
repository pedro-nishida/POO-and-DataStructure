using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_geometria
{
    internal class Circulo : Formas
    {
        // atributos
        private double raio;

        public double Raio { get => raio; set => raio = value; }


        // construtor
        public Circulo(string _nome, double _raio) : base(_nome)
        {
            raio = _raio;
        }

        // métodos
        public override double area()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

    }
}
