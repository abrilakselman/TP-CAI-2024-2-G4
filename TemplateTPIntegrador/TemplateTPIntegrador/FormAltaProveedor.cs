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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TemplateTPIntegrador
{
    public partial class FormAltaProveedor : Form
    {
        private ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        ValidacionesUtils validador = new ValidacionesUtils();
        private FormMenuAdministrador FormMenuAdministrador;


        public FormAltaProveedor(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            InicializarImagenesError();
            FormMenuAdministrador = formMenuAdministrador;
        }

        private void InicializarImagenesError()
        {
            //Inicializo las imagenes de error
            pbNomCorrecto.BringToFront();
            pbApellidoCorrecto.BringToFront();
            pbEmailCorrecto.BringToFront();
            pbCuitCorrecto.BringToFront();

        }


        private void LimpiarCampos()
        {
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxCUIT.Text = string.Empty;

        }


        private void FormAltaProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            InicializarImagenesError();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormListaProveedores(FormMenuAdministrador));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            string idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f"; //idadmin nuestro, como el idUsuario me da error, usamos este
            try
            {

                if (!validador.ValidarSoloLetrasProv(textBoxNombre.Text) ||
                    
                    !validador.ValidarSoloLetrasProv(textBoxApellido.Text) ||
                    
                    !validador.ValidarCUIT(textBoxCUIT.Text) ||
                    !validador.ValidarEmailProv(textBoxEmail.Text) )
                    
                {
                    MessageBox.Show("Todos los campos deben estar completados correctamente");
                }
                else
                {
                    
                    //string idUsuario = Sesion.Id.ToString();   // nos sigue dando error de Usuario NO encontrado

                    string nombre = textBoxNombre.Text;
                    string apellido = textBoxApellido.Text;
                    string cuit = textBoxCUIT.Text;
                    string email = textBoxEmail.Text;

                    //los datos están formateados y convertidos correctamente
                    proveedorNegocio.agregarProveedor(idAdmin, nombre, apellido, email, cuit);

                    
                    DialogResult result = MessageBox.Show("Proveedor agregado exitosamente. Desea agregar otro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        LimpiarCampos();
                        InicializarImagenesError();
                    }
                    else
                    {
                        this.Hide();
                        FormMenuAdministrador.AbrirFormulario(new FormListaProveedores(FormMenuAdministrador));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxNombre.Text.ToLower(), ValidacionesUtils.ValidarNombre(textBoxNombre.Text), pbNomIncorrecto, pbNomCorrecto);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxApellido.Text.ToLower(), ValidacionesUtils.ValidarNombre(textBoxApellido.Text), pbApellidoIncorrecto, pbApellidoCorrecto);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxEmail.Text.ToLower(), ValidacionesUtils.ValidarEmail(textBoxEmail.Text), pbEmailIncorrecto, pbEmailCorrecto);
        }

        private void textBoxCUIT_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxCUIT.Text.ToLower(), ValidacionesUtils.ValidarCUIT_PB(textBoxCUIT.Text), pbCuitIncorrecto, pbCuitCorrecto);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
