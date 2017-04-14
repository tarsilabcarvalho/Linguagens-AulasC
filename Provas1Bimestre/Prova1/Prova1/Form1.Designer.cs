namespace Prova1
{
    partial class frmProva1
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
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.lblPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(31, 35);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(34, 13);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "Show";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(73, 35);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(205, 20);
            this.txtShow.TabIndex = 1;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // rdIdoso
            // 
            this.rdIdoso.AutoSize = true;
            this.rdIdoso.Location = new System.Drawing.Point(34, 80);
            this.rdIdoso.Name = "rdIdoso";
            this.rdIdoso.Size = new System.Drawing.Size(51, 17);
            this.rdIdoso.TabIndex = 2;
            this.rdIdoso.TabStop = true;
            this.rdIdoso.Text = "Idoso";
            this.rdIdoso.UseVisualStyleBackColor = true;
            this.rdIdoso.CheckedChanged += new System.EventHandler(this.rdIdoso_CheckedChanged);
            // 
            // rdEstudante
            // 
            this.rdEstudante.AutoSize = true;
            this.rdEstudante.Location = new System.Drawing.Point(34, 116);
            this.rdEstudante.Name = "rdEstudante";
            this.rdEstudante.Size = new System.Drawing.Size(73, 17);
            this.rdEstudante.TabIndex = 3;
            this.rdEstudante.TabStop = true;
            this.rdEstudante.Text = "Estudante";
            this.rdEstudante.UseVisualStyleBackColor = true;
            this.rdEstudante.CheckedChanged += new System.EventHandler(this.rdEstudante_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(96, 230);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(100, 20);
            this.txtPagar.TabIndex = 6;
            this.txtPagar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Location = new System.Drawing.Point(34, 230);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(61, 13);
            this.lblPagar.TabIndex = 7;
            this.lblPagar.Text = "a Pagar R$";
            this.lblPagar.Click += new System.EventHandler(this.lblPagar_Click);
            // 
            // frmProva1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdEstudante);
            this.Controls.Add(this.rdIdoso);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lblShow);
            this.Name = "frmProva1";
            this.Text = "Tarsila Bianca - Avaliação 1";
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
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label lblPagar;
    }
}

