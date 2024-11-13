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
        public FormMenuSupervisor()
        {
            InitializeComponent();
        }

        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {
            //deberia ir la funcion de mostrar stock critico en pantalla principal de los menus
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
            AbrirFormulario(new FormReportes(this));
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
    }
}
