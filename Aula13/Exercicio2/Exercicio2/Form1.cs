using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Exercicio2
{
    public partial class frmSQL : Form
    {
        public frmSQL()
        {
            InitializeComponent();
            //carregar o banco através dos passos da aula 12 de forma automática
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = c:\\intel\\Fatec.accdb";

            try
            {
                myConn.Open();
                OleDbCommand sql = new OleDbCommand(txtSQL.Text, myConn);
                OleDbDataAdapter da = new OleDbDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro de sintaxe SQL!");
            }
            myConn.Close();
        }

        private void frmSQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fatecDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.fatecDataSet.Alunos);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSQL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
