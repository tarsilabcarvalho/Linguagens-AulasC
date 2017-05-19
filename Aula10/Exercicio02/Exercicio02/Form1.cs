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
    public partial class frmCalculaEnergia : Form
    {
        public frmCalculaEnergia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double watt, valorwatt, salariominimo, totalresidencia, totaldesconto;

            try
            {
                watt = System.Convert.ToDouble(txtWatt.Text);
            }            catch
            {                MessageBox.Show("Valor inválido, por favor tente novamente!");
                txtWatt.SelectAll();
                txtWatt.Focus();
                return;
            }            try
            {
                salariominimo = System.Convert.ToDouble(txtSalario.Text);
            }            catch
            {                MessageBox.Show("Valor inválido, por favor tente novamente!");
                txtSalario.SelectAll();
                txtSalario.Focus();
                return;
            }            valorwatt = (salariominimo / 7) / 100;            valorwatt = Math.Round(valorwatt, 2);            totalresidencia = valorwatt * watt;            totalresidencia = Math.Round(totalresidencia, 2);            totaldesconto = totalresidencia - (totalresidencia * 0.10);
            totaldesconto = Math.Round(totaldesconto, 2);            MessageBox.Show("Valor de cada Quilowatt = R$ " + valorwatt.ToString() + "\n" + "Valor Total: R$ " + totalresidencia.ToString() + "\n" + "Valor com desconto: R$ " + totaldesconto.ToString());        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculaEnergia_Load(object sender, EventArgs e)
        {

        }

        private void lblSalarioMinimo_Click(object sender, EventArgs e)
        {

        }

        private void lblWatt_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWatt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
