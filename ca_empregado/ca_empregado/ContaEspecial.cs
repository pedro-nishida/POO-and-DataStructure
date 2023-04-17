using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaContas
{
    class ContaEspecial : Conta
    {
        // atributos
        private double limite;

        // métodos
        public ContaEspecial() : base()
        {

        }

        public ContaEspecial(int _numeroConta,
            double _saldo, double _limite) : base(_numeroConta, _saldo)
        {
            limite = _limite;
        }

        public double Limite { get => limite; set => limite = value; }

        public override void saque(double valor)
        {
            double temp = (saldo + limite) - valor;
            if (temp >= 0.0)
                saldo = saldo - valor; // saldo -= valor;
            else // temp < 0 --> o saldo vai ficar negativo
                Console.WriteLine("Não há saldo para o saque!");
        }


    } // fim da classe ContaEspecial
}
