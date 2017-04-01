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
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdMensal_CheckedChanged(object sender, EventArgs e)
        {
            lblMensal.Visible = true;
            lblHora.Visible = false;

            txtDias.Visible = true;
            txtHoras.Visible = false;
            
        }

        private void rdHora_CheckedChanged(object sender, EventArgs e)
        {
            lblMensal.Visible = false;
            lblHora.Visible = true;

            txtDias.Visible = false;
            txtHoras.Visible = true;

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double Salario, Horas, Dias, SalarioLiquido, SalarioBruto, INSS, IR;

            Salario = Convert.ToDouble(txtSalario.Text);
                       
            if (rdMensal.Checked == true)
            {
                Dias = Convert.ToDouble(txtDias.Text);

                if (Dias > 31)
                {
                    MessageBox.Show("Por gentileza, insira uma quantidade válida de dias trabalhados.");
                }

                else
                {
                        SalarioBruto = Salario/30 * Dias;

                        //Calculo INSS 
                        if (SalarioBruto > 1000)
                        {
                            INSS = SalarioBruto * 0.09;
                        }
                        else
                        {
                            INSS = SalarioBruto * 0.08;
                        }

                        //Calculo IR
                        if (SalarioBruto > 800)
                        {
                            IR = SalarioBruto * 0.10;
                        }
                        else
                        {
                            IR = 0;
                        }

                        SalarioLiquido = SalarioBruto - INSS - IR;

                        MessageBox.Show("Funcionário: " + txtNome.Text + "\n" + "Salário Bruto: R$ " + SalarioBruto.ToString() + "\n" + "INSS: R$ " + INSS.ToString() + "\n" + "IR: R$ " + IR.ToString() + "\n" + "Salário Líquido: R$ " + SalarioLiquido.ToString());

                    }
               
            } else if (rdHora.Checked == true)
            {
                Horas = Convert.ToDouble(txtHoras.Text);

                if (Horas > 240)
                {
                    MessageBox.Show("Por gentileza, insira uma quantidade válida de horas trabalhadas.");
                }
                else
                {
                    SalarioBruto = Salario * Horas;
                    
                    //Calculo INSS 
                    if (SalarioBruto > 1000)
                    {
                        INSS = SalarioBruto * 0.09;
                    }
                    else
                    {
                        INSS = SalarioBruto * 0.08;
                    }

                    //Calculo IR
                    if(SalarioBruto > 800)
                    {
                        IR = SalarioBruto * 0.10;
                    }
                    else
                    {
                        IR = 0;
                    }

                SalarioLiquido = SalarioBruto - INSS - IR;



                MessageBox.Show("Funcionário:" + txtNome.Text + "\n" + "Salário Bruto: R$ " + SalarioBruto.ToString() + "\n" + "INSS: R$ " + INSS.ToString() + "\n" + "IR: R$ " + IR.ToString() + "\n" + "Salário Líquido: R$ " + SalarioLiquido.ToString());
                }

            }

            
                  
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void frmSalario_Load(object sender, EventArgs e)
        {

        }

        private void lblTipoSalario_Click(object sender, EventArgs e)
        {

        }

        private void lblMensal_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
