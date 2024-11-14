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
    public partial class FormReporteVenidoPorCategoria : Form
    {


        public FormMenuAdministrador FormMenuAdministrador;
        public FormReporteVenidoPorCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormReporteVenidoPorCategoria_Load(object sender, EventArgs e)
        {

        }

        private void buttonMjeAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormReportes(FormMenuAdministrador));
        }
    }
}
