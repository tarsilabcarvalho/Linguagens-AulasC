namespace Exercicio1
{
    partial class frmCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCalculo = new System.Windows.Forms.TextBox();
            this.btnSomatoria = new System.Windows.Forms.Button();
            this.btnSomaImpar = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalculo
            // 
            this.txtCalculo.Location = new System.Drawing.Point(62, 33);
            this.txtCalculo.Name = "txtCalculo";
            this.txtCalculo.Size = new System.Drawing.Size(131, 20);
            this.txtCalculo.TabIndex = 0;
            // 
            // btnSomatoria
            // 
            this.btnSomatoria.Location = new System.Drawing.Point(29, 76);
            this.btnSomatoria.Name = "btnSomatoria";
            this.btnSomatoria.Size = new System.Drawing.Size(90, 23);
            this.btnSomatoria.TabIndex = 1;
            this.btnSomatoria.Text = "Somatória";
            this.btnSomatoria.UseVisualStyleBackColor = true;
            this.btnSomatoria.Click += new System.EventHandler(this.btnSomatoria_Click);
            // 
            // btnSomaImpar
            // 
            this.btnSomaImpar.Location = new System.Drawing.Point(29, 105);
            this.btnSomaImpar.Name = "btnSomaImpar";
            this.btnSomaImpar.Size = new System.Drawing.Size(90, 23);
            this.btnSomaImpar.TabIndex = 2;
            this.btnSomaImpar.Text = "Soma Impares";
            this.btnSomaImpar.UseVisualStyleBackColor = true;
            this.btnSomaImpar.Click += new System.EventHandler(this.btnSomaImpar_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(29, 134);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(90, 23);
            this.btnFatorial.TabIndex = 3;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(141, 134);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 180);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnSomaImpar);
            this.Controls.Add(this.btnSomatoria);
            this.Controls.Add(this.txtCalculo);
            this.Name = "frmCalculo";
            this.Text = "Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalculo;
        private System.Windows.Forms.Button btnSomatoria;
        private System.Windows.Forms.Button btnSomaImpar;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnSair;
    }
}

