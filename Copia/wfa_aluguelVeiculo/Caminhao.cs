using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_aluguelVeiculo
{
    internal class Caminhao : Veiculo //classe filha
    {
        //-------------------------------ATRIBUTOS-------------------------------
        // herança + quantidade de eixos
        private int qtdEixos;

        //encapsulamento 
        public int QtdEixos { get => qtdEixos; set => qtdEixos = value; }
        
        //------------------------------CONSTRUTORES-----------------------------
        //construtor default
        public Caminhao() : base() //chama o construtor da classe mãe
        {
            this.qtdEixos = 0;
        }

        //construtor com parâmetros
        public Caminhao(string placa, int anoVeiculo, int qtdEixos) : base(placa, anoVeiculo)
        {
            this.qtdEixos = qtdEixos;
        }

        //------------------------------MÉTODOS---------------------------------
        //calcula valor de aluguel do caminhão
        public override double Aluguel() // override: sobrescreve o método da classe mãe
        {
            //variável que consulta o ano atual do sistema
            int anoAtual = int.Parse(DateTime.Now.Year.ToString());
            double diaria = (300 * qtdEixos) - (anoAtual - AnoVeiculo) * 50;
            return diaria;
        }
    
    }// fim da classe Caminhão


}
