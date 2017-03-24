using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1._1
{
    public partial class frmExemplo02 : Form
    {
        public frmExemplo02()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVermelho_Click(object sender, EventArgs e)
        {

        }

        private void radVermelho_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = true;
            lblAmarelo.Visible = false;
            lblVerde.Visible = false;

            lblVermelho.Text = "Pare!";
        }

        private void radAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = false;
            lblAmarelo.Visible = true;
            lblVerde.Visible = false;

            lblVermelho.Text = "Atenção!";
        }

        private void radVerde_CheckedChanged(object sender, EventArgs e)
        {
            lblVermelho.Visible = false;
            lblAmarelo.Visible = false;
            lblVerde.Visible = true;

            lblVermelho.Text = "Siga!";
        }

        private void lblAmarelo_Click(object sender, EventArgs e)
        {

        }

        private void lblVerde_Click(object sender, EventArgs e)
        {

        }
    }
}
