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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            
            String usuario = txtUsuario.Text;

            if (usuario=="")
            {
                MessageBox.Show("el usuario no puede ser vacio");

                    
            }

            LoginNegocio loginNegocio = new LoginNegocio();
            loginNegocio.Login(usuario, "contraseña");
    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormMensajeAyuda formMensajeAyuda = new FormMensajeAyuda();
            formMensajeAyuda.ShowDialog();
        }

        private void pbPwdNotVisble_Click(object sender, EventArgs e)
        {
            pbPwdVisble.BringToFront();
            textBoxContraseña.PasswordChar = '*';
        }

        private void pbPwdVisble_Click(object sender, EventArgs e)
        {
            pbPwdNotVisble.BringToFront();
            textBoxContraseña.PasswordChar = '\0';
        }
    }
}
