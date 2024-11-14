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
    public partial class FormReporteMenuSuperv : Form
    {
        

   
        public FormMenuSupervisor FormMenuSupervisor;
        public FormReporteMenuSuperv(FormMenuSupervisor formMenuSupervisor)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuSupervisor = formMenuSupervisor;
        }

        private void btnVtasXVendedor_Click(object sender, EventArgs e)
        {
            

        }

        private void btnStockCritico_Click(object sender, EventArgs e)
        {
            
        }

        private void FormReporteMenuSuperv_Load(object sender, EventArgs e)
        {

        }

        private void btnStockCritico_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuSupervisor.AbrirFormulario(new FormStockCriticoMenuSuperv(FormMenuSupervisor));
        }

        private void btnVtasXVendedor_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormVentasPorVendedor formVentasPorVendedor = new FormVentasPorVendedor(FormMenuSupervisor);
            formVentasPorVendedor.ShowDialog();
        }

        private void btnProdMasVendidoXCategoria_Click(object sender, EventArgs e)
        {
            
            FormReporteVenidoPorCategoriaSupervisor formReporteVenidoPorCategoriaSupervisor = new FormReporteVenidoPorCategoriaSupervisor();
            formReporteVenidoPorCategoriaSupervisor.ShowDialog();
        }
    }
}
