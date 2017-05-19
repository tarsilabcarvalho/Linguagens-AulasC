namespace Exercicio02
{
    partial class frmCalculaEnergia
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
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.lblWatt = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtWatt = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(28, 23);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(80, 13);
            this.lblSalarioMinimo.TabIndex = 0;
            this.lblSalarioMinimo.Text = "Salário Mínimo:";
            this.lblSalarioMinimo.Click += new System.EventHandler(this.lblSalarioMinimo_Click);
            // 
            // lblWatt
            // 
            this.lblWatt.AutoSize = true;
            this.lblWatt.Location = new System.Drawing.Point(28, 61);
            this.lblWatt.Name = "lblWatt";
            this.lblWatt.Size = new System.Drawing.Size(127, 13);
            this.lblWatt.TabIndex = 1;
            this.lblWatt.Text = "Quantidade de Quilowatt:";
            this.lblWatt.Click += new System.EventHandler(this.lblWatt_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(168, 20);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtWatt
            // 
            this.txtWatt.Location = new System.Drawing.Point(168, 53);
            this.txtWatt.Name = "txtWatt";
            this.txtWatt.Size = new System.Drawing.Size(100, 20);
            this.txtWatt.TabIndex = 3;
            this.txtWatt.TextChanged += new System.EventHandler(this.txtWatt_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(102, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(102, 155);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculaEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 190);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtWatt);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblWatt);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Name = "frmCalculaEnergia";
            this.Text = "Calculadora de Energia";
            this.Load += new System.EventHandler(this.frmCalculaEnergia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.Label lblWatt;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtWatt;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

