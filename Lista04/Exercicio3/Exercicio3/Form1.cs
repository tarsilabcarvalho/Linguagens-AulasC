using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class frmPlaca : Form
    {
        public frmPlaca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int placa;

            placa = Convert.ToInt16(txtPlaca.Text);

            if (placa == 1 || placa == 2)
            {
                MessageBox.Show("Não pode trafegar às segundas-feiras!");
            }
            else if (placa == 3 || placa == 4)
            {
                MessageBox.Show("Não pode trafegar às terças-feiras!");
            }
            else if (placa == 5 || placa == 6)
            {
                MessageBox.Show("Não pode trafegar às quartas-feiras!");
            }
            else if (placa == 7 || placa == 8)
            {
                MessageBox.Show("Não pode trafegar às quintas-feiras!");
            }
            else if (placa == 9 || placa == 0)
            {
                MessageBox.Show("Não pode trafegar às sextas-feiras!");
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPlaca_Load(object sender, EventArgs e)
        {

        }
    }
}
