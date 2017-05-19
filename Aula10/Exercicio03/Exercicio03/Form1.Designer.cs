namespace Exercicio03
{
    partial class frmDividir
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
            this.lblNumerador = new System.Windows.Forms.Label();
            this.lblDenominador = new System.Windows.Forms.Label();
            this.txtNumerador = new System.Windows.Forms.TextBox();
            this.txtDenominador = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumerador
            // 
            this.lblNumerador.AutoSize = true;
            this.lblNumerador.Location = new System.Drawing.Point(30, 45);
            this.lblNumerador.Name = "lblNumerador";
            this.lblNumerador.Size = new System.Drawing.Size(62, 13);
            this.lblNumerador.TabIndex = 0;
            this.lblNumerador.Text = "Numerador:";
            this.lblNumerador.Click += new System.EventHandler(this.lblNumerador_Click);
            // 
            // lblDenominador
            // 
            this.lblDenominador.AutoSize = true;
            this.lblDenominador.Location = new System.Drawing.Point(33, 99);
            this.lblDenominador.Name = "lblDenominador";
            this.lblDenominador.Size = new System.Drawing.Size(73, 13);
            this.lblDenominador.TabIndex = 1;
            this.lblDenominador.Text = "Denominador:";
            // 
            // txtNumerador
            // 
            this.txtNumerador.Location = new System.Drawing.Point(112, 42);
            this.txtNumerador.Name = "txtNumerador";
            this.txtNumerador.Size = new System.Drawing.Size(100, 20);
            this.txtNumerador.TabIndex = 2;
            this.txtNumerador.TextChanged += new System.EventHandler(this.txtNumerador_TextChanged);
            // 
            // txtDenominador
            // 
            this.txtDenominador.Location = new System.Drawing.Point(112, 92);
            this.txtDenominador.Name = "txtDenominador";
            this.txtDenominador.Size = new System.Drawing.Size(100, 20);
            this.txtDenominador.TabIndex = 3;
            this.txtDenominador.TextChanged += new System.EventHandler(this.txtDenominador_TextChanged);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(36, 155);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(162, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmDividir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 203);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtDenominador);
            this.Controls.Add(this.txtNumerador);
            this.Controls.Add(this.lblDenominador);
            this.Controls.Add(this.lblNumerador);
            this.Name = "frmDividir";
            this.Text = "Divisão";
            this.Load += new System.EventHandler(this.frmDividir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerador;
        private System.Windows.Forms.Label lblDenominador;
        private System.Windows.Forms.TextBox txtNumerador;
        private System.Windows.Forms.TextBox txtDenominador;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textBox3;
    }
}

