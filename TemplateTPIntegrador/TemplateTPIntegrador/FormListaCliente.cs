using Datos.Cliente;
using Datos.Usuario;
using Negocio;
using Persistencia;
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
                List<Clientes> clientes = ClienteNegocio.ListarCliente2();

            clientes = clientes.OrderBy(c => c.Apellido).ToList();

            var bindingList = new BindingList<Clientes>(clientes);
            var source = new BindingSource(bindingList, null);
            dgvListaCliente.DataSource = source;
            dgvListaCliente.Columns["id"].DisplayIndex = 0;
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

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            string valor = textBoxBajaCliente.Text;
            ClienteNegocio ClienteNegocio = new ClienteNegocio();


            if (valor != "")
            {

                //Da de baja el cliente en swagger
                Clientes clienteSeleccionado = (Clientes)dgvListaCliente.Rows[dgvListaCliente.CurrentCell.RowIndex].DataBoundItem;
                Guid GuiCliente = clienteSeleccionado.Id;
                

                //consulta si esta seguro de eliminar usuario
                var result = MessageBox.Show("¿Está seguro que desea eliminar a " + clienteSeleccionado.Apellido + ", " + clienteSeleccionado.Nombre + "?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClienteNegocio.BajaCliente(GuiCliente);
                    Console.WriteLine("Usuario eliminado");
                    cargarDGVcliente();
                    textBoxBajaCliente.Text = "";
                }
            }
            else
            {
                var result = MessageBox.Show("Seleccione un usuario para eliminarlo", "", MessageBoxButtons.OK);
            }
        }

        private void dgvListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientes clienteSeleccionado = (Clientes)dgvListaCliente.Rows[dgvListaCliente.CurrentCell.RowIndex].DataBoundItem;
            textBoxBajaCliente.Text = clienteSeleccionado.Apellido + ", " + clienteSeleccionado.Nombre;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormAltaCliente(FormMenuAdministrador));
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el cliente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvListaCliente.CurrentRow;
                    string idValue = selectedRow.Cells["id"].Value.ToString();

                    ClienteWS clienteWS = new ClienteWS();

                    this.Hide();
                    FormMenuAdministrador.AbrirFormulario(new FormModificacionCliente(FormMenuAdministrador, Guid.Parse(idValue)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
