using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FormEditarProducto : Form
    {

        /*segun el swagger solo se edita el precio y stock
         * 
         * ejemplo:
         * {
              "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "idUsuario": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "precio": 0,
              "stock": 0
            }
         * 
         * 
         * */

        private String idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f";

        private FormMenuAdministrador FormMenuAdministrador;
        private Guid IdProducto;
        private string Nombre;
        private string Stock;
        ValidacionesUtils validador = new ValidacionesUtils();


        public FormEditarProducto(FormMenuAdministrador formMenuAdministrador, Guid idproducto, string nombre, string stock, string precio)
        {
            InitializeComponent();
            FormMenuAdministrador = formMenuAdministrador;
            IdProducto = idproducto;
            Nombre = nombre;
            Stock = stock;
            
            textBoxID.Text = idproducto.ToString();
            textBoxNombre.Text = nombre.ToString();
            textBoxPrecioAct.Text = precio.ToString();
            textBoxStockActual.Text = stock.ToString();
        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
        {

        }



        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                
                int resta = Int32.Parse(Stock) - Math.Abs(Int32.Parse(textBoxStockNuevo.Text));
                if (validador.validarNumyNeg(textBoxPrecioNuevo.Text) || !Int32.TryParse(textBoxStockNuevo.Text, out n)
                    || (Int32.Parse(textBoxStockNuevo.Text) < 0 && resta < 0))
                {
                    MessageBox.Show("Hay campos incorrectos, por favor modifícalo para poder guardar los cambios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    ProductoNegocio productoNegocio = new ProductoNegocio();
                    productoNegocio.ModificarProducto(IdProducto, idAdmin, Int32.Parse(textBoxPrecioNuevo.Text), Int32.Parse(textBoxStockNuevo.Text));
                    MessageBox.Show("Producto modificado exitosamente");
                    this.Hide();
                    
                    FormMenuAdministrador.AbrirFormulario(new FormListaProducto(FormMenuAdministrador));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Ocurrió un error: {ex.Message}");
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormListaProducto(FormMenuAdministrador));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
