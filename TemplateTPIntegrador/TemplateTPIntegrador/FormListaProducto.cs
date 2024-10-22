using Datos;
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
    public partial class FormListaProducto : Form
    {
        //Objetivo es listar los productos por CATEGORIA

        public FormMenuAdministrador FormMenuAdministrador;

        public FormListaProducto(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            CargarListaProductoDVG();
            FormMenuAdministrador = formMenuAdministrador;
            InicializarComboBox();

        }

        private void InicializarComboBox()
        {
            List<productosLista> listacat = new List<productosLista>();  //de la entidad productosLista
            listacat.Add(new productosLista("0", "Todas"));
            listacat.Add(new productosLista("1", "Audio"));
            listacat.Add(new productosLista("2", "Celulares"));
            listacat.Add(new productosLista("3", "Electro Hogar"));
            listacat.Add(new productosLista("4", "Informática"));
            listacat.Add(new productosLista("5", "Smart TV"));

            
        }

        private void CargarListaProductoDVG()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();

            List<Producto> listaproducto = productoNegocio.ListarProducto();
            //listaproducto = listaproducto.OrderBy(x => x.idcategoria).ToList();


            //opciones para controlar porque no carga el dgv:
            Console.WriteLine($"Número de productos recibidos en la UI: {listaproducto?.Count ?? 0}");

            if (listaproducto == null || listaproducto.Count == 0)
            {
                MessageBox.Show("No se recibieron productos.");
                return;

            }

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listaproducto;

            if (dgvListaProductos != null)  //verifico el datagridview
            {
                dgvListaProductos.DataSource = bindingSource1;

                dgvListaProductos.Columns["fechabaja"].Visible = false;
                dgvListaProductos.Columns["idproveedor"].Visible = false;
                dgvListaProductos.Columns["idUsuario"].Visible = false;

                // Verificar el contenido del DataGridView
                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    Console.WriteLine($"Row: {row.Index}, Nombre: {row.Cells["nombre"].Value}");

                }



            }
            else
            {
                MessageBox.Show("dvgListaProductos no está inicializado correctamente.");


            }

        }



        private void FormListaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
