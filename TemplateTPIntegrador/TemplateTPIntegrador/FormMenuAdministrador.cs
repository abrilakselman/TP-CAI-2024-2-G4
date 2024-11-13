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
    public partial class FormMenuAdministrador : Form
    {

        ProductoNegocio productoNegocio = new ProductoNegocio();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FormMenuAdministrador()
        {
            InitializeComponent();
        }


        //carga de aviso de stock critico en Menu Admin y supervisor
        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {
            var productos = productoNegocio.ListarProducto().Where(x => x.stockBajo).ToList();
            if (productos.Any())  // Any para verificar si hay algún producto en lugar de Count() > 0
            {
                textBoxStockCritico.Text = productos.Count.ToString();
            }
        }





        //Abre los formularios dentro del panel de control en la pantalla de Menu admin
        public void AbrirFormulario(Form formulario)
        {
            if (this.panelMenu.Controls.Count > 0)
            {
                this.panelMenu.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(formulario);
            panelMenu.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormListaUsuario(this));
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormListaProveedores form = new FormListaProveedores(this);
            AbrirFormulario(form);

            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMensajeAyudaAdmin formMensajeAyudaAdmin = new FormMensajeAyudaAdmin();
            formMensajeAyudaAdmin.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReportes(this));
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormListaProducto(this));
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormListaCliente(this));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FormListaVenta(this));
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
