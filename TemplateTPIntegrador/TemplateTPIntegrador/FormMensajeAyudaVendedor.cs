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
    public partial class FormMensajeAyudaVendedor : Form
    {
        public FormMensajeAyudaVendedor()
        {
            InitializeComponent();
        }

        private void buttonMjeAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuVendedores formMenuVendedores = new FormMenuVendedores();
            formMenuVendedores.ShowDialog();
        }
    }
}