namespace Exercicio02
{
    partial class frmSalario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoSalario = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdMensal = new System.Windows.Forms.RadioButton();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rdHora = new System.Windows.Forms.RadioButton();
            this.lblMensal = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblTipoSalario
            // 
            this.lblTipoSalario.AutoSize = true;
            this.lblTipoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSalario.Location = new System.Drawing.Point(14, 70);
            this.lblTipoSalario.Name = "lblTipoSalario";
            this.lblTipoSalario.Size = new System.Drawing.Size(93, 15);
            this.lblTipoSalario.TabIndex = 1;
            this.lblTipoSalario.Text = "Tipo de Salário:";
            this.lblTipoSalario.Click += new System.EventHandler(this.lblTipoSalario_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(15, 203);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(49, 15);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(73, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 21);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // rdMensal
            // 
            this.rdMensal.AutoSize = true;
            this.rdMensal.Location = new System.Drawing.Point(38, 102);
            this.rdMensal.Name = "rdMensal";
            this.rdMensal.Size = new System.Drawing.Size(66, 19);
            this.rdMensal.TabIndex = 4;
            this.rdMensal.TabStop = true;
            this.rdMensal.Text = "Mensal";
            this.rdMensal.UseVisualStyleBackColor = true;
            this.rdMensal.CheckedChanged += new System.EventHandler(this.rdMensal_CheckedChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(79, 200);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(88, 21);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // rdHora
            // 
            this.rdHora.AutoSize = true;
            this.rdHora.Location = new System.Drawing.Point(38, 142);
            this.rdHora.Name = "rdHora";
            this.rdHora.Size = new System.Drawing.Size(52, 19);
            this.rdHora.TabIndex = 6;
            this.rdHora.TabStop = true;
            this.rdHora.Text = "Hora";
            this.rdHora.UseVisualStyleBackColor = true;
            this.rdHora.CheckedChanged += new System.EventHandler(this.rdHora_CheckedChanged);
            // 
            // lblMensal
            // 
            this.lblMensal.AutoSize = true;
            this.lblMensal.Location = new System.Drawing.Point(154, 102);
            this.lblMensal.Name = "lblMensal";
            this.lblMensal.Size = new System.Drawing.Size(107, 15);
            this.lblMensal.TabIndex = 7;
            this.lblMensal.Text = "Dias Trabalhados:";
            this.lblMensal.Click += new System.EventHandler(this.lblMensal_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(154, 144);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(115, 15);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Horas Trabalhadas:";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(276, 99);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(116, 21);
            this.txtDias.TabIndex = 9;
            this.txtDias.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(276, 141);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(116, 21);
            this.txtHoras.TabIndex = 10;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(276, 198);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 265);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblMensal);
            this.Controls.Add(this.rdHora);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.rdMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblTipoSalario);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSalario";
            this.Text = "Cálculo de Salário";
            this.Load += new System.EventHandler(this.frmSalario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipoSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdMensal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rdHora;
        private System.Windows.Forms.Label lblMensal;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnCalcular;
    }
}

