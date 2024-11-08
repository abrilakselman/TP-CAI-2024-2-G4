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
    public partial class FormReactivarCuenta : Form
    {
        ValidacionesUtils validador = new ValidacionesUtils();
        private FormMenuAdministrador FormMenuAdministrador;
        private string Contraseña;
        private string Nombre;
        public FormReactivarCuenta(string contraseña, string nombre)
        {
            InitializeComponent();
            Contraseña = contraseña;
            Nombre = nombre;
        }

        private void FormReactivarCuenta_Load(object sender, EventArgs e)
        {

            UsuarioInactivo archivo = new UsuarioInactivo();

            if (validador.validarStringVacio(textBoxPass.Text) || validador.longitudCampo(textBoxPass.Text, 8, 15))
            {

                MessageBox.Show("La contraseña no puede ser vacia y tiene que tener entre 8 y 15 caracteres .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                Guid idUsuario = new Guid("4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f");

                string nuevaContraseña = textBoxPass.Text;

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                string id = archivo.ObtenerId(Nombre, Contraseña);

                usuarioNegocio.ReactivarUsuario(Guid.Parse(id), idUsuario);
                usuarioNegocio.CambiarContraseña(Nombre, Contraseña, nuevaContraseña); //Actualiza a la nueva contraseña despues de reactivacion

                MessageBox.Show("Contraseña Actualizada");
                Sesion.Id = Guid.Parse(id);
                Sesion.Nombre = Nombre;
                this.Hide();


                //regresa al login para que se loguea con la nueva contraseña despues de la reactivacion
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }



        }
    }
}
