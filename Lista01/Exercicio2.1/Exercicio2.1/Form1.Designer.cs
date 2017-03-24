namespace Exercicio2._1
{
    partial class frmExercicio
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
            this.txtExercicio = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExercicio
            // 
            this.txtExercicio.Location = new System.Drawing.Point(69, 35);
            this.txtExercicio.Name = "txtExercicio";
            this.txtExercicio.Size = new System.Drawing.Size(231, 20);
            this.txtExercicio.TabIndex = 0;
            this.txtExercicio.TextChanged += new System.EventHandler(this.txtExercicio_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(166, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 135);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtExercicio);
            this.Name = "frmExercicio";
            this.Text = "Linguagens de Programação";
            this.Load += new System.EventHandler(this.frmExercicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExercicio;
        private System.Windows.Forms.Button btnOk;
    }
}

