using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_aluguelVeiculo
{
    internal class Onibus : Veiculo //classe filha
    {
        //----------------------------------ATRIBUTOS---------------------------------------
        //herança + quantidade de assentos
        private int qtdAssentos;

        //encapsulamento
        public int QtdAssentos { get => qtdAssentos; set => qtdAssentos = value; }

        //----------------------------------CONSTRUTORES------------------------------------

        //construtor default
        public Onibus() : base() //chama o construtor da classe mãe
        {
            this.qtdAssentos = 0;
        }

        //construtor com parâmetros
        public Onibus(string placa, int anoVeiculo, int qtdAssentos) : base(placa, anoVeiculo)
        {
            this.qtdAssentos = qtdAssentos;
        }

        //----------------------------------MÉTODOS----------------------------------------

        //calcula valor de aluguel do onibus
        public override double Aluguel() // override: sobrescreve o método da classe mãe
        {

            //variável que consulta o ano atual do sistema
            int anoAtual = int.Parse(DateTime.Now.Year.ToString());
            Console.WriteLine(anoAtual);
            double diaria = (30 * qtdAssentos) - (anoAtual - AnoVeiculo) * 70;
            return diaria;
        }
    }
}
