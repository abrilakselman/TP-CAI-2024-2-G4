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
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                List<Cliente> lista = clienteNegocio.ListarCliente();
                if (lista != null && lista.Count > 0)
                {
                    // Ordena la lista por nombre
                    lista = lista.OrderBy(cliente => cliente.nombre).ToList();
                    dgvListaCliente.DataSource = lista;
                    dgvListaCliente.Columns["id"].DisplayIndex = 0;
                    dgvListaCliente.Columns["nombre"].DisplayIndex = 1;
                    dgvListaCliente.Columns["apellido"].DisplayIndex = 2;
                    dgvListaCliente.Columns["fechaBaja"].Visible = false;
                    dgvListaCliente.Columns["idUsuario"].Visible = false;
                    dgvListaCliente.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }


       




        private void FormListaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
