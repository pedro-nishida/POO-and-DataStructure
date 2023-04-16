namespace wfa_geometria
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
            this.pictureBox_forma = new System.Windows.Forms.PictureBox();
            this.pictureBox_dimenions = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_dim1 = new System.Windows.Forms.TextBox();
            this.label_raio = new System.Windows.Forms.Label();
            this.rButton_quadrado = new System.Windows.Forms.RadioButton();
            this.rButton_Retangulo = new System.Windows.Forms.RadioButton();
            this.rButton_triangulo = new System.Windows.Forms.RadioButton();
            this.rButton_circulo = new System.Windows.Forms.RadioButton();
            this.button_area = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dimenions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_forma
            // 
            this.pictureBox_forma.Location = new System.Drawing.Point(23, 12);
            this.pictureBox_forma.Name = "pictureBox_forma";
            this.pictureBox_forma.Size = new System.Drawing.Size(265, 257);
            this.pictureBox_forma.TabIndex = 0;
            this.pictureBox_forma.TabStop = false;
            // 
            // pictureBox_dimenions
            // 
            this.pictureBox_dimenions.Location = new System.Drawing.Point(23, 295);
            this.pictureBox_dimenions.Name = "pictureBox_dimenions";
            this.pictureBox_dimenions.Size = new System.Drawing.Size(265, 146);
            this.pictureBox_dimenions.TabIndex = 1;
            this.pictureBox_dimenions.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 457);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(803, 173);
            this.listBox1.TabIndex = 2;
            // 
            // tb_dim1
            // 
            this.tb_dim1.Location = new System.Drawing.Point(102, 309);
            this.tb_dim1.Name = "tb_dim1";
            this.tb_dim1.Size = new System.Drawing.Size(166, 20);
            this.tb_dim1.TabIndex = 3;
            // 
            // label_raio
            // 
            this.label_raio.AutoSize = true;
            this.label_raio.Location = new System.Drawing.Point(37, 312);
            this.label_raio.Name = "label_raio";
            this.label_raio.Size = new System.Drawing.Size(32, 13);
            this.label_raio.TabIndex = 4;
            this.label_raio.Text = "Raio:";
            // 
            // rButton_quadrado
            // 
            this.rButton_quadrado.AutoSize = true;
            this.rButton_quadrado.Location = new System.Drawing.Point(321, 27);
            this.rButton_quadrado.Name = "rButton_quadrado";
            this.rButton_quadrado.Size = new System.Drawing.Size(72, 17);
            this.rButton_quadrado.TabIndex = 5;
            this.rButton_quadrado.TabStop = true;
            this.rButton_quadrado.Text = "Quadrado";
            this.rButton_quadrado.UseVisualStyleBackColor = true;
            this.rButton_quadrado.CheckedChanged += new System.EventHandler(this.rButton_quadrado_CheckedChanged);
            // 
            // rButton_Retangulo
            // 
            this.rButton_Retangulo.AutoSize = true;
            this.rButton_Retangulo.Location = new System.Drawing.Point(321, 96);
            this.rButton_Retangulo.Name = "rButton_Retangulo";
            this.rButton_Retangulo.Size = new System.Drawing.Size(74, 17);
            this.rButton_Retangulo.TabIndex = 6;
            this.rButton_Retangulo.TabStop = true;
            this.rButton_Retangulo.Text = "Retangulo";
            this.rButton_Retangulo.UseVisualStyleBackColor = true;
            this.rButton_Retangulo.CheckedChanged += new System.EventHandler(this.rButton_Retangulo_CheckedChanged);
            // 
            // rButton_triangulo
            // 
            this.rButton_triangulo.AutoSize = true;
            this.rButton_triangulo.Location = new System.Drawing.Point(321, 165);
            this.rButton_triangulo.Name = "rButton_triangulo";
            this.rButton_triangulo.Size = new System.Drawing.Size(69, 17);
            this.rButton_triangulo.TabIndex = 7;
            this.rButton_triangulo.TabStop = true;
            this.rButton_triangulo.Text = "Triangulo";
            this.rButton_triangulo.UseVisualStyleBackColor = true;
            this.rButton_triangulo.CheckedChanged += new System.EventHandler(this.rButton_triangulo_CheckedChanged);
            // 
            // rButton_circulo
            // 
            this.rButton_circulo.AutoSize = true;
            this.rButton_circulo.Location = new System.Drawing.Point(321, 234);
            this.rButton_circulo.Name = "rButton_circulo";
            this.rButton_circulo.Size = new System.Drawing.Size(57, 17);
            this.rButton_circulo.TabIndex = 8;
            this.rButton_circulo.TabStop = true;
            this.rButton_circulo.Text = "Circulo";
            this.rButton_circulo.UseVisualStyleBackColor = true;
            this.rButton_circulo.CheckedChanged += new System.EventHandler(this.rButton_circulo_CheckedChanged);
            // 
            // button_area
            // 
            this.button_area.Location = new System.Drawing.Point(321, 295);
            this.button_area.Name = "button_area";
            this.button_area.Size = new System.Drawing.Size(98, 34);
            this.button_area.TabIndex = 9;
            this.button_area.Text = "AREA";
            this.button_area.UseVisualStyleBackColor = true;
            this.button_area.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_area_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_area);
            this.Controls.Add(this.rButton_circulo);
            this.Controls.Add(this.rButton_triangulo);
            this.Controls.Add(this.rButton_Retangulo);
            this.Controls.Add(this.rButton_quadrado);
            this.Controls.Add(this.label_raio);
            this.Controls.Add(this.tb_dim1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox_dimenions);
            this.Controls.Add(this.pictureBox_forma);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dimenions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_forma;
        private System.Windows.Forms.PictureBox pictureBox_dimenions;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_dim1;
        private System.Windows.Forms.Label label_raio;
        private System.Windows.Forms.RadioButton rButton_quadrado;
        private System.Windows.Forms.RadioButton rButton_Retangulo;
        private System.Windows.Forms.RadioButton rButton_triangulo;
        private System.Windows.Forms.RadioButton rButton_circulo;
        private System.Windows.Forms.Button button_area;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

