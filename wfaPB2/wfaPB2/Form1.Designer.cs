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
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.picBoxFIGURAS = new System.Windows.Forms.PictureBox();
            this.rbTrapezio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFIGURAS)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(533, 67);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(110, 29);
            this.rbCirculo.TabIndex = 1;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Location = new System.Drawing.Point(533, 146);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(141, 29);
            this.rbRetangulo.TabIndex = 2;
            this.rbRetangulo.Text = "Retangulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // picBoxFIGURAS
            // 
            this.picBoxFIGURAS.Image = global::wfaPB2.Properties.Resources.trapezio;
            this.picBoxFIGURAS.Location = new System.Drawing.Point(69, 31);
            this.picBoxFIGURAS.Name = "picBoxFIGURAS";
            this.picBoxFIGURAS.Size = new System.Drawing.Size(403, 317);
            this.picBoxFIGURAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFIGURAS.TabIndex = 0;
            this.picBoxFIGURAS.TabStop = false;
            // 
            // rbTrapezio
            // 
            this.rbTrapezio.AutoSize = true;
            this.rbTrapezio.Location = new System.Drawing.Point(533, 234);
            this.rbTrapezio.Name = "rbTrapezio";
            this.rbTrapezio.Size = new System.Drawing.Size(127, 29);
            this.rbTrapezio.TabIndex = 3;
            this.rbTrapezio.Text = "Trapézio";
            this.rbTrapezio.UseVisualStyleBackColor = true;
            this.rbTrapezio.CheckedChanged += new System.EventHandler(this.rbTrapezio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 762);
            this.Controls.Add(this.rbTrapezio);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.picBoxFIGURAS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFIGURAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFIGURAS;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbTrapezio;
    }
}

