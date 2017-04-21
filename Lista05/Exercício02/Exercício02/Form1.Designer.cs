namespace Exercício02
{
    partial class Form1
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
            this.String = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // String
            // 
            this.String.Location = new System.Drawing.Point(74, 43);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(156, 23);
            this.String.TabIndex = 0;
            this.String.Text = "Carregador de String";
            this.String.UseVisualStyleBackColor = true;
            this.String.Click += new System.EventHandler(this.String_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 103);
            this.Controls.Add(this.String);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button String;
    }
}

