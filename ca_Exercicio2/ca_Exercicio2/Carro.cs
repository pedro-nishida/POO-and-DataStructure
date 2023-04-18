using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_Exercicio2
{
    public class Carro
    {
        private string placa;

        public string Placa { get => placa; set => placa = value; }

        public Carro(string _placa)
        {
            Placa = _placa;
        }

    }
}
