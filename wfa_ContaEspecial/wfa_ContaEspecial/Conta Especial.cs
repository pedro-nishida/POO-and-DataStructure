using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_ContaEspecial
{
    internal class Conta_Especial : Conta
    {
        // atributos
        //* atributos <int>num_conta e <souble>saldo
        private double limite;

        // métodos
        public Conta_Especial() : base() 
        {
            
        }

        public Conta_Especial(int _numero_conta, double _saldo, double _limite) : base()
        {
            Numero_conta = _numero_conta;
            Saldo = _saldo;
            limite = _limite;
        }

        public virtual void Saque(double valor)
        {
            double extra_saldo;
            if (Saldo >= valor)
            {
                MessageBox.Show("Saque efeituada com sucesso, no valor de: " + valor);
                Saldo -= valor;
            }  else
            {
                extra_saldo = valor - Saldo;
                if (limite >= extra_saldo)
                {
                    DialogResult reply;
                    MessageBox.Show("Saque superior ao saldo: Deseja usar crédito para o valor restante de" + extra_saldo + "?");
                    reply = MessageBox.Show("Aceita usar Crédito?", "Crédito", MessageBoxButtons.YesNo);
                    if (reply == DialogResult.Yes)
                    {
                        MessageBox.Show("Saque efeituada com sucesso, no valor de: " + valor);
                        Saldo -= valor;
                    } else
                    {
                        MessageBox.Show("Pedido de Saque Cancelado");
                    }
                }
                else
                {
                    MessageBox.Show("Ação Bloqueada: Pedido de Saque é superior ao Saldo disponível");
                }
            }
        }

    } // Fim da Classe Especial
}
