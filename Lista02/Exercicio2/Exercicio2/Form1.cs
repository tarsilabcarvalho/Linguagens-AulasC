using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {

        int counter = 0; 
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 13)
            {
                counter = 0;
            }

            PictureBox1.Image = myPics.Images[counter];
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
