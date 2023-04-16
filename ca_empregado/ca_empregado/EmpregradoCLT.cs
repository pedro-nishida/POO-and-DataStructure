using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    internal class EmpregradoCLT : Empregado
    {
        //atributos
        private double salario_bruto;
        private double desconto_inss;

        public double Salario_bruto { get => salario_bruto; set => salario_bruto = value; }
        public double Desconto_inss { get => desconto_inss; set => desconto_inss = value; }
        
        
        // metodos
        public EmpregradoCLT() : base() 
        {
        }

        public EmpregradoCLT(string _nome, string _cpf, double _salario_bruto, double _desconto_inss) : base(_nome, _cpf) 
        {
            salario_bruto = _salario_bruto;
            desconto_inss = _desconto_inss;
        }

        public override double salario_liquido()
        {
            double salario_liquido;

            salario_liquido = salario_bruto * (1 - desconto_inss / 100);
            return salario_liquido;
        }
        
    }
}
