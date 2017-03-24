using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class RollDie : Form
    {
        public RollDie()
        {
            InitializeComponent();
        }

        private Random NumeroRandomico = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Random numeroRandomico = new Random();

        public void DisplayDado(PictureBox Lado)
        {
            int face = NumeroRandomico.Next(1, 7);
            
            Lado.Image = Image.FromFile("C:\\Users\\Aluno - Gti-Ads\\Documents\\Visual Studio 2015\\Projects\\Exercicio4\\dados\\die" + face + ".gif");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayDado(pictureBox1);
            DisplayDado(pictureBox2);
            DisplayDado(pictureBox3);
            DisplayDado(pictureBox4);
        }
    }
}
