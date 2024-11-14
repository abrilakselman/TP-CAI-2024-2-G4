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
    public partial class FormReportes : Form
    {


        //para el menu de supervisor

        public FormMenuVendedores FormMenuVendedores;
        public FormReportes(FormMenuVendedores formMenuVendedores)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuVendedores = formMenuVendedores;
        }



        //para el menu de supervisor

        public FormMenuSupervisor FormMenuSupervisor;
        public FormReportes(FormMenuSupervisor formMenuSupervisor)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuSupervisor = formMenuSupervisor;
        }


        //para el menu de administrador
        public FormMenuAdministrador FormMenuAdministrador;
        public FormReportes(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuAdministrador = formMenuAdministrador;
        }

        private void btnVtasXVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentasPorVendedor formVentasPorVendedor = new FormVentasPorVendedor(FormMenuAdministrador);
            formVentasPorVendedor.ShowDialog();

        }

        private void btnStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormStockCritico(FormMenuAdministrador));
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnProdMasVendidoXCategoria_Click(object sender, EventArgs e)
        {
            
            FormReporteVenidoPorCategoria formReporteVenidoPorCategoria = new FormReporteVenidoPorCategoria();
            formReporteVenidoPorCategoria.ShowDialog();
        }
    }
}
