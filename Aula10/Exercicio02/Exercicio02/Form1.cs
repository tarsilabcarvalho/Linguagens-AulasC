﻿using System;
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
            }
            {
                txtWatt.SelectAll();
                txtWatt.Focus();
                return;
            }
            {
                salariominimo = System.Convert.ToDouble(txtSalario.Text);
            }
            {
                txtSalario.SelectAll();
                txtSalario.Focus();
                return;
            }
            totaldesconto = Math.Round(totaldesconto, 2);

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