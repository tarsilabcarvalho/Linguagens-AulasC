using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class frmLab : Form
    {
        public frmLab()
        {
            InitializeComponent();
        }

        private void rdSim_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoalergia.Visible = true;
            txtTipoAlergia.Visible = true;
        }

        private void rdNao_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoalergia.Visible = false;
            txtTipoAlergia.Visible = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("O código é obrigatório!");
            }
            else if (rdSim.Checked == true)
            {
                MessageBox.Show("Código: " + txtCodigo.Text + "\n" + "Tipo Sanguíneo: " + txtTipo.Text + "\n" + "É alérgico? Sim" + "\n" + "Tipo de Alergia: " + txtTipoAlergia.Text + "\n" + "Peso: " + txtPeso.Text);
            }
            else if (rdNao.Checked == true)
            {
                MessageBox.Show("Código: " + txtCodigo.Text + "\n" + "Tipo Sanguíneo: " + txtTipo.Text + "\n" + "É alérgico? Não" + "\n" + "Peso: " + txtPeso.Text);
            }
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLab_Load(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAlergico_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoalergia_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoAlergia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
