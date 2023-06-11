namespace wfa_BancoDadosFinanciadora
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
            this.label_Cpf = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Salario = new System.Windows.Forms.Label();
            this.maskedTextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Salario = new System.Windows.Forms.TextBox();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.button_Exibir = new System.Windows.Forms.Button();
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.button_Apagar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Cpf
            // 
            this.label_Cpf.AutoSize = true;
            this.label_Cpf.Location = new System.Drawing.Point(42, 50);
            this.label_Cpf.Name = "label_Cpf";
            this.label_Cpf.Size = new System.Drawing.Size(30, 13);
            this.label_Cpf.TabIndex = 0;
            this.label_Cpf.Text = "CPF:";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(42, 90);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(38, 13);
            this.label_Nome.TabIndex = 1;
            this.label_Nome.Text = "Nome:";
            // 
            // label_Salario
            // 
            this.label_Salario.AutoSize = true;
            this.label_Salario.Location = new System.Drawing.Point(42, 133);
            this.label_Salario.Name = "label_Salario";
            this.label_Salario.Size = new System.Drawing.Size(39, 13);
            this.label_Salario.TabIndex = 2;
            this.label_Salario.Text = "Salário";
            // 
            // maskedTextBox_Cpf
            // 
            this.maskedTextBox_Cpf.Location = new System.Drawing.Point(118, 50);
            this.maskedTextBox_Cpf.Mask = "000.000.000-00";
            this.maskedTextBox_Cpf.Name = "maskedTextBox_Cpf";
            this.maskedTextBox_Cpf.Size = new System.Drawing.Size(356, 20);
            this.maskedTextBox_Cpf.TabIndex = 3;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(118, 90);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(356, 20);
            this.textBox_Nome.TabIndex = 4;
            // 
            // textBox_Salario
            // 
            this.textBox_Salario.Location = new System.Drawing.Point(118, 133);
            this.textBox_Salario.Name = "textBox_Salario";
            this.textBox_Salario.Size = new System.Drawing.Size(356, 20);
            this.textBox_Salario.TabIndex = 5;
            // 
            // button_Inserir
            // 
            this.button_Inserir.Location = new System.Drawing.Point(45, 192);
            this.button_Inserir.Name = "button_Inserir";
            this.button_Inserir.Size = new System.Drawing.Size(75, 23);
            this.button_Inserir.TabIndex = 6;
            this.button_Inserir.Text = "INSERIR";
            this.button_Inserir.UseVisualStyleBackColor = true;
            this.button_Inserir.Click += new System.EventHandler(this.button_Inserir_Click);
            // 
            // button_Exibir
            // 
            this.button_Exibir.Location = new System.Drawing.Point(195, 192);
            this.button_Exibir.Name = "button_Exibir";
            this.button_Exibir.Size = new System.Drawing.Size(75, 23);
            this.button_Exibir.TabIndex = 7;
            this.button_Exibir.Text = "EXIBIR";
            this.button_Exibir.UseVisualStyleBackColor = true;
            this.button_Exibir.Click += new System.EventHandler(this.button_Exibir_Click);
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.Location = new System.Drawing.Point(345, 192);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_Atualizar.TabIndex = 8;
            this.button_Atualizar.Text = "ATUALIZAR";
            this.button_Atualizar.UseVisualStyleBackColor = true;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // button_Apagar
            // 
            this.button_Apagar.Location = new System.Drawing.Point(495, 192);
            this.button_Apagar.Name = "button_Apagar";
            this.button_Apagar.Size = new System.Drawing.Size(75, 23);
            this.button_Apagar.TabIndex = 9;
            this.button_Apagar.Text = "APAGAR";
            this.button_Apagar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Apagar);
            this.Controls.Add(this.button_Atualizar);
            this.Controls.Add(this.button_Exibir);
            this.Controls.Add(this.button_Inserir);
            this.Controls.Add(this.textBox_Salario);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.maskedTextBox_Cpf);
            this.Controls.Add(this.label_Salario);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label_Cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Cpf;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Salario;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cpf;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Salario;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.Button button_Exibir;
        private System.Windows.Forms.Button button_Atualizar;
        private System.Windows.Forms.Button button_Apagar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

