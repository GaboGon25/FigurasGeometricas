﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class FrmEsfera : Form
    {
        public FrmEsfera()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtRadioEsfera.Text;
            if (double.TryParse(input, out double RadioEsfera))
            {
                double radio = Convert.ToDouble(txtRadioEsfera.Text);
                Esfera esfera = new Esfera(radio);
                double resultadoArea = esfera.CalcularArea();
                double resultadoVolumen = esfera.CalcularVolumen();
                txtAreaEsfera.Text = resultadoArea.ToString("0.00");
                txtVolumenEsfera.Text = resultadoVolumen.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La entrada no es un valor numérico.");
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtRadioEsfera.Clear();
            txtAreaEsfera.Clear();
            txtVolumenEsfera.Clear();
            txtRadioEsfera.Focus();
        }
    }
}
