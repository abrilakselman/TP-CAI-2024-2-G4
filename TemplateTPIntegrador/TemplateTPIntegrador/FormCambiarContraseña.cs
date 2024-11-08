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
    public partial class FormCambiarContraseña : Form
    {

        public string Usuario { get; set; }

        public int RolUsuario { get; set; }

        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        ValidacionesUtils validador = new ValidacionesUtils();

        


        public FormCambiarContraseña()
        {
            InitializeComponent();
            
        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string usuario = this.Usuario;
            string contraseña = textBoxContraseñaActual.Text;
            string contraseñaNueva = textBoxPassNueva.Text;
            string contraseñaVerificar = textBoxPassConfirmar.Text;

            

            if (!(validador.validarIguales(contraseñaNueva, contraseñaVerificar)))
            {
                labelErrorContraseñaIgual.Text = "Error. La contraseña nueva no coincide con la verificación. Por favor vuelva a intentarlo";
            }
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("La contraseña actual no puede estar vacía.");
                labelErrorContraseñaIgual.Text = "";
            }

            if (string.IsNullOrWhiteSpace(contraseñaNueva))
            {
                MessageBox.Show("La nueva contraseña no puede estar vacía.");
                labelErrorContraseñaIgual.Text = "";
            }

            if (string.IsNullOrWhiteSpace(contraseñaVerificar))
            {
                MessageBox.Show("Debe confirmar la nueva contraseña.");
                labelErrorContraseñaIgual.Text = "";
            }
            else
            {
                usuarioNegocio.CambiarContraseña(usuario, contraseña, contraseñaNueva);

                var result = MessageBox.Show("Contraseña fue cambiada exitosamente", "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Close();
                    this.Hide();
                }
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
