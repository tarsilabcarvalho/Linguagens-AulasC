namespace Exercicio3._1
{
    partial class frmExemplo
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
            this.lblExemplo = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(34, 26);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(127, 13);
            this.lblExemplo.TabIndex = 0;
            this.lblExemplo.Text = "Forneça uma informação:";
            this.lblExemplo.Click += new System.EventHandler(this.lblExemplo_Click);
            // 
            // txtInformacao
            // 
            this.txtInformacao.Location = new System.Drawing.Point(37, 42);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(256, 20);
            this.txtInformacao.TabIndex = 1;
            this.txtInformacao.TextChanged += new System.EventHandler(this.txtInformacao_TextChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(37, 75);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 128);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtInformacao);
            this.Controls.Add(this.lblExemplo);
            this.Name = "frmExemplo";
            this.Text = "Exemplo";
            this.Load += new System.EventHandler(this.frmExemplo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.TextBox txtInformacao;
        private System.Windows.Forms.Button btnExibir;
    }
}

