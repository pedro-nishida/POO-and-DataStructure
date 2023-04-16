using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooResistor.cs
{
    internal class Resistor
    {
        // atributos:
        private double resistencia;
        private double potencia_max;

        public double Resistencia { get => resistencia; set => resistencia = value; }
        public double Potencia_max { get => potencia_max; set => potencia_max = value; }

        public Resistor() //default
        {
            resistencia = 0.0;
            potencia_max = 0.0;
        }

        public Resistor(double inputResistencia, double inputPotencia_max) //passagem de valor
        {
            resistencia = inputResistencia;
            potencia_max = inputPotencia_max;
        }

        public void imprime()
        {
            Console.WriteLine("Resistencia: " + resistencia);
            Console.WriteLine("Potencia Maxima: " + potencia_max);
        }

        public Resistor resistorSerie(Resistor resistorAdjacente)
        {
            Resistor resistorEquivalente = new Resistor();
            resistorEquivalente.resistencia = resistencia + resistorAdjacente.resistencia;

            if (potencia_max <= resistorAdjacente.potencia_max)
                resistorEquivalente.potencia_max = potencia_max;
            else
                resistorEquivalente.potencia_max = resistorAdjacente.potencia_max;

            return (resistorEquivalente);
        }

        public Resistor resistorParalelo(Resistor resistorParalelo)
        {
            Resistor resistorEquivalente = new Resistor();
            resistorEquivalente.resistencia = (resistencia * resistorParalelo.resistencia) / (resistencia + resistorParalelo.resistencia);

            if (potencia_max <= resistorParalelo.potencia_max)
                resistorEquivalente.potencia_max = potencia_max;
            else
                resistorEquivalente.potencia_max = resistorParalelo.potencia_max;


            return (resistorEquivalente);
        }
    } // Fim da Classe Resistor
}
