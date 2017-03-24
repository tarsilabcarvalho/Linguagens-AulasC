using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnSomatoria_Click(object sender, EventArgs e)
        {
            int Resultado = 0;
            int Qtde;
            int x;

            Qtde = Convert.ToInt32(txtCalculo.Text);

            for (x = 0; x <= Qtde; x++)
            {
                Resultado += x;
            }

            MessageBox.Show(String.Format("O resultado é {0:00}", Resultado));
        }

        private void btnSomaImpar_Click(object sender, EventArgs e)
        {
            int Resultado = 0;
            int Qtde;
            int x;

            Qtde = Convert.ToInt32(txtCalculo.Text);

            for (x = 0; x <= Qtde; x++)
            {
                if ((x % 2) != 0) //modulo resultado da sobra da divisão
                    Resultado += x;
            }

            MessageBox.Show(String.Format("O resultado é {0:00}", Resultado));
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {

            int Qtde;
            int n;
            double fatorial;

            Qtde = Convert.ToInt32(txtCalculo.Text);

            for (n = 1, fatorial = 1; n <= Qtde; n++)
            {
                fatorial = fatorial * (n);
            }

            MessageBox.Show(String.Format("O resultado é {00:00}", fatorial));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
