namespace Prova
{
    partial class frmProva
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
            this.lblShow = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.rdIdoso = new System.Windows.Forms.RadioButton();
            this.rdEstudante = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPagar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(32, 37);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(38, 15);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "Show";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(76, 37);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(258, 21);
            this.txtShow.TabIndex = 1;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // rdIdoso
            // 
            this.rdIdoso.AutoSize = true;
            this.rdIdoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIdoso.Location = new System.Drawing.Point(35, 80);
            this.rdIdoso.Name = "rdIdoso";
            this.rdIdoso.Size = new System.Drawing.Size(55, 19);
            this.rdIdoso.TabIndex = 2;
            this.rdIdoso.TabStop = true;
            this.rdIdoso.Text = "Idoso";
            this.rdIdoso.UseVisualStyleBackColor = true;
            this.rdIdoso.CheckedChanged += new System.EventHandler(this.rdIdoso_CheckedChanged);
            // 
            // rdEstudante
            // 
            this.rdEstudante.AutoSize = true;
            this.rdEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEstudante.Location = new System.Drawing.Point(35, 125);
            this.rdEstudante.Name = "rdEstudante";
            this.rdEstudante.Size = new System.Drawing.Size(80, 19);
            this.rdEstudante.TabIndex = 3;
            this.rdEstudante.TabStop = true;
            this.rdEstudante.Text = "Estudante";
            this.rdEstudante.UseVisualStyleBackColor = true;
            this.rdEstudante.CheckedChanged += new System.EventHandler(this.rdEstudante_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(35, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(246, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.Location = new System.Drawing.Point(32, 246);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(68, 15);
            this.lblPagar.TabIndex = 6;
            this.lblPagar.Text = "a pagar R$";
            this.lblPagar.Click += new System.EventHandler(this.lblPagar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(106, 245);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 21);
            this.txtValor.TabIndex = 7;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmProva
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 285);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdEstudante);
            this.Controls.Add(this.rdIdoso);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lblShow);
            this.Name = "frmProva";
            this.Text = "Tarsila Bianca D. de Carvalho - Avaliação 2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.RadioButton rdIdoso;
        private System.Windows.Forms.RadioButton rdEstudante;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.TextBox txtValor;
    }
}

