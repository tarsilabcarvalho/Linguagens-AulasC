namespace Exercicio01
{
    partial class frmMaquinas
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
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.txtMaquinas = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.AllowDrop = true;
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquinas.Location = new System.Drawing.Point(15, 32);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Size = new System.Drawing.Size(193, 15);
            this.lblMaquinas.TabIndex = 0;
            this.lblMaquinas.Text = "Insira o total de peças produzidas:";
            this.lblMaquinas.Click += new System.EventHandler(this.lblMaquinas_Click);
            // 
            // txtMaquinas
            // 
            this.txtMaquinas.Location = new System.Drawing.Point(214, 32);
            this.txtMaquinas.Name = "txtMaquinas";
            this.txtMaquinas.Size = new System.Drawing.Size(56, 21);
            this.txtMaquinas.TabIndex = 1;
            this.txtMaquinas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(105, 74);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(87, 27);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // frmMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtMaquinas);
            this.Controls.Add(this.lblMaquinas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMaquinas";
            this.Text = "Classificação das Máquinas";
            this.Load += new System.EventHandler(this.frmMaquinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.TextBox txtMaquinas;
        private System.Windows.Forms.Button btnResultado;
    }
}

