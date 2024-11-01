using Datos;
using Datos.Usuario;
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
    public partial class FormListaProveedores : Form
    {
        public FormMenuAdministrador FormMenuAdministrador;

        public FormListaProveedores(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            

            if (dgvListaProveedores == null)  
            {
                MessageBox.Show("dgvListaProveedores no está inicializado.");
            }
            else
            {
                // Cargar la DataGridView de los proveedores del swagger
                CargarListaProveedoresDVG();


            }

            FormMenuAdministrador = formMenuAdministrador;

        }

        private void CargarListaProveedoresDVG()
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            List<Proveedor> listaProveedor = proveedorNegocio.ListarProveedores();

            //listaProveedor = listaProveedor.OrderBy(Proveedor => Proveedor.nombre).ToList();

            if (listaProveedor == null || listaProveedor.Count == 0)  //verificar los datos recibidos
            {
                MessageBox.Show("No se recibieron proveedores.");
                return;
            }

                // Crear un BindingSource y asignarle la lista de personas como DataSource
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listaProveedor;

            if (dgvListaProveedores != null)
            {
                MessageBox.Show("Llenando DataGridView");

                dgvListaProveedores.DataSource = bindingSource1;

                dgvListaProveedores.Columns["id"].DisplayIndex = 0;
                dgvListaProveedores.Columns["nombre"].DisplayIndex = 1;
                dgvListaProveedores.Columns["apellido"].DisplayIndex = 2;
                dgvListaProveedores.Columns["fechaAlta"].Visible = false;
                dgvListaProveedores.Columns["fechaBaja"].Visible = false;
            }
            else
            {
                MessageBox.Show("dgvListaProveedores es nulo dentro de CargarListaProveedoresDVG.");
            }

        }








        private void FormListaProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnBajaProv_Click(object sender, EventArgs e)
        {
            

            string valor = textBoxBajaProv.Text;
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            if (valor != "")
            {

                //Da de baja el proveedor en swagger
                Usuario proveedorSeleccionado = (Usuario)dgvListaProveedores.Rows[dgvListaProveedores.CurrentCell.RowIndex].DataBoundItem;
                Guid GuiProveedor = proveedorSeleccionado.Id;
                String IdProveedor = GuiProveedor.ToString();

                //consulta si esta seguro de eliminar usuario
                var result = MessageBox.Show("¿Está seguro que desea eliminar a " + proveedorSeleccionado.Apellido + ", " + proveedorSeleccionado.Nombre + "?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    proveedorNegocio.BajaProveedor(IdProveedor);
                    Console.WriteLine("Usuario eliminado");
                    CargarListaProveedoresDVG();
                    textBoxBajaProv.Text = "";
                }
            }
            else
            {
                var result = MessageBox.Show("Seleccione un usuario para eliminarlo", "", MessageBoxButtons.OK);
            }


        }

        private void dgvListaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Proveedor proveedorSeleccionado = (Proveedor)dgvListaProveedores.Rows[dgvListaProveedores.CurrentCell.RowIndex].DataBoundItem;
            textBoxBajaProv.Text = proveedorSeleccionado.Apellido + ", " + proveedorSeleccionado.Nombre;
        }

        private void btnAltaProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormAltaProveedor(FormMenuAdministrador));
        }
    }
}
