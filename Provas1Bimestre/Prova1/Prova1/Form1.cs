using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1
{
    public partial class frmProva1 : Form
    {
        public frmProva1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtShow.Text = "";
            txtPagar.Text = "";
            rdEstudante.Checked = false;
            rdIdoso.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (rdIdoso.Checked == true)
            {
                txtPagar.Text = "60.00";

                MessageBox.Show("Possui acompanhante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

            else if (rdEstudante.Checked == true)
            {
                txtPagar.Text = "50.00";

                MessageBox.Show("Possui carteirinha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            else if (rdEstudante.Checked == false && rdIdoso.Checked == false)
            {
                txtPagar.Text = "100.00";
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
