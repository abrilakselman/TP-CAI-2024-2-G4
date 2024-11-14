using Datos;
using Negocio;
using Persistencia;
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
    public partial class FormListoProductoMenuSuper : Form
    {
        //Objetivo es listar los productos por CATEGORIA

        public FormMenuSupervisor FormMenuSupervisor;
        public string Producto { get; set; }

        public FormListoProductoMenuSuper(FormMenuSupervisor formMenuSupervisor)
        {
            InitializeComponent();
            CargarListaProductoDVG();
            FormMenuSupervisor = formMenuSupervisor;
            InicializarComboBox();

        }

        private void InicializarComboBox()
        {
            List<productosLista> listacat = new List<productosLista>();  //de la entidad productosLista
            listacat.Add(new productosLista("0", "Todas"));
            listacat.Add(new productosLista("1", "Audio"));
            listacat.Add(new productosLista("2", "Celulares"));
            listacat.Add(new productosLista("3", "Electro Hogar"));
            listacat.Add(new productosLista("4", "Informática"));
            listacat.Add(new productosLista("5", "Smart TV"));

            comboBoxCat.DisplayMember = "Valor";
            comboBoxCat.ValueMember = "Id";

            comboBoxCat.DataSource = listacat.OrderBy(x => x.Id).ToList();

        }

        private void CargarListaProductoDVG()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();

            List<Producto> listaproducto = productoNegocio.ListarProducto();
            

            //opciones para controlar porque no carga el dgv:
            Console.WriteLine($"Número de productos recibidos en la UI: {listaproducto?.Count ?? 0}");

            if (listaproducto == null || listaproducto.Count == 0)
            {
                MessageBox.Show("No se recibieron productos.");
                return;

            }

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listaproducto;

            if (dgvListaProductos != null)  //verifico el datagridview
            {
                dgvListaProductos.DataSource = bindingSource1;

                dgvListaProductos.Columns["fechabaja"].Visible = false;
                dgvListaProductos.Columns["idproveedor"].Visible = false;
                dgvListaProductos.Columns["idUsuario"].Visible = false;

                // Verificar el contenido del DataGridView
                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    Console.WriteLine($"Row: {row.Index}, Nombre: {row.Cells["nombre"].Value}");

                }



            }
            else
            {
                MessageBox.Show("dvgListaProductos no está inicializado correctamente.");


            }

        }


        private void buttonBajaProd_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonModificarProd_Click(object sender, EventArgs e)
        {

            
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAltaProd_Click(object sender, EventArgs e)
        {
            
        }

        private void FormListoProductoMenuSuper_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCat.SelectedIndex != 0)
                {
                    // SelectedValue no es nulo.
                    if (comboBoxCat.SelectedValue == null)
                    {
                        MessageBox.Show("Por favor seleccione una categoría válida.");
                        return;
                    }

                    ProductoNegocio productoNegocio = new ProductoNegocio();
                    string categoria = comboBoxCat.SelectedValue.ToString();

                    // la categoría puede convertirse a entero.
                    if (!Int32.TryParse(categoria, out int categoriaId))
                    {
                        MessageBox.Show("Categoría inválida.");
                        return;
                    }

                    List<Producto> listacat = productoNegocio.ListarCategoriadeProducto(categoriaId);
                    listacat = listacat.OrderBy(producto => producto.nombre).ToList();
                    dgvListaProductos.DataSource = listacat;
                }
                else
                {
                    CargarListaProductoDVG();
                }
            }
            catch (Exception ex)
            {
                // excepciones para capturar cualquier error inesperado.
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void buttonAltaProd_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuSupervisor.AbrirFormulario(new FormAltaProdMenuSuperv(FormMenuSupervisor));
        }

        private void buttonModificarProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el producto seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (dgvListaProductos.CurrentRow == null)
                    {
                        MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var selectedRow = dgvListaProductos.CurrentRow;
                    if (selectedRow.Cells["id"].Value == null || selectedRow.Cells["nombre"].Value == null || selectedRow.Cells["stock"].Value == null)
                    {
                        MessageBox.Show("Datos del producto incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var idValue = selectedRow.Cells["id"].Value.ToString();
                    var nombre = selectedRow.Cells["nombre"].Value.ToString();
                    var stock = selectedRow.Cells["stock"].Value.ToString();
                    var precio = selectedRow.Cells["precio"].Value.ToString();

                    ProductoWS productoWS = new ProductoWS();
                    this.Hide();
                    FormMenuSupervisor.AbrirFormulario(new FormEditarProdMenuSuperv(FormMenuSupervisor, Guid.Parse(idValue), nombre, stock, precio));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBajaProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaProductos.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea dar de baja el producto seleccionado de la lista?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        DataGridViewRow selectedRow = dgvListaProductos.CurrentRow;
                        object idValue = selectedRow.Cells["id"].Value;

                        ProductoNegocio productoNegocio = new ProductoNegocio();
                        productoNegocio.BajaProducto(Guid.Parse(idValue.ToString()), Sesion.Id);
                    }
                    CargarListaProductoDVG();

                }
                else
                {
                    MessageBox.Show("Seleccione una producto para dar de baja");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Producto productoSeleccionado = (Producto)dgvListaProductos.Rows[dgvListaProductos.CurrentCell.RowIndex].DataBoundItem;
            textBoxBajaProd.Text = productoSeleccionado.nombre;
        }
    }
}
