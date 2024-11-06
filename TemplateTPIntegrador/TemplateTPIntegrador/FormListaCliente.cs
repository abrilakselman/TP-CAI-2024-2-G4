using Datos.Cliente;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FormListaCliente : Form
    {
        public FormMenuAdministrador FormMenuAdministrador;
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();

        public FormListaCliente(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            FormMenuAdministrador = formMenuAdministrador;
            cargarDGVcliente();
        }



        private void cargarDGVcliente()
        {
            try
            {
                List<Cliente> Cliente = ClienteNegocio.ListarCliente();

                

                var bindingList = new BindingList<Cliente>(Cliente);
                var source = new BindingSource(bindingList, null);

                dgvListaCliente.DataSource = source;
                dgvListaCliente.Columns["id"].Visible = false;
                dgvListaCliente.Columns["Host"].Visible = false;
                dgvListaCliente.Columns["fechaBaja"].Visible = false;
                dgvListaCliente.Columns["fechaAlta"].Visible = false;
                dgvListaCliente.Columns["fechaNacimiento"].HeaderText = "Nacimiento";
                dgvListaCliente.Columns["Direccion"].HeaderText = "Dirección";
                dgvListaCliente.Columns["Telefono"].HeaderText = "Teléfono";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }


       




        private void FormListaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
