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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random NumeroRandomico = new Random();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private Random numeroRandomico = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDado(pictureBox1);
        }
        public void DisplayDado(PictureBox Lado)
        {
            int face = NumeroRandomico.Next(1, 7);
            //vai completar com o numero
            Lado.Image = Image.FromFile("C:\Users\Aluno - Gti-Ads\Documents\Visual Studio 2015\Projects\Exercicio3\dados\\die" + face + ".gif");
        }
    }
}
