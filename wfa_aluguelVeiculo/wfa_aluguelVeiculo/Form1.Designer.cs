namespace wfa_aluguelVeiculo
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
            this.rb_Onibus = new System.Windows.Forms.RadioButton();
            this.rb_Caminhao = new System.Windows.Forms.RadioButton();
            this.pb_Veiculo = new System.Windows.Forms.PictureBox();
            this.label_Placa = new System.Windows.Forms.Label();
            this.label_AnoVeiculo = new System.Windows.Forms.Label();
            this.label_AssentoOuEixo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.txb_QntAssento = new System.Windows.Forms.TextBox();
            this.txb_AnoVeiculo = new System.Windows.Forms.TextBox();
            this.mTxb_Placa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Veiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Onibus
            // 
            this.rb_Onibus.AutoSize = true;
            this.rb_Onibus.Location = new System.Drawing.Point(42, 37);
            this.rb_Onibus.Name = "rb_Onibus";
            this.rb_Onibus.Size = new System.Drawing.Size(58, 17);
            this.rb_Onibus.TabIndex = 0;
            this.rb_Onibus.TabStop = true;
            this.rb_Onibus.Text = "Ônibus";
            this.rb_Onibus.UseVisualStyleBackColor = true;
            this.rb_Onibus.CheckedChanged += new System.EventHandler(this.rb_Onibus_CheckedChanged);
            // 
            // rb_Caminhao
            // 
            this.rb_Caminhao.AutoSize = true;
            this.rb_Caminhao.Location = new System.Drawing.Point(160, 37);
            this.rb_Caminhao.Name = "rb_Caminhao";
            this.rb_Caminhao.Size = new System.Drawing.Size(72, 17);
            this.rb_Caminhao.TabIndex = 1;
            this.rb_Caminhao.TabStop = true;
            this.rb_Caminhao.Text = "Caminhão";
            this.rb_Caminhao.UseVisualStyleBackColor = true;
            this.rb_Caminhao.CheckedChanged += new System.EventHandler(this.rb_Caminhao_CheckedChanged);
            // 
            // pb_Veiculo
            // 
            this.pb_Veiculo.Location = new System.Drawing.Point(341, 37);
            this.pb_Veiculo.Name = "pb_Veiculo";
            this.pb_Veiculo.Size = new System.Drawing.Size(137, 129);
            this.pb_Veiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Veiculo.TabIndex = 2;
            this.pb_Veiculo.TabStop = false;
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Location = new System.Drawing.Point(76, 72);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(37, 13);
            this.label_Placa.TabIndex = 3;
            this.label_Placa.Text = "Placa:";
            // 
            // label_AnoVeiculo
            // 
            this.label_AnoVeiculo.AutoSize = true;
            this.label_AnoVeiculo.Location = new System.Drawing.Point(76, 122);
            this.label_AnoVeiculo.Name = "label_AnoVeiculo";
            this.label_AnoVeiculo.Size = new System.Drawing.Size(26, 13);
            this.label_AnoVeiculo.TabIndex = 4;
            this.label_AnoVeiculo.Text = "Ano";
            // 
            // label_AssentoOuEixo
            // 
            this.label_AssentoOuEixo.AutoSize = true;
            this.label_AssentoOuEixo.Location = new System.Drawing.Point(76, 173);
            this.label_AssentoOuEixo.Name = "label_AssentoOuEixo";
            this.label_AssentoOuEixo.Size = new System.Drawing.Size(70, 13);
            this.label_AssentoOuEixo.TabIndex = 5;
            this.label_AssentoOuEixo.Text = "Qtd Assentos";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 174);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(79, 217);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cadastrar.TabIndex = 7;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(185, 217);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpar.TabIndex = 8;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // txb_QntAssento
            // 
            this.txb_QntAssento.Location = new System.Drawing.Point(185, 170);
            this.txb_QntAssento.Name = "txb_QntAssento";
            this.txb_QntAssento.Size = new System.Drawing.Size(100, 20);
            this.txb_QntAssento.TabIndex = 10;
            // 
            // txb_AnoVeiculo
            // 
            this.txb_AnoVeiculo.Location = new System.Drawing.Point(185, 119);
            this.txb_AnoVeiculo.Name = "txb_AnoVeiculo";
            this.txb_AnoVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txb_AnoVeiculo.TabIndex = 11;
            // 
            // mTxb_Placa
            // 
            this.mTxb_Placa.Location = new System.Drawing.Point(185, 69);
            this.mTxb_Placa.Mask = "AAA-0000";
            this.mTxb_Placa.Name = "mTxb_Placa";
            this.mTxb_Placa.Size = new System.Drawing.Size(100, 20);
            this.mTxb_Placa.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 432);
            this.Controls.Add(this.mTxb_Placa);
            this.Controls.Add(this.txb_AnoVeiculo);
            this.Controls.Add(this.txb_QntAssento);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_AssentoOuEixo);
            this.Controls.Add(this.label_AnoVeiculo);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.pb_Veiculo);
            this.Controls.Add(this.rb_Caminhao);
            this.Controls.Add(this.rb_Onibus);
            this.Name = "Form1";
            this.Text = "Cadastro Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Veiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Onibus;
        private System.Windows.Forms.RadioButton rb_Caminhao;
        private System.Windows.Forms.PictureBox pb_Veiculo;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.Label label_AnoVeiculo;
        private System.Windows.Forms.Label label_AssentoOuEixo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.TextBox txb_QntAssento;
        private System.Windows.Forms.TextBox txb_AnoVeiculo;
        private System.Windows.Forms.MaskedTextBox mTxb_Placa;
    }
}

