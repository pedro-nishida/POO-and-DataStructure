using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    internal class EmpregadoCLT : Empregado
    {
        //atributos
        private double salario_bruto;
        private double desconto_inss;

        public double Salario_bruto { get => salario_bruto; set => salario_bruto = value; }
        public double Desconto_inss { get => desconto_inss; set => desconto_inss = value; }
        
        
        // metodos
        public EmpregadoCLT() : base() 
        {

        }

        public EmpregadoCLT(string _nome, string _cpf, double _salario_bruto, double _desconto_inss) : base(_nome, _cpf) 
        {
            salario_bruto = _salario_bruto;
            desconto_inss = _desconto_inss;
        }

        public void print() 
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Salario Bruto: {0}", salario_bruto);
            Console.WriteLine("Desconto INSS: {0}", desconto_inss);
            Console.WriteLine("Salario Liquido: {0}", salario_liquido());
        }

        public double salario_liquido()
        {
            double salario_liquido;

            salario_liquido = salario_bruto * (1 - desconto_inss / 100);
            return salario_liquido;
        }
        
    }
}
