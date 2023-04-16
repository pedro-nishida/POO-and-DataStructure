namespace wfaPessoaFJ
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
            this.radioButtonPFISICA = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelCPF_CNPJ = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.listViewCPF = new System.Windows.Forms.ListView();
            this.listViewCNPJ = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // radioButtonPFISICA
            // 
            this.radioButtonPFISICA.AutoSize = true;
            this.radioButtonPFISICA.Location = new System.Drawing.Point(13, 13);
            this.radioButtonPFISICA.Name = "radioButtonPFISICA";
            this.radioButtonPFISICA.Size = new System.Drawing.Size(92, 17);
            this.radioButtonPFISICA.TabIndex = 0;
            this.radioButtonPFISICA.TabStop = true;
            this.radioButtonPFISICA.Text = "Pessoa Física";
            this.radioButtonPFISICA.UseVisualStyleBackColor = true;
            this.radioButtonPFISICA.CheckedChanged += new System.EventHandler(this.radioButtonPFISICA_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(157, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pessoa Jurídica";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelCPF_CNPJ
            // 
            this.labelCPF_CNPJ.AutoSize = true;
            this.labelCPF_CNPJ.Location = new System.Drawing.Point(61, 49);
            this.labelCPF_CNPJ.Name = "labelCPF_CNPJ";
            this.labelCPF_CNPJ.Size = new System.Drawing.Size(27, 13);
            this.labelCPF_CNPJ.TabIndex = 2;
            this.labelCPF_CNPJ.Text = "CPF";
            // 
            // maskedTextBoxCPF_CNPJ
            // 
            this.maskedTextBoxCPF_CNPJ.Location = new System.Drawing.Point(94, 46);
            this.maskedTextBoxCPF_CNPJ.Name = "maskedTextBoxCPF_CNPJ";
            this.maskedTextBoxCPF_CNPJ.Size = new System.Drawing.Size(267, 20);
            this.maskedTextBoxCPF_CNPJ.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(46, 81);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(94, 81);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(267, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(37, 120);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(94, 120);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(267, 20);
            this.textBoxCidade.TabIndex = 7;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(64, 221);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(86, 23);
            this.buttonCADASTRAR.TabIndex = 8;
            this.buttonCADASTRAR.Text = "CADASTRAR";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCADASTRAR_MouseClick);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(219, 221);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLimpar_MouseClick);
            // 
            // listViewCPF
            // 
            this.listViewCPF.HideSelection = false;
            this.listViewCPF.Location = new System.Drawing.Point(49, 279);
            this.listViewCPF.Name = "listViewCPF";
            this.listViewCPF.Size = new System.Drawing.Size(477, 73);
            this.listViewCPF.TabIndex = 10;
            this.listViewCPF.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCNPJ
            // 
            this.listViewCNPJ.HideSelection = false;
            this.listViewCNPJ.Location = new System.Drawing.Point(49, 359);
            this.listViewCNPJ.Name = "listViewCNPJ";
            this.listViewCNPJ.Size = new System.Drawing.Size(477, 71);
            this.listViewCNPJ.TabIndex = 11;
            this.listViewCNPJ.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCNPJ);
            this.Controls.Add(this.listViewCPF);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.maskedTextBoxCPF_CNPJ);
            this.Controls.Add(this.labelCPF_CNPJ);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonPFISICA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPFISICA;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF_CNPJ;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listViewCPF;
        private System.Windows.Forms.ListView listViewCNPJ;
    }
}

