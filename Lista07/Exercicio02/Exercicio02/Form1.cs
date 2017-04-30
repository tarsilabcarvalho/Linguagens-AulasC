using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class frmLinguagens : Form
    {

        string[] languages = {
                "Java",
                "Perl",
                "Pascal",
                "Pyton",
                "C#"
        }; //outra maneira de se criar um vetor
        string[] sortedLangs = new string[5]; //vetor ordenado
        private void showUnsorted() //método criado pelo usuário
        {
            //este método carrega o vetor na listbox
            lstOutput.Items.Clear(); //limpa a listbox
            lstOutput.Items.AddRange(languages); //carrega o vetor acima na listbox
        }

        private void showSorted() 
        {
            Array.Sort(sortedLangs);
            lstOutput.Items.Clear(); 
            lstOutput.Items.AddRange(sortedLangs); 
        }
        public frmLinguagens()
        {
            InitializeComponent();
        }

        private void frmLinguagens_Load(object sender, EventArgs e)
        {

        }

        private void optUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            btnForeach.Enabled = false;
            txtSearch.Enabled = false;
            showUnsorted();
        }

        private void optSorted_CheckedChanged(object sender, EventArgs e)
        {
            languages.CopyTo(sortedLangs, 0); //copia os elementos de um para outro
            Array.Sort(sortedLangs); //ordena um vetor
            btnForeach.Enabled = true;
            txtSearch.Enabled = true;
            showSorted();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int theIndex;
            string message;
            theIndex = Array.BinarySearch(sortedLangs, 0, sortedLangs.Length, txtSearch.Text);
            if (theIndex < 0)
            {
                message = "Não encontrado";
            }
            else
            {
                message = sortedLangs[theIndex];
                message += " está na posição ";
                message += theIndex.ToString();
            }
            MessageBox.Show(message);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach (string theLang in languages)
            {
                MessageBox.Show(theLang);
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
