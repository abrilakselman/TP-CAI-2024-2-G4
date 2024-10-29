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

namespace TemplateTPIntegrador
{
    public partial class FormListaUsuario : Form
    {

        public FormMenuAdministrador FormMenuAdministrador;
        public FormListaUsuario(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();

            //carga la datagridview de los usuario del swagger
            CargarListaUsuarioDVG();

            //funcion que cargue datos en lista 
            FormMenuAdministrador = formMenuAdministrador;
            
        }

        
        private void CargarListaUsuarioDVG()
        {

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            List<Usuario> listaUsuarios = usuarioNegocio.ListaTraerUsuariosActivos();

            dgvListaUsuario.DataSource = listaUsuarios;

            //traiga toda la informacion del usuario
            dgvListaUsuario.Columns["id"].DisplayIndex = 0;
            dgvListaUsuario.Columns["nombre"].DisplayIndex = 1;
            dgvListaUsuario.Columns["apellido"].DisplayIndex = 2;
            dgvListaUsuario.Columns["direccion"].Visible = false;
            dgvListaUsuario.Columns["telefono"].Visible = false;
            dgvListaUsuario.Columns["email"].Visible = false;
            dgvListaUsuario.Columns["fechaAlta"].Visible = false;
            dgvListaUsuario.Columns["fechaNacimiento"].Visible = false;
            dgvListaUsuario.Columns["fechaBaja"].Visible = false;
            dgvListaUsuario.Columns["contraseña"].Visible = false;


        }

        private void FormListaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificacionCliente formModificacionCliente = new FormModificacionCliente();
            formModificacionCliente.ShowDialog();
        }

        private void btnAltaUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormAltaUsuario(FormMenuAdministrador));
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            

            string valor = textBoxBajaUser.Text;
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            

            if (valor != "")
            {

                //Da de baja el usuario en el swagger "Usuario/BajaUsuario" segun el ID ingresado
                Usuario usuarioSeleccionado = (Usuario)dgvListaUsuario.Rows[dgvListaUsuario.CurrentCell.RowIndex].DataBoundItem;
                Guid GuidUsuario = usuarioSeleccionado.Id;
                String IdUsuario = GuidUsuario.ToString();

                //consulta si esta seguro de eliminar usuario
                var result = MessageBox.Show("¿Está seguro que desea eliminar a " + usuarioSeleccionado.Apellido + ", " + usuarioSeleccionado.Nombre + "?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    usuarioNegocio.BajaUsuario(IdUsuario);
                    Console.WriteLine("Usuario eliminado");
                    CargarListaUsuarioDVG();
                    textBoxBajaUser.Text = "";
                }
            }
            else
            {
                var result = MessageBox.Show("Seleccione un usuario para eliminarlo", "", MessageBoxButtons.OK);
            }

        }

        private void dgvListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuarioSeleccionado = (Usuario)dgvListaUsuario.Rows[dgvListaUsuario.CurrentCell.RowIndex].DataBoundItem;
            textBoxBajaUser.Text = usuarioSeleccionado.Apellido + ", " + usuarioSeleccionado.Nombre;
        }
    }
}
