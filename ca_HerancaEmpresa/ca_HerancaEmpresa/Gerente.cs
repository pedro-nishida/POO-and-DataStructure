using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_HerancaEmpresa
{
    internal class Gerente : Empregrado
    {
        // atributos empregado + adicional:
        private String secretaria;

        // metodos
        public Gerente() : base() 
        {
        
        }

        public Gerente(String _nome, String _secao, double _salario, String Secretaria) :base()
        {
            
        }

        public string Secretaria { get => secretaria; set => secretaria = value; }
    }
}
