namespace wfa_CadastroMateria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Codigo = new System.Windows.Forms.TextBox();
            this.button_reccord = new System.Windows.Forms.Button();
            this.button_relatorio = new System.Windows.Forms.Button();
            this.txb_relatorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(144, 52);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(390, 20);
            this.txb_Nome.TabIndex = 2;
            // 
            // txb_Codigo
            // 
            this.txb_Codigo.Location = new System.Drawing.Point(144, 126);
            this.txb_Codigo.Name = "txb_Codigo";
            this.txb_Codigo.Size = new System.Drawing.Size(390, 20);
            this.txb_Codigo.TabIndex = 3;
            // 
            // button_reccord
            // 
            this.button_reccord.Location = new System.Drawing.Point(578, 52);
            this.button_reccord.Name = "button_reccord";
            this.button_reccord.Size = new System.Drawing.Size(103, 94);
            this.button_reccord.TabIndex = 4;
            this.button_reccord.Text = "Gravar";
            this.button_reccord.UseVisualStyleBackColor = true;
            this.button_reccord.Click += new System.EventHandler(this.button_reccord_Click);
            // 
            // button_relatorio
            // 
            this.button_relatorio.Location = new System.Drawing.Point(578, 344);
            this.button_relatorio.Name = "button_relatorio";
            this.button_relatorio.Size = new System.Drawing.Size(103, 29);
            this.button_relatorio.TabIndex = 5;
            this.button_relatorio.Text = "Relatório";
            this.button_relatorio.UseVisualStyleBackColor = true;
            this.button_relatorio.Click += new System.EventHandler(this.button_relatorio_Click);
            // 
            // txb_relatorio
            // 
            this.txb_relatorio.Location = new System.Drawing.Point(48, 205);
            this.txb_relatorio.Multiline = true;
            this.txb_relatorio.Name = "txb_relatorio";
            this.txb_relatorio.Size = new System.Drawing.Size(486, 168);
            this.txb_relatorio.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.txb_relatorio);
            this.Controls.Add(this.button_relatorio);
            this.Controls.Add(this.button_reccord);
            this.Controls.Add(this.txb_Codigo);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Codigo;
        private System.Windows.Forms.Button button_reccord;
        private System.Windows.Forms.Button button_relatorio;
        private System.Windows.Forms.TextBox txb_relatorio;
    }
}

