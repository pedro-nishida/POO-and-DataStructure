using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_geometria
{
    internal class Triangulo : Formas
    {
        //atributos
        private double x; // base
        private double y; // altura

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        // construtor
        public Triangulo(string _nome, double _x, double _y) : base(_nome)
        { 
            x = _x;
            y = _y;
        }
        
        //  métodos
        public override double area()
        {
            return (x * y)/2 ;
        }


    } //fim da classe Triangulo

}
