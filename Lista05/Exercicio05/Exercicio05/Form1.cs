﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio05
{
    public partial class frmCriptografar : Form
    {
        public frmCriptografar()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            string preco, saida = " ", saida2 = " ";
            Int32 crip;
            preco = textBox1.Text;

            for (int i = 0; i < preco.Length; i++)
            {
                switch (preco[i])
                {
                    case '0': saida += 'P'; break;
                    case '1': saida += 'E'; break;
                    case '2': saida += 'R'; break;
                    case '3': saida += 'N'; break;
                    case '4': saida += 'A'; break;
                    case '5': saida += 'M'; break;
                    case '6': saida += 'B'; break;
                    case '7': saida += 'U'; break;
                    case '8': saida += 'C'; break;
                    case '9': saida += 'O'; break;
                }
            }

            MessageBox.Show(saida, "Conversor " + "Criptografia", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCriptografar_Load(object sender, EventArgs e)
        {

        }
    }
}
