using System;
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
    public partial class FormVentasPorVendedor : Form
    {
        public FormVentasPorVendedor()
        {
            InitializeComponent();
        }

        public FormMenuVendedores FormMenuVendedores;
        public FormVentasPorVendedor(FormMenuVendedores formMenuVendedores)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuVendedores = formMenuVendedores;
        }


        private void FormVentasPorVendedor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
