namespace Exercicio1
{
    partial class frmTabuada
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
            this.lblTabuada = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCrescente1 = new System.Windows.Forms.Label();
            this.lblDecrescente1 = new System.Windows.Forms.Label();
            this.lblCrescente = new System.Windows.Forms.Label();
            this.lblDecrescente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Location = new System.Drawing.Point(13, 22);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(68, 13);
            this.lblTabuada.TabIndex = 0;
            this.lblTabuada.Text = "Tabuada do:";
            this.lblTabuada.Click += new System.EventHandler(this.lblTabuada_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(87, 19);
            this.txtNumero.MaxLength = 2;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(183, 19);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCrescente1
            // 
            this.lblCrescente1.AutoSize = true;
            this.lblCrescente1.Location = new System.Drawing.Point(12, 67);
            this.lblCrescente1.Name = "lblCrescente1";
            this.lblCrescente1.Size = new System.Drawing.Size(55, 13);
            this.lblCrescente1.TabIndex = 3;
            this.lblCrescente1.Text = "Crescente";
            this.lblCrescente1.Click += new System.EventHandler(this.lblCrescente1_Click);
            // 
            // lblDecrescente1
            // 
            this.lblDecrescente1.AutoSize = true;
            this.lblDecrescente1.Location = new System.Drawing.Point(130, 67);
            this.lblDecrescente1.Name = "lblDecrescente1";
            this.lblDecrescente1.Size = new System.Drawing.Size(68, 13);
            this.lblDecrescente1.TabIndex = 4;
            this.lblDecrescente1.Text = "Decrescente";
            this.lblDecrescente1.Click += new System.EventHandler(this.lblDecrescente1_Click);
            // 
            // lblCrescente
            // 
            this.lblCrescente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrescente.Location = new System.Drawing.Point(15, 102);
            this.lblCrescente.Name = "lblCrescente";
            this.lblCrescente.Size = new System.Drawing.Size(89, 151);
            this.lblCrescente.TabIndex = 5;
            this.lblCrescente.Click += new System.EventHandler(this.lblCrescente_Click);
            // 
            // lblDecrescente
            // 
            this.lblDecrescente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecrescente.Location = new System.Drawing.Point(133, 102);
            this.lblDecrescente.Name = "lblDecrescente";
            this.lblDecrescente.Size = new System.Drawing.Size(89, 151);
            this.lblDecrescente.TabIndex = 6;
            this.lblDecrescente.Click += new System.EventHandler(this.lblDecrescente_Click);
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 271);
            this.Controls.Add(this.lblDecrescente);
            this.Controls.Add(this.lblCrescente);
            this.Controls.Add(this.lblDecrescente1);
            this.Controls.Add(this.lblCrescente1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTabuada);
            this.Name = "frmTabuada";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCrescente1;
        private System.Windows.Forms.Label lblDecrescente1;
        private System.Windows.Forms.Label lblCrescente;
        private System.Windows.Forms.Label lblDecrescente;
    }
}

