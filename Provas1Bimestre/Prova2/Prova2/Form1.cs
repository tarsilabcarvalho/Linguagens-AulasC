using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class frmProva2 : Form
    {
        public frmProva2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "1780781413033")
            {
                MessageBox.Show("Bem Vindo ao Portal!!");
                pictureBox1.ImageLocation = ("C:\\Users\\Aluno - Gti-Ads\\Documents\\Visual Studio 2015\\Projects\\Prova2\\tarsila.png");
            }
            else
            {
                MessageBox.Show("Acesso negado!");
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblInforme_Click(object sender, EventArgs e)
        {

        }
    }
}
