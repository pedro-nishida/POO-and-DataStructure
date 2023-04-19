using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_execicio3
{
    //define a classe mãe
    internal class Lista<TAD>
    {

        // ATENÇÃO A ORDEM NÃO USUAL DOS PARAMETROS É DEVIDO ERROS DE AMBIGUIDADE
        //metodos

        //função bool verifica se esta vazia
        public bool estaVazia()
        {
            return inicio == null;
        }

        //função insere no inicio

        public void insere()
        {

        }
        
        public void insere(TAD info)
        {
            NoLista<TAD> novo = new NoLista<TAD>(null, info, inicio);
            if (estaVazia())
            {
                fim = novo;
            }
            else
            {
                inicio.setPrevio(novo);
            }
            inicio = novo;
        }

        //função remove do inicio
        public void remove()
        {
            if (estaVazia())
            {
                throw new Exception("Lista vazia");
            }
            inicio = inicio.Next;
            if (inicio == null)
            {
                fim = null;
            }
            else
            {
                inicio.setPrevio(null);
            }
        }
        
        //função retorna o valor em dada posição


        //setters
        public void setInicio(NoLista<TAD> inicio)
        {
            this.inicio = inicio;
        }

        //construtor
        public Lista()
        {
            inicio = null;
            fim = null;
        }
        //atributos
        private NoLista<TAD> inicio;
        private NoLista<TAD> fim;

        internal NoLista<TAD> Inicio { get => inicio; set => inicio = value; }
        internal NoLista<TAD> Fim { get => fim; set => fim = value; }
    }
}
