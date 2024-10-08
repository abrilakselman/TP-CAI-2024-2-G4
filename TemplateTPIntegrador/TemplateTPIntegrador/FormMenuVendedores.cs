﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FormMenuVendedores : Form
    {
        public FormMenuVendedores()
        {
            InitializeComponent();
        }
        //Abre los formularios dentro del panel de control en la pantalla de Menu vendedores

        public void AbrirFormulario(Form formulario)
        {
            if (this.panelMenuVendedores.Controls.Count > 0)
            {
                this.panelMenuVendedores.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelMenuVendedores.Controls.Add(formulario);
            panelMenuVendedores.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }
        private void btnReportesVendedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVentasPorVendedor(this));
        }
    }
}
