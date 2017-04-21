using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04
{
    public partial class frmFrase : Form
    {
        public frmFrase()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            int i, qtd;
            string aux;

            aux = txtFrase.Text;
            aux = aux.ToUpper();

            for (i = 0, qtd = 0; i < aux.Length; i++)
                if (aux.Substring(i, 1) == txtLetra.Text.ToUpper())
                    qtd++;

                MessageBox.Show("A letra aparece " + Convert.ToString(qtd) + " vezes.");
            

        }

        private void lblFrase_Click(object sender, EventArgs e)
        {

        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFrase_Load(object sender, EventArgs e)
        {

        }

        private void lblLetra_Click(object sender, EventArgs e)
        {

        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
