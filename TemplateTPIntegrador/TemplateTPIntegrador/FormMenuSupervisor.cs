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
    public partial class FormMenuSupervisor : Form
    {

        ProductoNegocio productoNegocio = new ProductoNegocio();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FormMenuSupervisor()
        {
            InitializeComponent();
        }


        //Abre los formularios dentro del panel de control en la pantalla de Menu supervisor
        public void AbrirFormulario(Form formulario)
        {
            if (this.panelMenuSupervisor.Controls.Count > 0)
            {
                this.panelMenuSupervisor.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelMenuSupervisor.Controls.Add(formulario);
            panelMenuSupervisor.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

      

        private void btnReportesSupervisor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReporteMenuSuperv(this));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMensajeAyudaSupervisor formMensajeAyudaSupervisor = new FormMensajeAyudaSupervisor();
            formMensajeAyudaSupervisor.ShowDialog();
        }

        private void btnProductoSupervisor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormListoProductoMenuSuper(this));
        }

        private void FormMenuSupervisor_Load(object sender, EventArgs e)
        {
            var productos = productoNegocio.ListarProducto().Where(x => x.stockBajo).ToList();
            if (productos.Any())  // Any para verificar si hay algún producto en lugar de Count() > 0
            {
                textBoxStockCritico.Text = productos.Count.ToString();
            }
        }
    }
}
