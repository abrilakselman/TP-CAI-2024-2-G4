using Datos;
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
    public partial class FormAltaProducto : Form
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private FormMenuAdministrador FormMenuAdministrador;

        ValidacionesUtils validador = new ValidacionesUtils();

        private void InicializarImagenesError()
        {
            //Inicializo las imagenes de error
            pbNombCorrecto.BringToFront();
            pbPrecioCorrecto.BringToFront();
            pbStockCorrecto.BringToFront();
            
        }



        public FormAltaProducto(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            InicializarImagenesError();
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            try
            {
                List<productosLista> listaproveedores = proveedorNegocio.ListarProveedores()
                    .Select(x => new productosLista(x.Id.ToString(), x.ToString()))
                    .OrderBy(x => x.Valor)
                    .ToList();

                if (listaproveedores == null || !listaproveedores.Any())
                {
                    MessageBox.Show("No se encontraron proveedores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listaproveedores.Insert(0, new productosLista("", "Seleccione"));
                cmbProveedor.DisplayMember = "Valor";
                cmbProveedor.ValueMember = "Id";
                cmbProveedor.DataSource = listaproveedores;

                List<productosLista> listacat = new List<productosLista>
                    {
                        new productosLista("0", "Seleccione"),
                        new productosLista("1", "Audio"),
                        new productosLista("2", "Celulares"),
                        new productosLista("3", "Electro Hogar"),
                        new productosLista("4", "Informática"),
                        new productosLista("5", "Smart TV")
                    };

                cmbCategoria.DisplayMember = "Valor";
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DataSource = listacat
                    .OrderBy(x => x.Id)
                    .ToList();

                FormMenuAdministrador = formMenuAdministrador;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void FormAltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormListaProducto(FormMenuAdministrador));
        }

        

            
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
                LimpiarCampos();
                InicializarImagenesError();
        }

        //Limpia todos los campos 

        private void LimpiarCampos()
        {
            textBoxNombre.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxStock.Text = string.Empty;
            
            cmbCategoria.SelectedIndex = 0;
            cmbProveedor.SelectedIndex = 0;

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f"; //idadmin nuestro, como el idUsuario me da error, usamos este
            try
            {
                
                if (validador.validarStringVacio(textBoxNombre.Text) ||
                    !validador.ValidarSoloLetras(textBoxNombre.Text) ||
                    validador.validarNumyNeg(textBoxPrecio.Text) ||
                    validador.validarStringVacio(textBoxPrecio.Text) ||
                    validador.validarNumyNeg(textBoxStock.Text) ||
                    validador.validarStringVacio(textBoxStock.Text) ||
                    cmbCategoria.SelectedIndex == 0)
                {
                    MessageBox.Show("Todos los campos deben estar completados correctamente");
                }
                else
                {
                    string idProveedor = cmbProveedor.SelectedValue.ToString();
                    string categoria = cmbCategoria.SelectedValue.ToString();

                    //string idUsuario = Sesion.Id.ToString();   --- me da error de USUARIO NO ENCONTRADO

                    string nombre = textBoxNombre.Text;
                    int precio = Int32.Parse(textBoxPrecio.Text);
                    int stock = Int32.Parse(textBoxStock.Text);

                    // Asegúrate de que los datos están formateados y convertidos correctamente
                    productoNegocio.agregarProducto(Int32.Parse(categoria), idAdmin, idProveedor, nombre, precio, stock);

                    DialogResult result = MessageBox.Show("Producto agregado exitosamente. Desea agregar otro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        LimpiarCampos();
                        InicializarImagenesError();
                    }
                    else
                    {
                        this.Hide();
                        FormMenuAdministrador.AbrirFormulario(new FormListaProducto(FormMenuAdministrador));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxNombre.Text.ToLower(), ValidacionesUtils.ValidarNombre(textBoxNombre.Text), pbNombIncorrecto, pbNombCorrecto);
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxPrecio.Text.ToLower(), ValidacionesUtils.ValidarNumero(textBoxPrecio.Text), pbPrecioIncorrecto, pbPrecioCorrecto);
        }

        private void textBoxStock_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarInfoButton(textBoxStock.Text.ToLower(), ValidacionesUtils.ValidarNumero(textBoxStock.Text), pbStockIncorrecto, pbStockCorrecto);
        }


    }
}
