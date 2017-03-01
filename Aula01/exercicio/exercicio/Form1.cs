using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio
{
    public partial class formSegundos : Form
    {
        public formSegundos()
        {
            InitializeComponent();
        }

        private void txtSegundo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int segundos, horas, segs_restantes, minutos, seg_restantes_final;
            segundos = Convert.ToInt32(txtSegundo.Text);
            horas = segundos / 3600;
            segs_restantes = segundos % 3600;
            minutos = segs_restantes / 60;
            seg_restantes_final = segs_restantes % 60;
            MessageBox.Show("Resultado: " + horas + "h " + minutos + "min " + seg_restantes_final + "s");

        }
    }
}
