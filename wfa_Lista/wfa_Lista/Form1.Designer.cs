namespace wfa_Lista
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
            this.label_Numero = new System.Windows.Forms.Label();
            this.label_Lista = new System.Windows.Forms.Label();
            this.txb_Num = new System.Windows.Forms.TextBox();
            this.txb_Lista = new System.Windows.Forms.TextBox();
            this.button_insertFIM = new System.Windows.Forms.Button();
            this.button_imprimir = new System.Windows.Forms.Button();
            this.button_insertBegin = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_okRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Location = new System.Drawing.Point(55, 58);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(50, 13);
            this.label_Numero.TabIndex = 0;
            this.label_Numero.Text = "Número: ";
            // 
            // label_Lista
            // 
            this.label_Lista.AutoSize = true;
            this.label_Lista.Location = new System.Drawing.Point(55, 142);
            this.label_Lista.Name = "label_Lista";
            this.label_Lista.Size = new System.Drawing.Size(35, 13);
            this.label_Lista.TabIndex = 1;
            this.label_Lista.Text = "Lista: ";
            // 
            // txb_Num
            // 
            this.txb_Num.Location = new System.Drawing.Point(157, 55);
            this.txb_Num.Name = "txb_Num";
            this.txb_Num.Size = new System.Drawing.Size(315, 20);
            this.txb_Num.TabIndex = 2;
            // 
            // txb_Lista
            // 
            this.txb_Lista.Location = new System.Drawing.Point(157, 139);
            this.txb_Lista.Name = "txb_Lista";
            this.txb_Lista.Size = new System.Drawing.Size(315, 20);
            this.txb_Lista.TabIndex = 3;
            // 
            // button_insertFIM
            // 
            this.button_insertFIM.Location = new System.Drawing.Point(478, 52);
            this.button_insertFIM.Name = "button_insertFIM";
            this.button_insertFIM.Size = new System.Drawing.Size(75, 23);
            this.button_insertFIM.TabIndex = 4;
            this.button_insertFIM.Text = "Insira Fim";
            this.button_insertFIM.UseVisualStyleBackColor = true;
            this.button_insertFIM.Click += new System.EventHandler(this.button_insertFIM_Click_1);
            // 
            // button_imprimir
            // 
            this.button_imprimir.Location = new System.Drawing.Point(478, 137);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(75, 23);
            this.button_imprimir.TabIndex = 5;
            this.button_imprimir.Text = "Imprimir";
            this.button_imprimir.UseVisualStyleBackColor = true;
            this.button_imprimir.Click += new System.EventHandler(this.button_imprimir_Click);
            // 
            // button_insertBegin
            // 
            this.button_insertBegin.Location = new System.Drawing.Point(581, 52);
            this.button_insertBegin.Name = "button_insertBegin";
            this.button_insertBegin.Size = new System.Drawing.Size(75, 23);
            this.button_insertBegin.TabIndex = 6;
            this.button_insertBegin.Text = "Insere Inicio";
            this.button_insertBegin.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(678, 52);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(60, 23);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "Remover";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_remove_MouseClick);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(581, 137);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 8;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_limpar_MouseClick);
            // 
            // button_okRemove
            // 
            this.button_okRemove.Location = new System.Drawing.Point(736, 53);
            this.button_okRemove.Name = "button_okRemove";
            this.button_okRemove.Size = new System.Drawing.Size(37, 23);
            this.button_okRemove.TabIndex = 9;
            this.button_okRemove.Text = "Ok";
            this.button_okRemove.UseVisualStyleBackColor = true;
            this.button_okRemove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_okRemove_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_okRemove);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_insertBegin);
            this.Controls.Add(this.button_imprimir);
            this.Controls.Add(this.button_insertFIM);
            this.Controls.Add(this.txb_Lista);
            this.Controls.Add(this.txb_Num);
            this.Controls.Add(this.label_Lista);
            this.Controls.Add(this.label_Numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.Label label_Lista;
        private System.Windows.Forms.TextBox txb_Num;
        private System.Windows.Forms.TextBox txb_Lista;
        private System.Windows.Forms.Button button_insertFIM;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.Button button_insertBegin;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_okRemove;
    }
}

