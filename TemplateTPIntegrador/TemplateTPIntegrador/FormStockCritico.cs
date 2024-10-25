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
    public partial class FormStockCritico : Form
    {

        public FormMenuAdministrador FormMenuAdministrador;
        public FormStockCritico(FormMenuAdministrador formMenuAdministrador)
        {
            // Inicializa los componentes del formulario
            InitializeComponent();

            // Asigna el formulario principal al atributo local
            FormMenuAdministrador = formMenuAdministrador;

            // Crea una instancia de la clase ProductoNegocio
            ProductoNegocio productoNegocio = new ProductoNegocio();

            // Verifica si la lista de productos no es nula ni está vacía
            List<Producto> lista = productoNegocio.ListarProducto();
            if (lista == null || !lista.Any())
            {
                MessageBox.Show("No hay productos para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /* Filtra la lista para obtener productos con stock menor al 25% de su capacidad máxima y los ordena por id de categoría
            List<Producto> listaStockCritico = lista.Where(x => x.stock < x.capacidadMaxima * 0.25)
                                                    .OrderBy(x => x.idCategoria)
                                                    .ToList();
           
            // Verifica si hay productos con stock crítico
            if (!listaStockCritico.Any())
            {
                MessageBox.Show("No hay productos con stock crítico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } */


            //IMPORTANTE:
            //Pero como no se tiene como dato la capacidad maxima de cada producto.
            //se toma como SUPUESTO que el maximo es 10 para stock critico

            // Filtra la lista para obtener productos con stock crítico (<= 10) y los ordena por id de categoría
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
            FormMenuAdministrador.AbrirFormulario(new FormReportes(FormMenuAdministrador));
        }
    }
}
