namespace Exercicio02
{
    partial class frmLinguagens
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.optUnsorted = new System.Windows.Forms.RadioButton();
            this.optSorted = new System.Windows.Forms.RadioButton();
            this.btnForeach = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(58, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 147);
            this.lstOutput.TabIndex = 0;
            this.lstOutput.SelectedIndexChanged += new System.EventHandler(this.lstOutput_SelectedIndexChanged);
            // 
            // optUnsorted
            // 
            this.optUnsorted.AutoSize = true;
            this.optUnsorted.Location = new System.Drawing.Point(13, 186);
            this.optUnsorted.Name = "optUnsorted";
            this.optUnsorted.Size = new System.Drawing.Size(95, 17);
            this.optUnsorted.TabIndex = 1;
            this.optUnsorted.TabStop = true;
            this.optUnsorted.Text = "Não Ordenado";
            this.optUnsorted.UseVisualStyleBackColor = true;
            this.optUnsorted.CheckedChanged += new System.EventHandler(this.optUnsorted_CheckedChanged);
            // 
            // optSorted
            // 
            this.optSorted.AutoSize = true;
            this.optSorted.Location = new System.Drawing.Point(131, 186);
            this.optSorted.Name = "optSorted";
            this.optSorted.Size = new System.Drawing.Size(72, 17);
            this.optSorted.TabIndex = 2;
            this.optSorted.TabStop = true;
            this.optSorted.Text = "Ordenado";
            this.optSorted.UseVisualStyleBackColor = true;
            this.optSorted.CheckedChanged += new System.EventHandler(this.optSorted_CheckedChanged);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(239, 202);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(75, 23);
            this.btnForeach.TabIndex = 3;
            this.btnForeach.Text = "ForEach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 237);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmLinguagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 292);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.optSorted);
            this.Controls.Add(this.optUnsorted);
            this.Controls.Add(this.lstOutput);
            this.Name = "frmLinguagens";
            this.Text = "Linguagens";
            this.Load += new System.EventHandler(this.frmLinguagens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton optUnsorted;
        private System.Windows.Forms.RadioButton optSorted;
        private System.Windows.Forms.Button btnForeach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

