using Datos.Ventas;
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
using Datos;
using Datos.Cliente;
using System.Diagnostics;
using System.IO;

namespace TemplateTPIntegrador
{
    public partial class FormVentaAlta : Form
    {
        private List<Producto> productos = new List<Producto>();
        private List<VentaLista> ventaLista = new List<VentaLista>();
        private List<Clientes> clientes = new List<Clientes>();

        private ValidacionesUtils validador = new ValidacionesUtils();
        private FormMenuVendedores FormMenuVendedores;

        public FormVentaAlta(FormMenuVendedores formMenuVendedores)
        {
            InitializeComponent();

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clientes = clienteNegocio.ListarCliente2();

            List<productosLista> items = clientes
                .Select(x => new productosLista(x.Id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new productosLista("", "Seleccione"));

            comboBoxCliente.DisplayMember = "Valor";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DataSource = items;

            ProductoNegocio productoNegocio = new ProductoNegocio();

            productos = productoNegocio.ListarProducto();

            items = productos
                .Select(x => new productosLista(x.id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new productosLista("", "Seleccione"));

            comboBoxProducto.DisplayMember = "Valor";
            comboBoxProducto.ValueMember = "Id";
            comboBoxProducto.DataSource = items;

            FormMenuVendedores = formMenuVendedores;
        }



        



        private void FormVentaAlta_Load(object sender, EventArgs e)
        {

        }

        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    Producto productoSeleccionado = comboBoxProducto.SelectedItem as Producto;
                    if (productoSeleccionado != null)
                    {
                        Guid idProducto = productoSeleccionado.id;

                        if (!ValidarStock(Convert.ToInt32(textBoxCant.Text), idProducto))
                        {
                            MessageBox.Show("No hay stock para el producto");
                            return;
                        }
                    }

                    try
                    {
                        VentaNegocio ventaNegocio = new VentaNegocio();
                        ventaNegocio.CrearVenta(Guid.Parse(comboBoxCliente.SelectedValue.ToString()), Guid.Parse(comboBoxProducto.SelectedValue.ToString()),
                            Sesion.Id, Convert.ToInt32(textBoxCant.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                    ventaLista.Add(new VentaLista(
                        new productosLista(comboBoxProducto.SelectedValue.ToString(),
                        comboBoxProducto.SelectedItem.ToString()),
                        Convert.ToInt32(textBoxCant.Text), Convert.ToInt32(textBoxPrecioUnit.Text),
                        Convert.ToInt32(textBoxPrecioTotal.Text),
                        productos.First(x => x.id == Guid.Parse(comboBoxProducto.SelectedValue.ToString())).idCategoria));

                    dataGridViewVta.DataSource = null;

                    dataGridViewVta.DataSource = ventaLista;


                }
                else
                {
                    MessageBox.Show("Por favor validar los campos ingresados.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private bool ValidarStock(int stock, Guid idProducto)
        {
            return productos.FirstOrDefault(x => x.id == idProducto).stock < stock;
        }



        private bool ValidarCampos()
        {
            bool esValido = true;

            esValido = validador.validarStringVacio(textBoxCant.Text);
            esValido = validador.validarStringVacio(comboBoxCliente.SelectedValue.ToString());
            esValido = validador.validarStringVacio(comboBoxProducto.SelectedValue.ToString());
            esValido = validador.validarNumyNeg(textBoxCant.Text);
            esValido = validador.validarStringVacio(textBoxCant.Text);

            return esValido;
        }


        //eventos:
        private void textBoxCant_KeyPres(object sender, KeyPressEventArgs e)
        {
            CalcularPrecio();
        }
        private void textBoxCant_Leave(object sender, EventArgs e)
        {
  
            CalcularPrecio();
        }

        private void comboBoxProducto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

       
        //metodo para el total
        private void CalcularPrecio()
        {
            if (!String.IsNullOrEmpty(comboBoxProducto.SelectedValue.ToString()) && !String.IsNullOrEmpty(textBoxCant.Text))
            {
                Guid idProducto = Guid.Parse(comboBoxProducto.SelectedValue.ToString());

                var precio = productos.FirstOrDefault(x => x.id == idProducto).precio;

                textBoxPrecioUnit.Text = precio.ToString();

                textBoxPrecioTotal.Text = (precio * Convert.ToInt32(textBoxCant.Text)).ToString();
            }
            else
            {
                textBoxPrecioUnit.Text = String.Empty;
            }
        }

        private void btnGuardarVta_Click(object sender, EventArgs e)
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            var cliente = clientes.First(x => x.Id.ToString() == comboBoxCliente.SelectedValue.ToString());

            ComprobanteVta comprobanteVta = new ComprobanteVta();
            var id = comprobanteVta.UltimoId();
            var path = ventaNegocio.GenerarPDF(id, cliente, ventaLista, ventaNegocio.calcularDescuento(ventaLista));
            comprobanteVta.Agregar(id, cliente, path);

            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("El archivo PDF no se pudo generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
