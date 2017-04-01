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
    public partial class frmMaquinas : Form
    {
        public frmMaquinas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            int Qtdade;

            Qtdade = Convert.ToInt32(txtMaquinas.Text);


            if (Qtdade >= 60000)
            {
                MessageBox.Show("Boa");
            }

            else if (Qtdade > 40000 && Qtdade < 60000)
            {
                MessageBox.Show("Regular");
            }

            else
            {
                MessageBox.Show("Ruim");
            }
        }

        private void frmMaquinas_Load(object sender, EventArgs e)
        {

        }

        private void lblMaquinas_Click(object sender, EventArgs e)
        {

        }
    }
}
