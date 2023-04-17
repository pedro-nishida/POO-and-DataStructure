namespace wfa_MAritimética
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_x2 = new System.Windows.Forms.TextBox();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.txb_c = new System.Windows.Forms.TextBox();
            this.txb_Delta = new System.Windows.Forms.TextBox();
            this.txb_x1 = new System.Windows.Forms.TextBox();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(67, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delta = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(67, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "a =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(525, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "c =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(296, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(296, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "x1 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(525, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "x2 = ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(341, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_x2
            // 
            this.txb_x2.Location = new System.Drawing.Point(605, 302);
            this.txb_x2.Name = "txb_x2";
            this.txb_x2.Size = new System.Drawing.Size(100, 20);
            this.txb_x2.TabIndex = 10;
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(376, 81);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(100, 20);
            this.txb_b.TabIndex = 11;
            // 
            // txb_c
            // 
            this.txb_c.Location = new System.Drawing.Point(605, 81);
            this.txb_c.Name = "txb_c";
            this.txb_c.Size = new System.Drawing.Size(100, 20);
            this.txb_c.TabIndex = 12;
            // 
            // txb_Delta
            // 
            this.txb_Delta.Location = new System.Drawing.Point(147, 299);
            this.txb_Delta.Name = "txb_Delta";
            this.txb_Delta.Size = new System.Drawing.Size(100, 20);
            this.txb_Delta.TabIndex = 13;
            // 
            // txb_x1
            // 
            this.txb_x1.Location = new System.Drawing.Point(376, 299);
            this.txb_x1.Name = "txb_x1";
            this.txb_x1.Size = new System.Drawing.Size(100, 20);
            this.txb_x1.TabIndex = 14;
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(147, 84);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(100, 20);
            this.txb_a.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_a);
            this.Controls.Add(this.txb_x1);
            this.Controls.Add(this.txb_Delta);
            this.Controls.Add(this.txb_c);
            this.Controls.Add(this.txb_b);
            this.Controls.Add(this.txb_x2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Polinomio Segundo Grau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_x2;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.TextBox txb_c;
        private System.Windows.Forms.TextBox txb_Delta;
        private System.Windows.Forms.TextBox txb_x1;
        private System.Windows.Forms.TextBox txb_a;
    }
}

