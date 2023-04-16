namespace wfa_AlunoMatéria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlALUNO_MATERIA = new System.Windows.Forms.TabControl();
            this.tabPage_MATERIA = new System.Windows.Forms.TabPage();
            this.button_RecMATERIA = new System.Windows.Forms.Button();
            this.txb_CodigoMATERIA = new System.Windows.Forms.TextBox();
            this.txb_NomeMATERIA = new System.Windows.Forms.TextBox();
            this.label_CodigoMATERIA = new System.Windows.Forms.Label();
            this.label_NomeMATERIA = new System.Windows.Forms.Label();
            this.tabPage_ALUNO = new System.Windows.Forms.TabPage();
            this.button_RecALUNO = new System.Windows.Forms.Button();
            this.txb_PeriodoALUNO = new System.Windows.Forms.TextBox();
            this.txb_NumMatriculaALUNO = new System.Windows.Forms.TextBox();
            this.txb_NomeALUNO = new System.Windows.Forms.TextBox();
            this.labeL_PeriodoALUNO = new System.Windows.Forms.Label();
            this.label_NumMatriculaALUNO = new System.Windows.Forms.Label();
            this.label_NomeALUNO = new System.Windows.Forms.Label();
            this.tabPage_MATRICULA = new System.Windows.Forms.TabPage();
            this.gbx_MateriaMATRICULA = new System.Windows.Forms.GroupBox();
            this.gbx_AlunoMATRICULA = new System.Windows.Forms.GroupBox();
            this.buttom_RecMatricula = new System.Windows.Forms.Button();
            this.txb_MateriaMATRICULA = new System.Windows.Forms.TextBox();
            this.txb_AlunoMATRICULA = new System.Windows.Forms.TextBox();
            this.label_MateriaMATRICULA = new System.Windows.Forms.Label();
            this.label_AlunoMATRICULA = new System.Windows.Forms.Label();
            this.tabPage_RELATORIO = new System.Windows.Forms.TabPage();
            this.tabControlALUNO_MATERIA.SuspendLayout();
            this.tabPage_MATERIA.SuspendLayout();
            this.tabPage_ALUNO.SuspendLayout();
            this.tabPage_MATRICULA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlALUNO_MATERIA
            // 
            this.tabControlALUNO_MATERIA.Controls.Add(this.tabPage_MATERIA);
            this.tabControlALUNO_MATERIA.Controls.Add(this.tabPage_ALUNO);
            this.tabControlALUNO_MATERIA.Controls.Add(this.tabPage_MATRICULA);
            this.tabControlALUNO_MATERIA.Controls.Add(this.tabPage_RELATORIO);
            this.tabControlALUNO_MATERIA.Location = new System.Drawing.Point(33, 37);
            this.tabControlALUNO_MATERIA.Name = "tabControlALUNO_MATERIA";
            this.tabControlALUNO_MATERIA.SelectedIndex = 0;
            this.tabControlALUNO_MATERIA.Size = new System.Drawing.Size(692, 371);
            this.tabControlALUNO_MATERIA.TabIndex = 0;
            // 
            // tabPage_MATERIA
            // 
            this.tabPage_MATERIA.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_MATERIA.Controls.Add(this.button_RecMATERIA);
            this.tabPage_MATERIA.Controls.Add(this.txb_CodigoMATERIA);
            this.tabPage_MATERIA.Controls.Add(this.txb_NomeMATERIA);
            this.tabPage_MATERIA.Controls.Add(this.label_CodigoMATERIA);
            this.tabPage_MATERIA.Controls.Add(this.label_NomeMATERIA);
            this.tabPage_MATERIA.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MATERIA.Name = "tabPage_MATERIA";
            this.tabPage_MATERIA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MATERIA.Size = new System.Drawing.Size(684, 345);
            this.tabPage_MATERIA.TabIndex = 0;
            this.tabPage_MATERIA.Text = "MATERIA";
            // 
            // button_RecMATERIA
            // 
            this.button_RecMATERIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_RecMATERIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RecMATERIA.ForeColor = System.Drawing.Color.Black;
            this.button_RecMATERIA.Location = new System.Drawing.Point(457, 41);
            this.button_RecMATERIA.Name = "button_RecMATERIA";
            this.button_RecMATERIA.Size = new System.Drawing.Size(84, 91);
            this.button_RecMATERIA.TabIndex = 8;
            this.button_RecMATERIA.Text = "GRAVAR";
            this.button_RecMATERIA.UseVisualStyleBackColor = false;
            this.button_RecMATERIA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_RecMATRICULA_MouseClick);
            // 
            // txb_CodigoMATERIA
            // 
            this.txb_CodigoMATERIA.Location = new System.Drawing.Point(147, 110);
            this.txb_CodigoMATERIA.Name = "txb_CodigoMATERIA";
            this.txb_CodigoMATERIA.Size = new System.Drawing.Size(250, 20);
            this.txb_CodigoMATERIA.TabIndex = 7;
            // 
            // txb_NomeMATERIA
            // 
            this.txb_NomeMATERIA.Location = new System.Drawing.Point(147, 42);
            this.txb_NomeMATERIA.Name = "txb_NomeMATERIA";
            this.txb_NomeMATERIA.Size = new System.Drawing.Size(250, 20);
            this.txb_NomeMATERIA.TabIndex = 6;
            // 
            // label_CodigoMATERIA
            // 
            this.label_CodigoMATERIA.AutoSize = true;
            this.label_CodigoMATERIA.BackColor = System.Drawing.Color.Transparent;
            this.label_CodigoMATERIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CodigoMATERIA.ForeColor = System.Drawing.Color.White;
            this.label_CodigoMATERIA.Location = new System.Drawing.Point(36, 109);
            this.label_CodigoMATERIA.Name = "label_CodigoMATERIA";
            this.label_CodigoMATERIA.Size = new System.Drawing.Size(64, 18);
            this.label_CodigoMATERIA.TabIndex = 5;
            this.label_CodigoMATERIA.Text = "Código: ";
            // 
            // label_NomeMATERIA
            // 
            this.label_NomeMATERIA.AutoSize = true;
            this.label_NomeMATERIA.BackColor = System.Drawing.Color.Transparent;
            this.label_NomeMATERIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomeMATERIA.ForeColor = System.Drawing.Color.White;
            this.label_NomeMATERIA.Location = new System.Drawing.Point(36, 41);
            this.label_NomeMATERIA.Name = "label_NomeMATERIA";
            this.label_NomeMATERIA.Size = new System.Drawing.Size(57, 18);
            this.label_NomeMATERIA.TabIndex = 4;
            this.label_NomeMATERIA.Text = "Nome: ";
            // 
            // tabPage_ALUNO
            // 
            this.tabPage_ALUNO.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_ALUNO.Controls.Add(this.button_RecALUNO);
            this.tabPage_ALUNO.Controls.Add(this.txb_PeriodoALUNO);
            this.tabPage_ALUNO.Controls.Add(this.txb_NumMatriculaALUNO);
            this.tabPage_ALUNO.Controls.Add(this.txb_NomeALUNO);
            this.tabPage_ALUNO.Controls.Add(this.labeL_PeriodoALUNO);
            this.tabPage_ALUNO.Controls.Add(this.label_NumMatriculaALUNO);
            this.tabPage_ALUNO.Controls.Add(this.label_NomeALUNO);
            this.tabPage_ALUNO.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ALUNO.Name = "tabPage_ALUNO";
            this.tabPage_ALUNO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ALUNO.Size = new System.Drawing.Size(684, 345);
            this.tabPage_ALUNO.TabIndex = 1;
            this.tabPage_ALUNO.Text = "ALUNO";
            // 
            // button_RecALUNO
            // 
            this.button_RecALUNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_RecALUNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RecALUNO.Location = new System.Drawing.Point(457, 41);
            this.button_RecALUNO.Name = "button_RecALUNO";
            this.button_RecALUNO.Size = new System.Drawing.Size(87, 91);
            this.button_RecALUNO.TabIndex = 10;
            this.button_RecALUNO.Text = "GRAVAR";
            this.button_RecALUNO.UseVisualStyleBackColor = false;
            // 
            // txb_PeriodoALUNO
            // 
            this.txb_PeriodoALUNO.Location = new System.Drawing.Point(147, 178);
            this.txb_PeriodoALUNO.Name = "txb_PeriodoALUNO";
            this.txb_PeriodoALUNO.Size = new System.Drawing.Size(248, 20);
            this.txb_PeriodoALUNO.TabIndex = 8;
            // 
            // txb_NumMatriculaALUNO
            // 
            this.txb_NumMatriculaALUNO.Location = new System.Drawing.Point(147, 110);
            this.txb_NumMatriculaALUNO.Name = "txb_NumMatriculaALUNO";
            this.txb_NumMatriculaALUNO.Size = new System.Drawing.Size(248, 20);
            this.txb_NumMatriculaALUNO.TabIndex = 7;
            // 
            // txb_NomeALUNO
            // 
            this.txb_NomeALUNO.Location = new System.Drawing.Point(147, 42);
            this.txb_NomeALUNO.Name = "txb_NomeALUNO";
            this.txb_NomeALUNO.Size = new System.Drawing.Size(248, 20);
            this.txb_NomeALUNO.TabIndex = 6;
            // 
            // labeL_PeriodoALUNO
            // 
            this.labeL_PeriodoALUNO.AutoSize = true;
            this.labeL_PeriodoALUNO.BackColor = System.Drawing.Color.Transparent;
            this.labeL_PeriodoALUNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeL_PeriodoALUNO.ForeColor = System.Drawing.Color.White;
            this.labeL_PeriodoALUNO.Location = new System.Drawing.Point(36, 177);
            this.labeL_PeriodoALUNO.Name = "labeL_PeriodoALUNO";
            this.labeL_PeriodoALUNO.Size = new System.Drawing.Size(68, 18);
            this.labeL_PeriodoALUNO.TabIndex = 5;
            this.labeL_PeriodoALUNO.Text = "Período: ";
            // 
            // label_NumMatriculaALUNO
            // 
            this.label_NumMatriculaALUNO.AutoSize = true;
            this.label_NumMatriculaALUNO.BackColor = System.Drawing.Color.Transparent;
            this.label_NumMatriculaALUNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumMatriculaALUNO.ForeColor = System.Drawing.Color.White;
            this.label_NumMatriculaALUNO.Location = new System.Drawing.Point(36, 109);
            this.label_NumMatriculaALUNO.Name = "label_NumMatriculaALUNO";
            this.label_NumMatriculaALUNO.Size = new System.Drawing.Size(104, 18);
            this.label_NumMatriculaALUNO.TabIndex = 4;
            this.label_NumMatriculaALUNO.Text = "No. Matrícula: ";
            // 
            // label_NomeALUNO
            // 
            this.label_NomeALUNO.AutoSize = true;
            this.label_NomeALUNO.BackColor = System.Drawing.Color.Transparent;
            this.label_NomeALUNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomeALUNO.ForeColor = System.Drawing.Color.White;
            this.label_NomeALUNO.Location = new System.Drawing.Point(36, 41);
            this.label_NomeALUNO.Name = "label_NomeALUNO";
            this.label_NomeALUNO.Size = new System.Drawing.Size(57, 18);
            this.label_NomeALUNO.TabIndex = 3;
            this.label_NomeALUNO.Text = "Nome: ";
            // 
            // tabPage_MATRICULA
            // 
            this.tabPage_MATRICULA.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_MATRICULA.Controls.Add(this.gbx_MateriaMATRICULA);
            this.tabPage_MATRICULA.Controls.Add(this.gbx_AlunoMATRICULA);
            this.tabPage_MATRICULA.Controls.Add(this.buttom_RecMatricula);
            this.tabPage_MATRICULA.Controls.Add(this.txb_MateriaMATRICULA);
            this.tabPage_MATRICULA.Controls.Add(this.txb_AlunoMATRICULA);
            this.tabPage_MATRICULA.Controls.Add(this.label_MateriaMATRICULA);
            this.tabPage_MATRICULA.Controls.Add(this.label_AlunoMATRICULA);
            this.tabPage_MATRICULA.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MATRICULA.Name = "tabPage_MATRICULA";
            this.tabPage_MATRICULA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MATRICULA.Size = new System.Drawing.Size(684, 345);
            this.tabPage_MATRICULA.TabIndex = 2;
            this.tabPage_MATRICULA.Text = "MATRICULA";
            // 
            // gbx_MateriaMATRICULA
            // 
            this.gbx_MateriaMATRICULA.BackColor = System.Drawing.Color.DarkGray;
            this.gbx_MateriaMATRICULA.Location = new System.Drawing.Point(303, 169);
            this.gbx_MateriaMATRICULA.Name = "gbx_MateriaMATRICULA";
            this.gbx_MateriaMATRICULA.Size = new System.Drawing.Size(241, 156);
            this.gbx_MateriaMATRICULA.TabIndex = 15;
            this.gbx_MateriaMATRICULA.TabStop = false;
            this.gbx_MateriaMATRICULA.Text = "Lista de Matérias";
            // 
            // gbx_AlunoMATRICULA
            // 
            this.gbx_AlunoMATRICULA.BackColor = System.Drawing.Color.DarkGray;
            this.gbx_AlunoMATRICULA.Location = new System.Drawing.Point(42, 169);
            this.gbx_AlunoMATRICULA.Name = "gbx_AlunoMATRICULA";
            this.gbx_AlunoMATRICULA.Size = new System.Drawing.Size(241, 156);
            this.gbx_AlunoMATRICULA.TabIndex = 14;
            this.gbx_AlunoMATRICULA.TabStop = false;
            this.gbx_AlunoMATRICULA.Text = "Lista de Alunos";
            // 
            // buttom_RecMatricula
            // 
            this.buttom_RecMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttom_RecMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttom_RecMatricula.ForeColor = System.Drawing.Color.Black;
            this.buttom_RecMatricula.Location = new System.Drawing.Point(460, 41);
            this.buttom_RecMatricula.Name = "buttom_RecMatricula";
            this.buttom_RecMatricula.Size = new System.Drawing.Size(84, 89);
            this.buttom_RecMatricula.TabIndex = 13;
            this.buttom_RecMatricula.Text = "GRAVAR";
            this.buttom_RecMatricula.UseVisualStyleBackColor = false;
            // 
            // txb_MateriaMATRICULA
            // 
            this.txb_MateriaMATRICULA.Location = new System.Drawing.Point(164, 110);
            this.txb_MateriaMATRICULA.Name = "txb_MateriaMATRICULA";
            this.txb_MateriaMATRICULA.Size = new System.Drawing.Size(250, 20);
            this.txb_MateriaMATRICULA.TabIndex = 12;
            // 
            // txb_AlunoMATRICULA
            // 
            this.txb_AlunoMATRICULA.Location = new System.Drawing.Point(164, 42);
            this.txb_AlunoMATRICULA.Name = "txb_AlunoMATRICULA";
            this.txb_AlunoMATRICULA.Size = new System.Drawing.Size(250, 20);
            this.txb_AlunoMATRICULA.TabIndex = 11;
            // 
            // label_MateriaMATRICULA
            // 
            this.label_MateriaMATRICULA.AutoSize = true;
            this.label_MateriaMATRICULA.BackColor = System.Drawing.Color.Transparent;
            this.label_MateriaMATRICULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MateriaMATRICULA.ForeColor = System.Drawing.Color.White;
            this.label_MateriaMATRICULA.Location = new System.Drawing.Point(36, 109);
            this.label_MateriaMATRICULA.Name = "label_MateriaMATRICULA";
            this.label_MateriaMATRICULA.Size = new System.Drawing.Size(110, 18);
            this.label_MateriaMATRICULA.TabIndex = 10;
            this.label_MateriaMATRICULA.Text = "Nome Matéria: ";
            // 
            // label_AlunoMATRICULA
            // 
            this.label_AlunoMATRICULA.AutoSize = true;
            this.label_AlunoMATRICULA.BackColor = System.Drawing.Color.Transparent;
            this.label_AlunoMATRICULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlunoMATRICULA.ForeColor = System.Drawing.Color.White;
            this.label_AlunoMATRICULA.Location = new System.Drawing.Point(36, 41);
            this.label_AlunoMATRICULA.Name = "label_AlunoMATRICULA";
            this.label_AlunoMATRICULA.Size = new System.Drawing.Size(119, 18);
            this.label_AlunoMATRICULA.TabIndex = 9;
            this.label_AlunoMATRICULA.Text = "Nome do Aluno: ";
            // 
            // tabPage_RELATORIO
            // 
            this.tabPage_RELATORIO.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_RELATORIO.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RELATORIO.Name = "tabPage_RELATORIO";
            this.tabPage_RELATORIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RELATORIO.Size = new System.Drawing.Size(684, 345);
            this.tabPage_RELATORIO.TabIndex = 3;
            this.tabPage_RELATORIO.Text = "RELATÓRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlALUNO_MATERIA);
            this.Name = "Form1";
            this.Text = "Cadastro de Aluno e Matérias";
            this.tabControlALUNO_MATERIA.ResumeLayout(false);
            this.tabPage_MATERIA.ResumeLayout(false);
            this.tabPage_MATERIA.PerformLayout();
            this.tabPage_ALUNO.ResumeLayout(false);
            this.tabPage_ALUNO.PerformLayout();
            this.tabPage_MATRICULA.ResumeLayout(false);
            this.tabPage_MATRICULA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlALUNO_MATERIA;
        private System.Windows.Forms.TabPage tabPage_MATERIA;
        private System.Windows.Forms.TabPage tabPage_ALUNO;
        private System.Windows.Forms.TabPage tabPage_MATRICULA;
        private System.Windows.Forms.TabPage tabPage_RELATORIO;
        private System.Windows.Forms.Label labeL_PeriodoALUNO;
        private System.Windows.Forms.Label label_NumMatriculaALUNO;
        private System.Windows.Forms.Label label_NomeALUNO;
        private System.Windows.Forms.Label label_CodigoMATERIA;
        private System.Windows.Forms.Label label_NomeMATERIA;
        private System.Windows.Forms.TextBox txb_PeriodoALUNO;
        private System.Windows.Forms.TextBox txb_NumMatriculaALUNO;
        private System.Windows.Forms.TextBox txb_NomeALUNO;
        private System.Windows.Forms.Button button_RecMATERIA;
        private System.Windows.Forms.TextBox txb_CodigoMATERIA;
        private System.Windows.Forms.TextBox txb_NomeMATERIA;
        private System.Windows.Forms.Button button_RecALUNO;
        private System.Windows.Forms.GroupBox gbx_MateriaMATRICULA;
        private System.Windows.Forms.GroupBox gbx_AlunoMATRICULA;
        private System.Windows.Forms.Button buttom_RecMatricula;
        private System.Windows.Forms.TextBox txb_MateriaMATRICULA;
        private System.Windows.Forms.TextBox txb_AlunoMATRICULA;
        private System.Windows.Forms.Label label_MateriaMATRICULA;
        private System.Windows.Forms.Label label_AlunoMATRICULA;
    }
}

