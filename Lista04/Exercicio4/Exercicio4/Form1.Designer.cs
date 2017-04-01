namespace Exercicio4
{
    partial class frmLab
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAlergico = new System.Windows.Forms.Label();
            this.lblTipoalergia = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTipoAlergia = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rdSim = new System.Windows.Forms.RadioButton();
            this.rdNao = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(25, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(24, 69);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(124, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo Sanguíneo:";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // lblAlergico
            // 
            this.lblAlergico.AutoSize = true;
            this.lblAlergico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergico.Location = new System.Drawing.Point(26, 112);
            this.lblAlergico.Name = "lblAlergico";
            this.lblAlergico.Size = new System.Drawing.Size(88, 20);
            this.lblAlergico.TabIndex = 2;
            this.lblAlergico.Text = "É alérgico?";
            this.lblAlergico.Click += new System.EventHandler(this.lblAlergico_Click);
            // 
            // lblTipoalergia
            // 
            this.lblTipoalergia.AutoSize = true;
            this.lblTipoalergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoalergia.Location = new System.Drawing.Point(382, 115);
            this.lblTipoalergia.Name = "lblTipoalergia";
            this.lblTipoalergia.Size = new System.Drawing.Size(118, 20);
            this.lblTipoalergia.TabIndex = 3;
            this.lblTipoalergia.Text = "Tipo de Alergia:";
            this.lblTipoalergia.Click += new System.EventHandler(this.lblTipoalergia_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(27, 163);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(155, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(155, 69);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 26);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtTipoAlergia
            // 
            this.txtTipoAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAlergia.Location = new System.Drawing.Point(506, 117);
            this.txtTipoAlergia.Name = "txtTipoAlergia";
            this.txtTipoAlergia.Size = new System.Drawing.Size(100, 26);
            this.txtTipoAlergia.TabIndex = 8;
            this.txtTipoAlergia.TextChanged += new System.EventHandler(this.txtTipoAlergia_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(155, 163);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 9;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // rdSim
            // 
            this.rdSim.AutoSize = true;
            this.rdSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSim.Location = new System.Drawing.Point(155, 115);
            this.rdSim.Name = "rdSim";
            this.rdSim.Size = new System.Drawing.Size(54, 24);
            this.rdSim.TabIndex = 10;
            this.rdSim.TabStop = true;
            this.rdSim.Text = "Sim";
            this.rdSim.UseVisualStyleBackColor = true;
            this.rdSim.CheckedChanged += new System.EventHandler(this.rdSim_CheckedChanged);
            // 
            // rdNao
            // 
            this.rdNao.AutoSize = true;
            this.rdNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNao.Location = new System.Drawing.Point(250, 115);
            this.rdNao.Name = "rdNao";
            this.rdNao.Size = new System.Drawing.Size(56, 24);
            this.rdNao.TabIndex = 11;
            this.rdNao.TabStop = true;
            this.rdNao.Text = "Não";
            this.rdNao.UseVisualStyleBackColor = true;
            this.rdNao.CheckedChanged += new System.EventHandler(this.rdNao_CheckedChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(454, 163);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(80, 26);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 223);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.rdNao);
            this.Controls.Add(this.rdSim);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtTipoAlergia);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTipoalergia);
            this.Controls.Add(this.lblAlergico);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmLab";
            this.Text = "Seleção de Doadores";
            this.Load += new System.EventHandler(this.frmLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAlergico;
        private System.Windows.Forms.Label lblTipoalergia;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTipoAlergia;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rdSim;
        private System.Windows.Forms.RadioButton rdNao;
        private System.Windows.Forms.Button btnGravar;
    }
}

