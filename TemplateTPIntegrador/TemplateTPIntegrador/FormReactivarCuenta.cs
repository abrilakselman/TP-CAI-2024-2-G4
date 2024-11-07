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

        }
    }
}
