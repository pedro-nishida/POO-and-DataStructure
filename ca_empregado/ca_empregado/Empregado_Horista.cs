using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_empregado
{
    internal class Empregado_Horista : Empregado
    {
        //atributo
        private double preco_hora;
        private int numero_horas;
        private double desconto_inss;

        public double Salario_bruto { get => preco_hora; set => preco_hora = value; }
        public int Numero_horas { get => numero_horas; set => numero_horas = value; }
        public double Preco_hora { get => preco_hora; set => preco_hora = value; }

        //metodos
        public Empregado_Horista() : base() // construtor default - aridade 0
        {
        }

        public Empregado_Horista(string _nome, string _cpf, double _preco_hora, int _numero_horas, double _desconto_inss) : base(_nome, _cpf)
        {
            preco_hora = _preco_hora;
            numero_horas = _numero_horas;
            desconto_inss = _desconto_inss;
        }

        public double salario_liquido()
        {
            double salario_liquido;
            double salario_bruto = Preco_hora * Numero_horas;

            salario_liquido = salario_bruto * (1 - desconto_inss);
            return (salario_liquido);
        }
    }   //fim da classe Empregado Horista
}
