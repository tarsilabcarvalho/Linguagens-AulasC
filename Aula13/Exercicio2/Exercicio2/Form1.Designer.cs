namespace Exercicio2
{
    partial class frmSQL
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
            this.components = new System.ComponentModel.Container();
            this.lblSQL = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fatecDataSet = new Exercicio2.FatecDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new Exercicio2.FatecDataSetTableAdapters.AlunosTableAdapter();
            this.rADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoAlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreAlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQL.Location = new System.Drawing.Point(22, 13);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(146, 16);
            this.lblSQL.TabIndex = 0;
            this.lblSQL.Text = "Digite o comando SQL:";
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(12, 32);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(542, 66);
            this.txtSQL.TabIndex = 1;
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(12, 104);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(542, 23);
            this.btnSQL.TabIndex = 2;
            this.btnSQL.Text = "Executar Query";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rADataGridViewTextBoxColumn,
            this.nomeAlDataGridViewTextBoxColumn,
            this.cursoAlDataGridViewTextBoxColumn,
            this.semestreAlDataGridViewTextBoxColumn,
            this.emailAlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 166);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fatecDataSet
            // 
            this.fatecDataSet.DataSetName = "FatecDataSet";
            this.fatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.fatecDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // rADataGridViewTextBoxColumn
            // 
            this.rADataGridViewTextBoxColumn.DataPropertyName = "RA";
            this.rADataGridViewTextBoxColumn.HeaderText = "RA";
            this.rADataGridViewTextBoxColumn.Name = "rADataGridViewTextBoxColumn";
            // 
            // nomeAlDataGridViewTextBoxColumn
            // 
            this.nomeAlDataGridViewTextBoxColumn.DataPropertyName = "NomeAl";
            this.nomeAlDataGridViewTextBoxColumn.HeaderText = "NomeAl";
            this.nomeAlDataGridViewTextBoxColumn.Name = "nomeAlDataGridViewTextBoxColumn";
            // 
            // cursoAlDataGridViewTextBoxColumn
            // 
            this.cursoAlDataGridViewTextBoxColumn.DataPropertyName = "CursoAl";
            this.cursoAlDataGridViewTextBoxColumn.HeaderText = "CursoAl";
            this.cursoAlDataGridViewTextBoxColumn.Name = "cursoAlDataGridViewTextBoxColumn";
            // 
            // semestreAlDataGridViewTextBoxColumn
            // 
            this.semestreAlDataGridViewTextBoxColumn.DataPropertyName = "SemestreAl";
            this.semestreAlDataGridViewTextBoxColumn.HeaderText = "SemestreAl";
            this.semestreAlDataGridViewTextBoxColumn.Name = "semestreAlDataGridViewTextBoxColumn";
            // 
            // emailAlDataGridViewTextBoxColumn
            // 
            this.emailAlDataGridViewTextBoxColumn.DataPropertyName = "EmailAl";
            this.emailAlDataGridViewTextBoxColumn.HeaderText = "EmailAl";
            this.emailAlDataGridViewTextBoxColumn.Name = "emailAlDataGridViewTextBoxColumn";
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.lblSQL);
            this.Name = "frmSQL";
            this.Text = "Visualizador SQL";
            this.Load += new System.EventHandler(this.frmSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FatecDataSet fatecDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private FatecDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoAlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreAlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAlDataGridViewTextBoxColumn;
    }
}

