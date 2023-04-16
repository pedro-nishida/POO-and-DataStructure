using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_ContaEspecial
{
    internal class Conta
    {
        // atributos
        private int numero_conta;
        private double saldo;
        
        protected int Numero_conta { get =>  numero_conta; set => numero_conta = value; }
        protected double Saldo { get => saldo; set => saldo = value; }

        // método
        public Conta() // contrutor default - aridade 0
        {

        }

        public Conta(int _numero_conta, double _saldo)
        {
            numero_conta = _numero_conta;
            saldo = _saldo;
        }

        public virtual void deposito(double valor)
        {
            saldo += valor;
        }

        public virtual void saque(double valor)
        {
            if (saldo >= valor )
            {
                saldo -= valor;
                MessageBox.Show("Saque efeituada com sucesso, no valor de :" + valor);

            } else {
                MessageBox.Show("Ação Bloqueada: Pedido de Saque é superior ao Saldo disponível");
            }
        }

        public virtual double ver_saldo()
        {
            return saldo;
        }

    }   //fim da classe Conta
}
