using Datos.Proveedor;
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
    public partial class FormListaProveedor : Form
    {
        public FormMenuAdministrador FormMenuAdministrador_prov;

        public FormListaProveedor(FormMenuAdministrador formMenuAdministrador_prov)
        {
            InitializeComponent();
            //funcion que cargue datos en lista 
            FormMenuAdministrador_prov = formMenuAdministrador_prov;

            if (dgvListaProveedores == null)
            {
                MessageBox.Show("dgvListaProveedores no está inicializado.");
            }
            else
            {
                // Cargar la DataGridView de los proveedores del swagger
                CargarListaProveedoresDVG();


            }

        }

        private void CargarListaProveedoresDVG()
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            List<Proveedor> listaProveedor = proveedorNegocio.ListarProveedores();
            listaProveedor = listaProveedor.OrderBy(Proveedor => Proveedor.nombre).ToList();



            if (dgvListaProveedores != null)
            {
                MessageBox.Show("Llenando DataGridView");
                dgvListaProveedores.DataSource = listaProveedor;
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

        private void FormListaProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
