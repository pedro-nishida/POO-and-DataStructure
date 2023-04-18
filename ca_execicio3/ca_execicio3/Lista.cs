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
        public void insereInicio(TAD info)
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
        public TAD removeInicio()
        {
            TAD info = inicio.getInfo();
            inicio = inicio.getNext();
            if (inicio == null)
            {
                fim = null;
            }
            else
            {
                inicio.setPrevio(null);
            }
            return info;
        }

        //getters
        public NoLista<TAD> getInicio()
        {
            return inicio;
        }
        
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
    }
}
