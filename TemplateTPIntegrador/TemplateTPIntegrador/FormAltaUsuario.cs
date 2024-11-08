using Datos;
using Datos.Usuario;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FormAltaUsuario : Form
    {
        ValidacionesUtils validador = new ValidacionesUtils();
        private FormMenuAdministrador FormMenuAdministrador;

        //para el user
        const int minimocaracteresUser = 8;
        const int maximocaracteresUser = 15;
        //const int minCarContraseña = 8;
        

        public FormAltaUsuario(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();


            //Inicializo las imagenes de error
            pbNombreCorrecto.BringToFront();
            pbApellidoCorrecto.BringToFront();
            pbDireccionCorrecta.BringToFront();
            pbTelefonoCorrecto.BringToFront();
            pbDNICorrecto.BringToFront();
            pbEmailCorrecto.BringToFront();
            pbFechNacCorrecto.BringToFront();

            // Crear la lista de productosLista
            List<productosLista> items = new List<productosLista>
            {
                new productosLista("3", "Administrador"),
                new productosLista("2", "Supervisor"),
                new productosLista("1", "Vendedor")
            };

            // Validar que la lista no esté vacía antes de asignarla al ComboBox
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("La lista de perfiles está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configurar el ComboBox
            comboBoxPerfil.DisplayMember = "Valor";
            comboBoxPerfil.ValueMember = "Id";
            comboBoxPerfil.DataSource = items
                .OrderBy(x => x.Valor)
                .ToList();

            // Validar que el ComboBox tiene items asignados
            if (comboBoxPerfil.Items.Count == 0)
            {
                MessageBox.Show("No se pudieron cargar los perfiles en el ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar el formulario principal
            FormMenuAdministrador = formMenuAdministrador ?? throw new ArgumentNullException(nameof(formMenuAdministrador), "El formulario principal no puede ser nulo.");
        }





        private void buttonAceptar_Click(object sender, EventArgs e)
        {


            string idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f"; //idadmin nuestro

            

            int host;
            if (comboBoxPerfil.SelectedValue == null || !int.TryParse(comboBoxPerfil.SelectedValue.ToString(), out host))
            {
                MessageBox.Show("El valor del perfil debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = ValidacionesUtils.ValidarNombre(textBoxNombre.Text);
            string apellido = ValidacionesUtils.ValidarApellido(textBoxApellido.Text);
            int dni = ValidacionesUtils.ValidarDNI(textBoxDNI.Text);
            string direccion = ValidacionesUtils.ValidarDireccion(textBoxDireccion.Text);
            string email = ValidacionesUtils.ValidarEmail(textBoxEmail.Text);
            DateTime fechaNac = dateTimePicker1.Value;
            string telefono = ValidacionesUtils.ValidarTelefono(textBoxTelefono.Text);
            string contraseña = ValidacionesUtils.ValidarContraseña(textBoxContraseña.Text);

            //string idUsuario = Sesion.Id.ToString();   Me da error


            string usuarioNuevo = textBoxUsuario.Text;
            bool check = false;

            //VALIDACION DE DATOS DEL USER
            //Uso un contador de errores para mostrar en pantalla en caso de que haya
            string errores = "";

            errores += ValidacionesUtils.ValidarNombre(nombre);
            errores += ValidacionesUtils.ValidarApellido(apellido);
            errores += ValidacionesUtils.ValidarDNI(dni.ToString());
            errores += ValidacionesUtils.ValidarDireccion(direccion);
            errores += ValidacionesUtils.ValidarEmail(email);
            errores += ValidacionesUtils.ValidarTelefono(telefono);
            errores += ValidacionesUtils.ValidarFechaNac(fechaNac);
            errores += ValidacionesUtils.ValidarContraseña(contraseña);


            if (errores.Contains("error") || errores.Contains("-1") || check == true)
            {
                MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                usuarioNegocio.AgregarUsuario(idAdmin, host, nombre, apellido, dni, direccion, telefono, email, fechaNac, usuarioNuevo, contraseña);
                string id = usuarioNegocio.LogIn(usuarioNuevo, contraseña).ToString();
                
                
                DialogResult result = MessageBox.Show("Usuario agregado exitosamente. Desea agregar otro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


                //limpio los campos, si se quiere ingresar un nuevo user
                if (result == DialogResult.OK)
                {
                    LimpiarCampos();
                }
                else
                {
                    this.Hide();
                    FormMenuAdministrador.AbrirFormulario(new FormListaUsuario(FormMenuAdministrador));
                }

                


            }


        }


        private void LimpiarCampos()
        {
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxDNI.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxUsuario.Text = string.Empty;
            textBoxContraseña.Text = string.Empty;
            comboBoxPerfil.SelectedIndex = 0;

            //Inicializo las imagenes de error
            pbNombreCorrecto.BringToFront();
            pbApellidoCorrecto.BringToFront();
            pbDireccionCorrecta.BringToFront();
            pbTelefonoCorrecto.BringToFront();
            pbDNICorrecto.BringToFront();
            pbEmailCorrecto.BringToFront();
            pbFechNacCorrecto.BringToFront();
        }





        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormListaUsuario(FormMenuAdministrador));
        }

        private void NombreError_Click(object sender, EventArgs e)
        {

        }


        //Validacion con picturebox con ToolTip
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxNombre.Text.ToLower(), ValidacionesUtils.ValidarNombre(textBoxNombre.Text), pbNombreIncorrecto, pbNombreCorrecto);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxApellido.Text.ToLower(), ValidacionesUtils.ValidarApellido(textBoxApellido.Text), pbApellidoIncorrecto, pbApellidoCorrecto);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxDireccion.Text, ValidacionesUtils.ValidarDireccion(textBoxDireccion.Text), pbDireccionIncorrecta, pbDireccionCorrecta);
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxTelefono.Text, ValidacionesUtils.ValidarTelefono(textBoxTelefono.Text), pbTelefonoIncorrecto, pbTelefonoCorrecto);
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxDNI.Text, ValidacionesUtils.ValidarDNI(textBoxDNI.Text).ToString(), pbDNIIncorrecto, pbDNICorrecto);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxEmail.Text, ValidacionesUtils.ValidarEmail(textBoxEmail.Text), pbEmailIncorrecto, pbEmailCorrecto);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(dateTimePicker1.Value.ToString(), ValidacionesUtils.ValidarFechaNac(dateTimePicker1.Value).ToString(), pbFechNacIncorrecto, pbFechNacCorrecto);

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            string usuarioNuevo = textBoxUsuario.Text;
            string nombreUsuario = textBoxNombre.Text;
            string apellidoUsuario = textBoxApellido.Text;

            if (validador.validarStringVacio(usuarioNuevo))
            {
                //lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
            }
            if (validador.validarStringVacio(usuarioNuevo) || validador.validarMin(usuarioNuevo, minimocaracteresUser))
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (validador.validarMax(usuarioNuevo, maximocaracteresUser))
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (usuarioNuevo.Contains(nombreUsuario))
            {
                lblNomUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblNomUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (usuarioNuevo.Contains(apellidoUsuario))
            {
                lblApeUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblApeUsuarioRegistrar.ForeColor = Color.Green;
            }

        }






    }

}
