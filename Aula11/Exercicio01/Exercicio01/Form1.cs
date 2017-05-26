using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercicio01
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void frmFile_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("c:\\alunos\\pratica.txt");
            txtEdit.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("c:\\alunos\\pratica.txt");
            sw.Write(txtEdit.Text);
            sw.Close();
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
