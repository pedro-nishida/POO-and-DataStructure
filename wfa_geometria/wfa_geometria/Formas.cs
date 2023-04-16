using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*    
 *    ##############
 *    # CLASSE MÃE #
 *    ##############
 */

namespace wfa_geometria
{
    public abstract class Formas
    {
        // Atributos
        private string nome;

        protected string Nome { get => nome; set => nome = value; }

        // Construtor
        public Formas() // construtor default
        {
        }

        public Formas(string nome)
        {
            this.nome = nome;
        }

        public virtual double area()
        {
            return 0;
        }

    } //fim da classe Forma
}
