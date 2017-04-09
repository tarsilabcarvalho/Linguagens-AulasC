using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtShow.Text = "";
            txtValor.Text = "";
            rdEstudante.Checked = false;
            rdIdoso.Checked = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (rdIdoso.Checked == true)
            {
                txtValor.Text = "60.00";

                MessageBox.Show("Possui acompanhante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

            else if (rdEstudante.Checked == true)
            {
                txtValor.Text = "50.00";

                MessageBox.Show("Possui carteirinha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            else if (rdEstudante.Checked == false && rdIdoso.Checked == false)
            {
                txtValor.Text = "100.00";
            }

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdIdoso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdEstudante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
