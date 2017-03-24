using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._1
{
    public partial class frmExercicio : Form
    {
        public frmExercicio()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você digitou:" + txtExercicio.Text, "Prof. Fábio", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
        }

        private void txtExercicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExercicio_Load(object sender, EventArgs e)
        {

        }
    }
}
