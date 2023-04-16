namespace wfaPB2
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
            this.radioButton_Circulo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_retangulo = new System.Windows.Forms.RadioButton();
            this.radioButton_Triangulo = new System.Windows.Forms.RadioButton();
            this.radioButton_Quadrado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Circulo
            // 
            this.radioButton_Circulo.AutoSize = true;
            this.radioButton_Circulo.Location = new System.Drawing.Point(348, 61);
            this.radioButton_Circulo.Name = "radioButton_Circulo";
            this.radioButton_Circulo.Size = new System.Drawing.Size(57, 17);
            this.radioButton_Circulo.TabIndex = 0;
            this.radioButton_Circulo.TabStop = true;
            this.radioButton_Circulo.Text = "Circulo";
            this.radioButton_Circulo.UseVisualStyleBackColor = true;
            this.radioButton_Circulo.CheckedChanged += new System.EventHandler(this.radioButton_Circulo_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaPB2.Properties.Resources.branco;
            this.pictureBox1.Location = new System.Drawing.Point(39, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_retangulo
            // 
            this.radioButton_retangulo.AutoSize = true;
            this.radioButton_retangulo.Location = new System.Drawing.Point(349, 107);
            this.radioButton_retangulo.Name = "radioButton_retangulo";
            this.radioButton_retangulo.Size = new System.Drawing.Size(74, 17);
            this.radioButton_retangulo.TabIndex = 2;
            this.radioButton_retangulo.TabStop = true;
            this.radioButton_retangulo.Text = "Retangulo";
            this.radioButton_retangulo.UseVisualStyleBackColor = true;
            this.radioButton_retangulo.CheckedChanged += new System.EventHandler(this.radioButton_retangulo_CheckedChanged);
            // 
            // radioButton_Triangulo
            // 
            this.radioButton_Triangulo.AutoSize = true;
            this.radioButton_Triangulo.Location = new System.Drawing.Point(348, 191);
            this.radioButton_Triangulo.Name = "radioButton_Triangulo";
            this.radioButton_Triangulo.Size = new System.Drawing.Size(69, 17);
            this.radioButton_Triangulo.TabIndex = 3;
            this.radioButton_Triangulo.TabStop = true;
            this.radioButton_Triangulo.Text = "Triangulo";
            this.radioButton_Triangulo.UseVisualStyleBackColor = true;
            this.radioButton_Triangulo.CheckedChanged += new System.EventHandler(this.radioButton_Triangulo_CheckedChanged);
            // 
            // radioButton_Quadrado
            // 
            this.radioButton_Quadrado.AutoSize = true;
            this.radioButton_Quadrado.Location = new System.Drawing.Point(348, 148);
            this.radioButton_Quadrado.Name = "radioButton_Quadrado";
            this.radioButton_Quadrado.Size = new System.Drawing.Size(72, 17);
            this.radioButton_Quadrado.TabIndex = 4;
            this.radioButton_Quadrado.TabStop = true;
            this.radioButton_Quadrado.Text = "Quadrado";
            this.radioButton_Quadrado.UseVisualStyleBackColor = true;
            this.radioButton_Quadrado.CheckedChanged += new System.EventHandler(this.radioButton_Quadrado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_Quadrado);
            this.Controls.Add(this.radioButton_Triangulo);
            this.Controls.Add(this.radioButton_retangulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton_Circulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Circulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_retangulo;
        private System.Windows.Forms.RadioButton radioButton_Triangulo;
        private System.Windows.Forms.RadioButton radioButton_Quadrado;
    }
}

