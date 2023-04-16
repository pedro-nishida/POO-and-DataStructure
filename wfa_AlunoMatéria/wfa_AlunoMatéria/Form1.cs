using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_AlunoMatéria
{
    public partial class Form1 : Form
    {
        Materia[] lista_materias = new Materia[8];
        int len_materia = 0;

        Aluno[] lista_aluno = new Aluno[8];
        int len_aluno = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button_RecMATERIA_MouseClick(object sender, MouseEventArgs e)
        {
            Materia m = new Materia(txb_NomeMATERIA.Text, txb_CodigoMATERIA.Text);

            lista_materias[len_materia] = m;

            //limpando as caixas de texto após criar o objetivo
            txb_NomeMATERIA.Clear();
            txb_CodigoMATERIA.Clear();

            MessageBox.Show("Materia Adicionada com Sucesso");
            len_materia++;
        }

        private void button_RecALUNO_MouseClick(object sender, MouseEventArgs e)
        {
            Aluno a = new Aluno(txb_NomeALUNO.Text, txb_NumMatriculaALUNO.Text, Convert.ToInt32(txb_PeriodoALUNO.Text));

            lista_aluno[len_aluno] = a;

            txb_NomeALUNO.Clear();
            txb_NumMatriculaALUNO.Clear();
            txb_PeriodoALUNO.Clear();

            MessageBox.Show("Aluno Adicionado com Sucesso");
            len_aluno++;
        }

        private void button_RecMATRICULA_MouseClick(object sender, MouseEventArgs e)
        {
            //pegar o nome do aluno
            //localizar este aluno a (objetos)
        }
    } // fim do campo form
}
