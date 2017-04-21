namespace Exercicio04
{
    partial class frmFrase
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(27, 23);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(98, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Forneça uma frase:";
            this.lblFrase.Click += new System.EventHandler(this.lblFrase_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(30, 40);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(100, 20);
            this.txtFrase.TabIndex = 1;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(30, 92);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(161, 13);
            this.lblLetra.TabIndex = 2;
            this.lblLetra.Text = "Forneça uma letra para procurar:";
            this.lblLetra.Click += new System.EventHandler(this.lblLetra_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(197, 92);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(34, 20);
            this.txtLetra.TabIndex = 3;
            this.txtLetra.TextChanged += new System.EventHandler(this.txtLetra_TextChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(106, 141);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // frmFrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 188);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "frmFrase";
            this.Text = "Buscador de Letra";
            this.Load += new System.EventHandler(this.frmFrase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnProcurar;
    }
}

