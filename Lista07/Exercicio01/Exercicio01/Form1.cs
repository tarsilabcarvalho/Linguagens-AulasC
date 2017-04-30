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
    public partial class frmContador : Form
    {
        private int counter; //índice do vetor
        private string[] numbers = new String[5]; //aloca posições de memória para uma vetor
              
            
        public frmContador()
        {
            InitializeComponent();

             numbers[0] = "zero"; //inicialização do vetor
             numbers[1] = "um";
             numbers[2] = "dois";
             numbers[3] = "três";
             numbers[4] = "quatro";

            lblOutput.Text = numbers[0];
        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter > 4)
            {
                counter = 0;
            }

            lblOutput.Text = numbers[counter];
            counter++;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
