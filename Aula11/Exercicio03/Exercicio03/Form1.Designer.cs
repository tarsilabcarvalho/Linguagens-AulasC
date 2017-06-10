namespace Exercicio03
{
    partial class frmCaixa
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRefrigerante = new System.Windows.Forms.Label();
            this.lblCerveja = new System.Windows.Forms.Label();
            this.lblCoxinha = new System.Windows.Forms.Label();
            this.lblSopa = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblAcumulado = new System.Windows.Forms.Label();
            this.txtAcumulado = new System.Windows.Forms.TextBox();
            this.btnEncerramento = new System.Windows.Forms.Button();
            this.updownCerveja = new System.Windows.Forms.NumericUpDown();
            this.updownRefrigerante = new System.Windows.Forms.NumericUpDown();
            this.updownCoxinha = new System.Windows.Forms.NumericUpDown();
            this.updownSopa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updownCerveja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRefrigerante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownCoxinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSopa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Controle de Caixa - Festa FATEC";
            // 
            // lblRefrigerante
            // 
            this.lblRefrigerante.AutoSize = true;
            this.lblRefrigerante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrigerante.Location = new System.Drawing.Point(80, 56);
            this.lblRefrigerante.Name = "lblRefrigerante";
            this.lblRefrigerante.Size = new System.Drawing.Size(82, 16);
            this.lblRefrigerante.TabIndex = 5;
            this.lblRefrigerante.Text = "Refrigerante";
            // 
            // lblCerveja
            // 
            this.lblCerveja.AutoSize = true;
            this.lblCerveja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerveja.Location = new System.Drawing.Point(80, 83);
            this.lblCerveja.Name = "lblCerveja";
            this.lblCerveja.Size = new System.Drawing.Size(55, 16);
            this.lblCerveja.TabIndex = 6;
            this.lblCerveja.Text = "Cerveja";
            // 
            // lblCoxinha
            // 
            this.lblCoxinha.AutoSize = true;
            this.lblCoxinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoxinha.Location = new System.Drawing.Point(80, 148);
            this.lblCoxinha.Name = "lblCoxinha";
            this.lblCoxinha.Size = new System.Drawing.Size(56, 16);
            this.lblCoxinha.TabIndex = 7;
            this.lblCoxinha.Text = "Coxinha";
            // 
            // lblSopa
            // 
            this.lblSopa.AutoSize = true;
            this.lblSopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSopa.Location = new System.Drawing.Point(80, 178);
            this.lblSopa.Name = "lblSopa";
            this.lblSopa.Size = new System.Drawing.Size(41, 16);
            this.lblSopa.TabIndex = 8;
            this.lblSopa.Text = "Sopa";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(199, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(265, 53);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(58, 26);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(248, 109);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(13, 217);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(325, 13);
            this.lblLinha.TabIndex = 12;
            this.lblLinha.Text = "---------------------------------------------------------------------------------" +
    "-------------------------";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(3, 230);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(107, 16);
            this.lblOperador.TabIndex = 13;
            this.lblOperador.Text = "Operador: Fábio";
            // 
            // lblAcumulado
            // 
            this.lblAcumulado.AutoSize = true;
            this.lblAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumulado.Location = new System.Drawing.Point(3, 262);
            this.lblAcumulado.Name = "lblAcumulado";
            this.lblAcumulado.Size = new System.Drawing.Size(76, 16);
            this.lblAcumulado.TabIndex = 14;
            this.lblAcumulado.Text = "Acumulado";
            // 
            // txtAcumulado
            // 
            this.txtAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcumulado.Location = new System.Drawing.Point(86, 255);
            this.txtAcumulado.Name = "txtAcumulado";
            this.txtAcumulado.Size = new System.Drawing.Size(35, 22);
            this.txtAcumulado.TabIndex = 15;
            this.txtAcumulado.TextChanged += new System.EventHandler(this.txtAcumulado_TextChanged);
            // 
            // btnEncerramento
            // 
            this.btnEncerramento.Location = new System.Drawing.Point(248, 254);
            this.btnEncerramento.Name = "btnEncerramento";
            this.btnEncerramento.Size = new System.Drawing.Size(90, 23);
            this.btnEncerramento.TabIndex = 16;
            this.btnEncerramento.Text = "Encerramento";
            this.btnEncerramento.UseVisualStyleBackColor = true;
            this.btnEncerramento.Click += new System.EventHandler(this.btnEncerramento_Click);
            // 
            // updownCerveja
            // 
            this.updownCerveja.Location = new System.Drawing.Point(22, 83);
            this.updownCerveja.Name = "updownCerveja";
            this.updownCerveja.Size = new System.Drawing.Size(52, 20);
            this.updownCerveja.TabIndex = 17;
            this.updownCerveja.ValueChanged += new System.EventHandler(this.updownCerveja_ValueChanged);
            // 
            // updownRefrigerante
            // 
            this.updownRefrigerante.Location = new System.Drawing.Point(22, 53);
            this.updownRefrigerante.Name = "updownRefrigerante";
            this.updownRefrigerante.Size = new System.Drawing.Size(52, 20);
            this.updownRefrigerante.TabIndex = 18;
            this.updownRefrigerante.ValueChanged += new System.EventHandler(this.updownRefrigerante_ValueChanged);
            // 
            // updownCoxinha
            // 
            this.updownCoxinha.Location = new System.Drawing.Point(22, 148);
            this.updownCoxinha.Name = "updownCoxinha";
            this.updownCoxinha.Size = new System.Drawing.Size(52, 20);
            this.updownCoxinha.TabIndex = 19;
            this.updownCoxinha.ValueChanged += new System.EventHandler(this.updownCoxinha_ValueChanged);
            // 
            // updownSopa
            // 
            this.updownSopa.Location = new System.Drawing.Point(22, 178);
            this.updownSopa.Name = "updownSopa";
            this.updownSopa.Size = new System.Drawing.Size(52, 20);
            this.updownSopa.TabIndex = 20;
            this.updownSopa.ValueChanged += new System.EventHandler(this.updownSopa_ValueChanged);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 287);
            this.Controls.Add(this.updownSopa);
            this.Controls.Add(this.updownCoxinha);
            this.Controls.Add(this.updownRefrigerante);
            this.Controls.Add(this.updownCerveja);
            this.Controls.Add(this.btnEncerramento);
            this.Controls.Add(this.txtAcumulado);
            this.Controls.Add(this.lblAcumulado);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSopa);
            this.Controls.Add(this.lblCoxinha);
            this.Controls.Add(this.lblCerveja);
            this.Controls.Add(this.lblRefrigerante);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCaixa";
            this.Text = "LP - Prof. Fabio de P. Santos";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownCerveja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownRefrigerante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownCoxinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSopa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRefrigerante;
        private System.Windows.Forms.Label lblCerveja;
        private System.Windows.Forms.Label lblCoxinha;
        private System.Windows.Forms.Label lblSopa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblAcumulado;
        private System.Windows.Forms.TextBox txtAcumulado;
        private System.Windows.Forms.Button btnEncerramento;
        private System.Windows.Forms.NumericUpDown updownCerveja;
        private System.Windows.Forms.NumericUpDown updownRefrigerante;
        private System.Windows.Forms.NumericUpDown updownCoxinha;
        private System.Windows.Forms.NumericUpDown updownSopa;
    }
}

