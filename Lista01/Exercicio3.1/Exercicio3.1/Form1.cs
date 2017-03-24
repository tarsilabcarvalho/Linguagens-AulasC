using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3._1
{
    public partial class frmExemplo : Form
    {
        public frmExemplo()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtInformacao.Text);
        }

        private void lblExemplo_Click(object sender, EventArgs e)
        {

        }

        private void txtInformacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExemplo_Load(object sender, EventArgs e)
        {

        }
    }
}
