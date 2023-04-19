using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_aluguelVeiculo
{
    internal class Veiculo // Herança: tipo mãe
    {
        //atribtuos
        public string placa;
        public int anoVeiculo;

        //encapsulamento dos atributos          // Uso de protected, atributo pode ser acessado diretamente por classes derivadas (filhas, subclasses)
        protected string Placa { get => placa; set => placa = value; }
        protected int AnoVeiculo { get => anoVeiculo; set => anoVeiculo = value; }

        //contrutor defaut - sem parâmetros
        public Veiculo()
        {
            this.placa = "AAA-0000";
            this.anoVeiculo = 0000;
        }

        //construtor
        public Veiculo(string placa, int anoVeiculo)
        {
            this.placa = placa;
            this.anoVeiculo = anoVeiculo;
        }

        //métodos
        //calcula valor de aluguel do veiculo
        public virtual double Aluguel() // virtual: permite que o método seja sobrescrito (override) em classes derivadas
        {
            return 0;
        }

    }   // fim da classe Veículo
}