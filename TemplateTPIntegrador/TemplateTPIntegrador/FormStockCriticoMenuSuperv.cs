using Negocio;
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
    public partial class FormStockCriticoMenuSuperv : Form
    {
        public FormMenuSupervisor FormMenuSupervisor;
        public FormStockCriticoMenuSuperv(FormMenuSupervisor formMenuSupervisor)
        {
            // Inicializa los componentes del formulario
            InitializeComponent();

            // Asigna el formulario principal al atributo local
            FormMenuSupervisor = formMenuSupervisor;

            // Crea una instancia de la clase ProductoNegocio
            ProductoNegocio productoNegocio = new ProductoNegocio();

            // Verifica si la lista de productos no es nula ni está vacía
            List<Producto> lista = productoNegocio.ListarProducto();
            if (lista == null || !lista.Any())
            {
                MessageBox.Show("No hay productos para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            List<Producto> listaStockCritico = lista.Where(x => x.stock <= 10)
                                                    .OrderBy(x => x.idCategoria)
                                                    .ToList();

            // Verifica si hay productos con stock crítico
            if (!listaStockCritico.Any())
            {
                MessageBox.Show("No hay productos con stock crítico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;


            }
            // Establece la fuente de datos del DataGridView para mostrar la lista de productos con stock crítico
            dgvListaProdStockCritico.DataSource = listaStockCritico;

            // Oculta las columnas que no son necesarias en el DataGridView
            dgvListaProdStockCritico.Columns["fechaBaja"].Visible = false;
            dgvListaProdStockCritico.Columns["idProveedor"].Visible = false;
            dgvListaProdStockCritico.Columns["idUsuario"].Visible = false;

        }




        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuSupervisor.AbrirFormulario(new FormReporteMenuSuperv(FormMenuSupervisor));
        }

        private void FormStockCriticoMenuSuperv_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuSupervisor.AbrirFormulario(new FormReporteMenuSuperv(FormMenuSupervisor));
        }
    }
}
