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
    public partial class FormModificacionCliente : Form
    {
        private FormMenuAdministrador FormMenuAdministrador;
        private Guid IdCliente;
        ValidacionesUtils validador = new ValidacionesUtils();


        public FormModificacionCliente(FormMenuAdministrador formMenuAdministrador, Guid idCliente)
        {
            InitializeComponent();
            FormMenuAdministrador = formMenuAdministrador;
            IdCliente = idCliente;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormModificacionCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                var cliente = clienteNegocio.BuscarUnCliente(IdCliente);

                // Validar si el cliente fue encontrado
                if (cliente == null)
                {
                    MessageBox.Show("No se encontró el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar y asignar valores a los campos de texto
                textBoxDireccM.Text = !string.IsNullOrEmpty(cliente.direccion) ? cliente.direccion : string.Empty;
                textBoxEmailM.Text = !string.IsNullOrEmpty(cliente.email) ? cliente.email : string.Empty;
                textBoxTelM.Text = !string.IsNullOrEmpty(cliente.telefono) ? cliente.telefono : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAceptarM_Click(object sender, EventArgs e)
        {
            try
            {
                if (validador.validarStringVacio(textBoxDireccM.Text) || validador.validarStringVacio(textBoxEmailM.Text) || validador.validarStringVacio(textBoxTelM.Text))
                {
                    MessageBox.Show("Hay errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteNegocio.ModificarCliente(IdCliente, textBoxDireccM.Text, textBoxTelM.Text, textBoxEmailM.Text);
                    MessageBox.Show("Cliente modificado exitosamente");
                    this.Hide();
                    FormMenuAdministrador.AbrirFormulario(new FormListaCliente(FormMenuAdministrador));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
