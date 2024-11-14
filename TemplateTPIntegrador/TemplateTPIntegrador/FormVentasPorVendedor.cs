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
    public partial class FormVentasPorVendedor : Form
    {
        public FormMenuAdministrador FormMenuAdministrador;

        public FormVentasPorVendedor(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            FormMenuAdministrador = formMenuAdministrador;

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            // Listar clientes y ordenar
            List<productosLista> items = clienteNegocio.ListarCliente2()
                .Select(x => new productosLista(x.Id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new productosLista("", "Seleccione"));

            // Configurar ComboBox
            cmbVentasxVendedor.DisplayMember = "Valor";
            cmbVentasxVendedor.ValueMember = "Id";
            cmbVentasxVendedor.DataSource = items;

            // Añadir evento para cuando el ComboBox cambie de valor
            cmbVentasxVendedor.SelectedIndexChanged += new EventHandler(cmbVentasxVendedor_SelectedIndexChanged);

            // Cargar ventas inicial si hay un vendedor seleccionado
            if (cmbVentasxVendedor.SelectedIndex != 0)
            {
                CargarVentas();
            }
            else
            {
                //MessageBox.Show("Seleccione un valor válido");
            }
        }

        // Evento para manejar el cambio de selección del ComboBox
        private void cmbVentasxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVentasxVendedor.SelectedIndex != 0)
            {
                CargarVentas();
            }
        }

        private void CargarVentas()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            string vendedor = cmbVentasxVendedor.SelectedValue.ToString();

            // Listar ventas por vendedor
            List<Venta> listaVend = ventaNegocio.Listar(Guid.Parse(vendedor));

            // Agrupar y ordenar las ventas por mes
            var groupedData = listaVend
                .GroupBy(x => x.FechaAlta.Month)
                .Select(x => new { Mes = x.Key, Cantidad = x.Count() })
                .OrderBy(x => x.Mes)
                .ToList();

            // Configurar DataGridView
            dgvVentarxVendor.DataSource = groupedData;
        }





        private void FormVentasPorVendedor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonVolverVxV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdministrador.AbrirFormulario(new FormReportes(FormMenuAdministrador));
        }

        private void ButtonGenerarVxV_Click(object sender, EventArgs e)
        {

        }
    }
}
