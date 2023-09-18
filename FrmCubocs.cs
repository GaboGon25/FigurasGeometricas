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
    public partial class FrmCubocs : Form
    {
        public FrmCubocs()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtLadoCubo.Text;
            if (double.TryParse(input, out double lado))
            {
                double ladoCubo = Convert.ToDouble(txtLadoCubo.Text);
                Cubo cubo = new Cubo(ladoCubo);
                double resultadoArea = cubo.CalcularArea();
                double resultadoVolumen = cubo.CalcularVolumen();
                txtAreaCubo.Text = resultadoArea.ToString("0.00");
                txtVolumenCubo.Text = resultadoVolumen.ToString("0.00");
            }
            else
            {
                MessageBox.Show("La entrada no es un valor numérico");
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtLadoCubo.Clear();
            txtAreaCubo.Clear();
            txtVolumenCubo.Clear();
            txtLadoCubo.Focus();
        }
    }
}
