using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    //adicionar isso

namespace Exercicio1
{
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
           //combobox na setinha adiciona semestre

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source =c:\\intel\\Fatec.accdb";
            String RaAdd = txtRa.Text;
            String NomeAdd = txtNome.Text;
            String CursoAdd = txtCurso.Text;
            String SemestreAdd = cbSemestre.Text;
            String EmailAdd = txtEmail.Text;
            OleDbCommand cmdSql = new OleDbCommand("Insert into Alunos (NomeAl, CursoAl, SemestreAl, EmailAl) values (NomeAdd, CursoADD, SemestreAdd, EmailAdd)");
            cmdSql.Connection = conexao;
            conexao.Open();
            if (conexao.State == ConnectionState.Open)
            {
                cmdSql.Parameters.Add("NomeAdd", OleDbType.VarChar).Value = NomeAdd;
                cmdSql.Parameters.Add("CursoAdd", OleDbType.VarChar).Value = CursoAdd;
                cmdSql.Parameters.Add("SemestreAdd", OleDbType.VarChar).Value = SemestreAdd;
                cmdSql.Parameters.Add("EmailAdd", OleDbType.VarChar).Value = EmailAdd;
                try
                {
                    cmdSql.ExecuteNonQuery();
                    MessageBox.Show("Registro Incluido com sucesso!");
                    conexao.Close();
                }
                catch (OleDbException excecao)
                {
                    MessageBox.Show(excecao.Source);
                    conexao.Close();
                }
            }
            else
                MessageBox.Show("Falha na conexão com o banco de dados");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source =c:\\intel\\Fatec.accdb";
            DialogResult resp;
            resp = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand("DELETE from Alunos where Ra =" + txtRa.Text);
                cmd.Connection = conexao;
                conexao.Open();
                if (conexao.State == ConnectionState.Open)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro Excluído com Sucesso!");
                        conexao.Close();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Registro nao encontrado!" + ex.Source);
                        conexao.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Falha na Conexão com o Banco de dados");
                }
            }
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {

        }

        private void lblRa_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblCurso_Click(object sender, EventArgs e)
        {

        }

        private void lblSemestre_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtRa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
