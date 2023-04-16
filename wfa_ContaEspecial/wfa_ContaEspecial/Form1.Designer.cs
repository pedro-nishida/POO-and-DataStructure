namespace wfa_ContaEspecial
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
            this.rButton_Conta = new System.Windows.Forms.RadioButton();
            this.rButton_cEspecial = new System.Windows.Forms.RadioButton();
            this.label_numConta = new System.Windows.Forms.Label();
            this.label_Saldo = new System.Windows.Forms.Label();
            this.txb_numConta = new System.Windows.Forms.TextBox();
            this.txb_saldo = new System.Windows.Forms.TextBox();
            this.label_Limite = new System.Windows.Forms.Label();
            this.txb_Limite = new System.Windows.Forms.TextBox();
            this.button_Gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rButton_Conta
            // 
            this.rButton_Conta.AutoSize = true;
            this.rButton_Conta.Location = new System.Drawing.Point(50, 55);
            this.rButton_Conta.Name = "rButton_Conta";
            this.rButton_Conta.Size = new System.Drawing.Size(53, 17);
            this.rButton_Conta.TabIndex = 0;
            this.rButton_Conta.TabStop = true;
            this.rButton_Conta.Text = "Conta";
            this.rButton_Conta.UseVisualStyleBackColor = true;
            this.rButton_Conta.CheckedChanged += new System.EventHandler(this.rButton_Conta_CheckedChanged);
            // 
            // rButton_cEspecial
            // 
            this.rButton_cEspecial.AutoSize = true;
            this.rButton_cEspecial.Location = new System.Drawing.Point(180, 55);
            this.rButton_cEspecial.Name = "rButton_cEspecial";
            this.rButton_cEspecial.Size = new System.Drawing.Size(96, 17);
            this.rButton_cEspecial.TabIndex = 1;
            this.rButton_cEspecial.TabStop = true;
            this.rButton_cEspecial.Text = "Conta Especial";
            this.rButton_cEspecial.UseVisualStyleBackColor = true;
            this.rButton_cEspecial.CheckedChanged += new System.EventHandler(this.rButton_cEspecial_CheckedChanged);
            // 
            // label_numConta
            // 
            this.label_numConta.AutoSize = true;
            this.label_numConta.Location = new System.Drawing.Point(50, 109);
            this.label_numConta.Name = "label_numConta";
            this.label_numConta.Size = new System.Drawing.Size(81, 13);
            this.label_numConta.TabIndex = 2;
            this.label_numConta.Text = "Número Conta: ";
            // 
            // label_Saldo
            // 
            this.label_Saldo.AutoSize = true;
            this.label_Saldo.Location = new System.Drawing.Point(50, 159);
            this.label_Saldo.Name = "label_Saldo";
            this.label_Saldo.Size = new System.Drawing.Size(43, 13);
            this.label_Saldo.TabIndex = 3;
            this.label_Saldo.Text = "Saldo : ";
            // 
            // txb_numConta
            // 
            this.txb_numConta.Location = new System.Drawing.Point(162, 106);
            this.txb_numConta.Name = "txb_numConta";
            this.txb_numConta.Size = new System.Drawing.Size(114, 20);
            this.txb_numConta.TabIndex = 4;
            // 
            // txb_saldo
            // 
            this.txb_saldo.Location = new System.Drawing.Point(162, 156);
            this.txb_saldo.Name = "txb_saldo";
            this.txb_saldo.Size = new System.Drawing.Size(114, 20);
            this.txb_saldo.TabIndex = 5;
            // 
            // label_Limite
            // 
            this.label_Limite.AutoSize = true;
            this.label_Limite.Location = new System.Drawing.Point(50, 213);
            this.label_Limite.Name = "label_Limite";
            this.label_Limite.Size = new System.Drawing.Size(43, 13);
            this.label_Limite.TabIndex = 6;
            this.label_Limite.Text = "Limite : ";
            // 
            // txb_Limite
            // 
            this.txb_Limite.Location = new System.Drawing.Point(162, 206);
            this.txb_Limite.Name = "txb_Limite";
            this.txb_Limite.Size = new System.Drawing.Size(114, 20);
            this.txb_Limite.TabIndex = 7;
            // 
            // button_Gravar
            // 
            this.button_Gravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Gravar.Location = new System.Drawing.Point(50, 277);
            this.button_Gravar.Name = "button_Gravar";
            this.button_Gravar.Size = new System.Drawing.Size(226, 71);
            this.button_Gravar.TabIndex = 8;
            this.button_Gravar.Text = "GRAVAR";
            this.button_Gravar.UseVisualStyleBackColor = false;
            this.button_Gravar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Gravar_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.button_Gravar);
            this.Controls.Add(this.txb_Limite);
            this.Controls.Add(this.label_Limite);
            this.Controls.Add(this.txb_saldo);
            this.Controls.Add(this.txb_numConta);
            this.Controls.Add(this.label_Saldo);
            this.Controls.Add(this.label_numConta);
            this.Controls.Add(this.rButton_cEspecial);
            this.Controls.Add(this.rButton_Conta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rButton_Conta;
        private System.Windows.Forms.RadioButton rButton_cEspecial;
        private System.Windows.Forms.Label label_numConta;
        private System.Windows.Forms.Label label_Saldo;
        private System.Windows.Forms.TextBox txb_numConta;
        private System.Windows.Forms.TextBox txb_saldo;
        private System.Windows.Forms.Label label_Limite;
        private System.Windows.Forms.TextBox txb_Limite;
        private System.Windows.Forms.Button button_Gravar;
    }
}

