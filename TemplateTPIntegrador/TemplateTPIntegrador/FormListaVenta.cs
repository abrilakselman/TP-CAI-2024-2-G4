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
using Datos.Ventas;
using Datos.Cliente;

namespace TemplateTPIntegrador
{
    public partial class FormListaVenta : Form
    {

        private FormMenuVendedores FormMenuVendedores;
        private List<Comprobante> comprobantes;

        private List<Clientes> clientes;




        public FormListaVenta(FormMenuVendedores formMenuVendedores)
        {
            InitializeComponent();

            ComprobanteVta comprobanteVta = new ComprobanteVta();
            comprobantes = comprobanteVta.RecuperarRegistros();

            ClienteNegocio clienteNegocio = new ClienteNegocio();

            List<productosLista> items = clienteNegocio.ListarCliente2()
                .Select(x => new productosLista(x.Id.ToString(), x.ToString()))
                .OrderBy(x => x.Valor)
                .ToList();
            items.Insert(0, new productosLista("", "Seleccione"));

            comboBoxCliente.DisplayMember = "Valor";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.DataSource = items;



            //CargarClientes();

            FormMenuVendedores = formMenuVendedores;

            btnBaja.Enabled = false;

            OcultarFilasVacias(dgvListaVtaCliente);
            OcultarColumnasVacias(dgvListaVtaCliente);



        }

        private void CargarClientes()
        {

            
            /*
            try
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                clientes = clienteNegocio.ListarCliente2();

                if (clientes != null && clientes.Count > 0)
                {
                    // Ordenar la lista de clientes alfabéticamente por Nombre y Apellido
                    clientes.Sort((x, y) => string.Compare($"{x.Nombre} {x.Apellido}", $"{y.Nombre} {y.Apellido}"));

                    // Agregar los clientes ordenados al ComboBox
                    foreach (var cliente in clientes)
                    {
                        comboBoxCliente.Items.Add($"{cliente.Nombre} {cliente.Apellido}");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }




        private void OcultarFilasVacias(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool filaVacia = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        filaVacia = false;
                        break;
                    }
                }
                row.Visible = !filaVacia;
            }
        }
        private void OcultarColumnasVacias(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                bool columnaVacia = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null &&
                        !string.IsNullOrWhiteSpace(row.Cells[column.Index].Value.ToString()))
                    {
                        columnaVacia = false;
                        break;
                    }
                }
                column.Visible = !columnaVacia;
            }
        }







        private void DescargarArchivo(string path)
        {
            // Implementa la lógica para descargar el archivo del path
            // Esto puede variar dependiendo de dónde se almacenan los archivos y cómo se deben descargar
            // Aquí tienes un ejemplo simple de cómo abrir el archivo en la ubicación del path

            if (System.IO.File.Exists(path))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("El archivo no se encontró.");
            }
        }





        private void FormListaVenta_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            var seleccion = comboBoxCliente.SelectedValue.ToString();
            if (!String.IsNullOrEmpty(seleccion))
            {
                var lista = comprobantes.Where(x => x.IdCliente == Guid.Parse(seleccion));
                dgvListaVtaCliente.DataSource = lista.Select(c => new
                {
                    c.Id,
                    c.Cliente,
                    c.FechaAlta
                }).OrderBy(x => x.Id).ToList();

                if (dgvListaVtaCliente.Columns["Descargar"] == null)
                {
                    DataGridViewButtonColumn btnColumnaDescarga = new DataGridViewButtonColumn();
                    btnColumnaDescarga.Name = "Descargar";
                    btnColumnaDescarga.Text = "Descargar";
                    btnColumnaDescarga.UseColumnTextForButtonValue = true;
                    dgvListaVtaCliente.Columns.Add(btnColumnaDescarga);
                    dgvListaVtaCliente.CellClick += new DataGridViewCellEventHandler(dgvListaVtaCliente_CellClick);
                }
                btnBaja.Enabled = lista.Any();
            }
            else
            {
                MessageBox.Show("Seleccione un valor válido");
            }
            /*




            // Obtiene el valor seleccionado en el comboBoxCliente y lo convierte a string
            var seleccion = comboBoxCliente.SelectedItem?.ToString();

            // Verifica que la selección no esté vacía o nula
            if (!string.IsNullOrEmpty(seleccion))
            {
                // Encuentra el cliente correspondiente en la lista de clientes
                var clienteSeleccionado = clientes.FirstOrDefault(c => $"{c.Nombre} {c.Apellido}" == seleccion);

                // Verifica que el cliente seleccionado no sea nulo
                if (clienteSeleccionado != null)
                {
                    // Filtra los comprobantes cuyo IdCliente coincida con el Id del cliente seleccionado
                    var lista = comprobantes.Where(x => x.IdCliente == clienteSeleccionado.Id).ToList();

                    // Asigna los datos filtrados al DataGridView, seleccionando y ordenando por Id
                    dgvListaVtaCliente.DataSource = lista.Select(c => new
                    {
                        c.Id,
                        c.Cliente,
                        c.FechaAlta
                    }).OrderBy(x => x.Id).ToList();

                    // Verifica si la columna "Descargar" no existe en el DataGridView
                    if (dgvListaVtaCliente.Columns["Descargar"] == null)
                    {
                        // Crea una nueva columna de botones para la descarga
                        DataGridViewButtonColumn btnColumnaDescarga = new DataGridViewButtonColumn();
                        btnColumnaDescarga.Name = "Descargar";
                        btnColumnaDescarga.Text = "Descargar";
                        btnColumnaDescarga.UseColumnTextForButtonValue = true; // Usa el texto del botón como valor
                        dgvListaVtaCliente.Columns.Add(btnColumnaDescarga); // Agrega la columna de botones al DataGridView

                        // Asocia el evento CellClick del DataGridView al manejador de eventos
                        dgvListaVtaCliente.CellClick += new DataGridViewCellEventHandler(dgvListaVtaCliente_CellClick);
                    }

                    // Habilita el botón de baja si hay elementos en la lista
                    btnBaja.Enabled = lista.Any();
                }
                else
                {
                    // Muestra un mensaje de error si no se ha encontrado el cliente seleccionado
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Muestra un mensaje de error si no se ha seleccionado un valor válido
                MessageBox.Show("Seleccione un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }


        private void dgvListaVtaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListaVtaCliente.Columns["Descargar"].Index && e.RowIndex >= 0)
            {
                // Obtener el Id del comprobante seleccionado
                int id = Convert.ToInt32(dgvListaVtaCliente.Rows[e.RowIndex].Cells["Id"].Value);

                // Obtener el comprobante de la lista original usando el Id
                var comprobante = comprobantes.FirstOrDefault(c => c.Id == id);
                if (comprobante != null)
                {
                    string path = comprobante.Path;
                    // Lógica para descargar el archivo en 'path'
                    DescargarArchivo(path);
                }
            }
        }


        private void btnBaja_Click(object sender, EventArgs e)
        {


             /*
            try
            {
                // Verifica si hay celdas seleccionadas en el DataGridView
                if (dgvListaVtaCliente.SelectedCells.Count > 0)
                {
                    // Muestra un mensaje de confirmación antes de dar de baja la venta
                    DialogResult result = MessageBox.Show("¿Desea dar de baja la venta?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    // Si el usuario confirma la acción
                    if (result == DialogResult.OK)
                    {
                        // Obtiene la fila seleccionada actualmente en el DataGridView
                        DataGridViewRow selectedRow = dgvListaVtaCliente.CurrentRow;
                        // Obtiene el valor de la celda "id" de la fila seleccionada
                        object idValue = selectedRow.Cells["id"].Value;

                        // Crea una instancia de la clase VentaNegocio
                        VentaNegocio ventaNegocio = new VentaNegocio();

                        // Elimina la venta utilizando el método Eliminar de la clase ComprobanteVta
                        ComprobanteVta comprobante = new ComprobanteVta();
                        comprobante.Eliminar((int)idValue);

                        // Oculta el formulario actual
                        this.Hide();
                        // Abre un nuevo formulario FormListaVenta
                        FormMenuAdministrador.AbrirFormulario(new FormListaVenta(FormMenuAdministrador));
                    }

                }
                else
                {
                    // Muestra un mensaje si no hay ninguna venta seleccionada
                    MessageBox.Show("Seleccione una venta para dar de baja");
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }*/


        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuVendedores.AbrirFormulario(new FormVentaAlta(FormMenuVendedores));
        }
    }
}
