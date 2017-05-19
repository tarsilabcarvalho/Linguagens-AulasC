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
    public partial class frmDividir : Form
    {
        public frmDividir()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            try
            {
                int numerador = Convert.ToInt32(txtNumerador.Text);
                int denominador = Convert.ToInt32(txtDenominador.Text);
                int resultado = numerador / denominador;
                textBox3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Você deve informar dois inteiros!", "Formato de número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Você não pode dividir por zero", "Divisão inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDividir_Load(object sender, EventArgs e)
        {

        }

        private void lblNumerador_Click(object sender, EventArgs e)
        {

        }

        private void txtNumerador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDenominador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
