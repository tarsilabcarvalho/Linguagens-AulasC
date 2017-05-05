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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //** tornar padrão, imagens JPEG
            this.radJPEG.Checked = true;
            //** Configurar a pasta padrão para apontar para o Desktop e configurar a mensagem
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            this.folderBrowserDialog1.Description = "Por favor encontre a pasta que contém as figuras que deseja visualizar...";

            //** inicializa o relógio na barra de status
            this.sbarClockLabel.Text =
            System.DateTime.Now.ToString("hh:mm tt, MM-dd-yyyy");
            //** atualiza o tempo a cada 30s
            this.timer1.Interval = 30000;
            this.timer1.Enabled = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //** Exibe a caixa de diálogo, mas não retorna nada até que o usuário clique em ok/cancel...
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder, pattern, filename, pathname;
                //** captura a escolha
                folder = this.folderBrowserDialog1.SelectedPath;

                Globals.CurrentPictureFolder = folder;

                //** qual o tipo do arquivo? .jpg, .bmp, ?
                if (this.radJPEG.Checked == true)
                    pattern = "*.jpg";
                else if (this.radBMP.Checked == true)
                    pattern = "*.bmp";
                else
                    pattern = "*.*";
                //** lê o conteúdo da pasta conforme o padrão...
                string[] files = null;
                files = System.IO.Directory.GetFiles(folder, pattern);
                //** limpa a listbox e carrega os nomes dos arquivos!
                this.listFileNames.Items.Clear();
                foreach (string pathname_loopVariable in files)
                {
                    pathname = pathname_loopVariable;
                    filename = System.IO.Path.GetFileName(pathname);
                    this.listFileNames.Items.Add(filename);
                }
            }
        }

        private void listFileNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filename = null;
            string folder = null;
            string pathname = null;

            filename = this.listFileNames.SelectedItem.ToString();
            folder = Globals.CurrentPictureFolder;
            pathname = System.IO.Path.Combine(folder, filename);
            this.picImage.Image = System.Drawing.Image.FromFile(pathname);
            this.sbarFolderLabel.Text = pathname;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.sbarClockLabel.Text = System.DateTime.Now.ToString("hh:mm tt, MM-dd-yyyy");
        }

        private void sbarFolderLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radJPEG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radBMP_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
