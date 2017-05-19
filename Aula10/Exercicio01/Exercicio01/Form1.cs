using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            try //validação da primeira variável
            {
                a = System.Convert.ToInt32(txtNumber1.Text);
            }
            catch
            {
                MessageBox.Show("Variável inválida, por favor tente novamente...");
                txtNumber1.SelectAll();
                txtNumber1.Focus();
                return;            }
            try //validação da segunda variável variável
            {
                b = System.Convert.ToInt32(txtNumber2.Text);
            }
            catch
            {
                MessageBox.Show("Variável inválida, por favor tente novamente...");
                txtNumber2.SelectAll();
                txtNumber2.Focus();
                return;            }
            soma = a + b;
            MessageBox.Show("soma = " + soma.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
