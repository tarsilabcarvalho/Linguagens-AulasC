using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio03
{
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
            txtNome.Text = frmAbertura.usuario;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidacao_Click(object sender, EventArgs e)
        {
            if (frmAbertura.usuario == "ADM")
            {
                frmAbertura.usuario = "BIB";
                MessageBox.Show("Acessamos e trocamos os dados do usuário em outra classe", frmAbertura.usuario);
                txtNome.Text = frmAbertura.usuario;
            }
        }
    }
}
