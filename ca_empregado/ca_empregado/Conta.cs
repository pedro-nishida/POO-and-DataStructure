using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaContas
{
    class Conta
    {
        // atributos
        protected int     numeroConta;
        protected double  saldo;

        // métodos
        public Conta()
        {
            saldo = 100.00;  
        }

        public Conta(int  _conta, double _saldo)
        {
            numeroConta = _conta;
            saldo = _saldo;
        }

        // getters & setters
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void deposito(double valor)
        {
            saldo = saldo + valor; // saldo += valor;
        }

        public virtual void saque(double valor)
        {
            double temp = saldo - valor;
            if (temp >= 0.0)
                saldo = saldo - valor; // saldo -= valor;
            else // temp < 0 --> o saldo vai ficar negativo
                Console.WriteLine("Não há saldo para o saque!");
        }

        public void verSaldo()
        {
            Console.WriteLine("Saldo = " + saldo);
        }

    } // fim da classe Conta
}
