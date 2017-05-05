using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Classes_1
{
    public partial class frmClasse : Form
    {
        public frmClasse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa objpessoa = new Pessoa();

            objpessoa.Idade = Convert.ToInt32(txtIdade.Text);
            objpessoa.Nome = txtNome.Text;
            MessageBox.Show(objpessoa.VerificarIdade(), "Mensagem de Orientação");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClasse_Load(object sender, EventArgs e)
        {

        }
    }
}
