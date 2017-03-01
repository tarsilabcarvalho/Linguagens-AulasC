namespace exercicio
{
    partial class formSegundos
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
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(63, 64);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(175, 20);
            this.txtSegundo.TabIndex = 0;
            this.txtSegundo.TextChanged += new System.EventHandler(this.txtSegundo_TextChanged);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(84, 26);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(105, 13);
            this.lblSegundos.TabIndex = 1;
            this.lblSegundos.Text = "Informe os segundos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(114, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // formSegundos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(308, 180);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.txtSegundo);
            this.Name = "formSegundos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnCalcular;
    }
}

