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
    public partial class FormLogin : Form
    {

        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FormLogin()
        {
            InitializeComponent();
            //evento para salida del form de login
            this.FormClosing += new FormClosingEventHandler(FormLogin_FormClosing);
            pbPwdNotVisble.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            //Logica del Login
            //valido el usuario y contraseña que ingreso
            // 1. verifico que el usuario exista
            // 2. verifico la contraseña - 3 intentos de acceso
            // 3. segun el perfil, abre su menu correspondiente

            String usuario = txtUsuario.Text;
            String contraseña = textBoxContraseña.Text;
            // Creo un int rol que tome el valor del perfil que inicia sesion
            int rol;

            //Validar reglas de negocio sobre el user/contraseña
            LoginNegocio loginNegocio = new LoginNegocio();
            bool esValido = loginNegocio.Login(usuario, contraseña);


            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña. Los campos no pueden ser vacios");
                return; // Salir del método para evitar continuar con el inicio de sesión
            }
            /*else if (!esValido)
            {
                MessageBox.Show("Nombre de usuario no válido. Debe tener entre 8 y 15 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/ //si este IF queda, entonces no entra a los mensajes de Credencial incorrecta del LogIn en UsuarioWS
            else
            {
                
                try
                {
                   //se valida los intentos y cuando son menos de 3 accede al login segun el rol
 
                    Guid idUsuario = usuarioNegocio.LogIn(usuario, contraseña);


                    rol = usuarioNegocio.LogInRol(usuario, contraseña);


                    // 1 vendedor, 2 supervisor, 3 administrador
                    if (rol == 3)
                    {
                        this.Hide();
                        FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
                        formMenuAdministrador.ShowDialog();
                    }
                    else if (rol == 2)
                    {
                        this.Hide();
                        FormMenuSupervisor formMenuSupervisor = new FormMenuSupervisor();
                        formMenuSupervisor.ShowDialog();
                    }
                    else if (rol == 1)
                    {
                        this.Hide();
                        FormMenuVendedores formMenuVendedor = new FormMenuVendedores();
                        formMenuVendedor.ShowDialog();
                    }
                }
                catch (Exception ex) //entra en el catch cuando esta inactivo
                {
                    //metodos de validacion para intentos
                    MessageBox.Show(ex.Message);
                }
            }



            
            








           

            

            
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormMensajeAyuda formMensajeAyuda = new FormMensajeAyuda();
            formMensajeAyuda.ShowDialog();
        }

        private void pbPwdVisble_Click(object sender, EventArgs e)
        {
            pbPwdNotVisble.BringToFront();
            textBoxContraseña.PasswordChar = '*'; // Oculta la contraseña

            //MessageBox.Show("pbPwdVisble_Click ejecutado"); control de funcionamiento
        }

        private void pbPwdNotVisble_Click(object sender, EventArgs e)
        {
            pbPwdVisble.BringToFront();
            textBoxContraseña.PasswordChar = '\0'; // Muestra la contraseña

            //MessageBox.Show("pbPwdNotVisble_Click ejecutado");  control de funcionamiento
        }

        //salida del formulario login
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario
            }
        }
    }
}
