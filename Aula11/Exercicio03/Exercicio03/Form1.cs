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

namespace Exercicio03
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Caixa.setCerveja(Convert.ToInt32(updownCerveja.Value));
            Caixa.setCoxinha(Convert.ToInt32(updownCoxinha.Value));
            Caixa.setRefrigerante(Convert.ToInt32(updownRefrigerante.Value));
            Caixa.setSopa(Convert.ToInt32(updownSopa.Value));

            updownCerveja.Value = 0;
            updownCoxinha.Value = 0;
            updownRefrigerante.Value = 0;
            updownSopa.Value = 0;

            Double total = Caixa.valorTotalCerveja + Caixa.valorTotalCoxinha + Caixa.valorTotalRefrigerante + Caixa.valorTotalSopa;
            txtAcumulado.Text = total.ToString();
        }

        private void updownRefrigerante_SelectedItemChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void updownCerveja_ValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void updownRefrigerante_ValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void calcularTotal()
        {
            Double subtotalCoxinha = Caixa.valorCoxinha * Convert.ToDouble(updownCoxinha.Value) ;

            Double subtotalSopa = Caixa.valorSopa * Convert.ToDouble(updownSopa.Value);

            Double subtotalCerveja = Caixa.valorCerveja * Convert.ToDouble(updownCerveja.Value);

            Double subtotalRefrigerante = Caixa.valorRefrigerante * Convert.ToDouble(updownRefrigerante.Value);

            txtTotal.Text = (subtotalCerveja + subtotalCoxinha + subtotalRefrigerante + subtotalSopa).ToString();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void updownSopa_ValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void updownCoxinha_ValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void txtAcumulado_TextChanged(object sender, EventArgs e)
        {
            Double total = Caixa.valorTotalCerveja + Caixa.valorTotalCoxinha + Caixa.valorTotalRefrigerante + Caixa.valorTotalSopa;
            txtAcumulado.Text = total.ToString();
        }

        private void btnEncerramento_Click(object sender, EventArgs e)
        {
            File.AppendAllText("c:\\alunos\\fechamento.txt", string.Format("{0}{1}", "Cerveja - Qtd: " + Caixa.totalCerveja + " - R$ " + Caixa.valorTotalCerveja, Environment.NewLine));
            File.AppendAllText("c:\\alunos\\fechamento.txt", string.Format("{0}{1}", "Refrigerante -  Qtd: " + Caixa.totalRefrigerante + " - R$ " + Caixa.valorTotalRefrigerante, Environment.NewLine));
            File.AppendAllText("c:\\alunos\\fechamento.txt", string.Format("{0}{1}", "Sopa -  Qtd: " + Caixa.totalSopa + " - R$ " + Caixa.valorTotalSopa, Environment.NewLine));
            File.AppendAllText("c:\\alunos\\fechamento.txt", string.Format("{0}{1}", "Coxinha -  Qtd: " + Caixa.totalCoxinha + " - R$ " + Caixa.valorTotalCoxinha, Environment.NewLine));

            MessageBox.Show("Fechamento concluido. Salvo em: c:\\alunos\\fechamento.txt");

            this.Close();
        }
    }
}
