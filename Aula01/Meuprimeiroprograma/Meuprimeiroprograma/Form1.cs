using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meuprimeiroprograma
{
    public partial class lblForm : Form
    {
        public lblForm()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtEntrada.Text, "primeira aula"); //primeiro o que vai aparecer, segundo o título
        }
    }
}
