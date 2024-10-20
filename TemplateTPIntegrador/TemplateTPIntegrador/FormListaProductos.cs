using Datos;
using Datos.Producto;
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
    public partial class FormListaProductos : Form
    {
        
        //Objetivo es listar los productos por CATEGORIA
        
        public FormMenuAdministrador FormMenuAdministrador;



        public FormListaProductos(FormMenuAdministrador formMenuAdministrador)
        {
            InitializeComponent();
            CargarListaProductoDVG();
            FormMenuAdministrador = formMenuAdministrador;
            List<productosLista> listacat = new List<productosLista>();  //de la entidad productosLista
            listacat.Add(new productosLista("0", "Todas"));
            listacat.Add(new productosLista("1", "Audio"));
            listacat.Add(new productosLista("2", "Celulares"));
            listacat.Add(new productosLista("3", "Electro Hogar"));
            listacat.Add(new productosLista("4", "Informática"));
            listacat.Add(new productosLista("5", "Smart TV"));

            comboBoxCatProducto.DisplayMember = "Valor";
            comboBoxCatProducto.ValueMember = "Id";

            comboBoxCatProducto.DataSource = listacat
                .OrderBy(x => x.Id)
                .ToList();
        }

        private void CargarListaProductoDVG()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();

            List<Producto> listaproducto = productoNegocio.ListarProducto();
            listaproducto = listaproducto.OrderBy(x => x.idcategoria).ToList();

            dvgListaProductos.DataSource = listaproducto;

            dvgListaProductos.Columns["fechaBaja"].Visible = false;
            dvgListaProductos.Columns["idProveedor"].Visible = false;
            dvgListaProductos.Columns["idUsuario"].Visible = false;

        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxCatProducto.SelectedIndex != 0)
            {
                ProductoNegocio productoNegocio = new ProductoNegocio();

                string categoria = comboBoxCatProducto.SelectedValue.ToString();

                List<Producto> listacat = productoNegocio.ListarCategoriadeProducto(Int32.Parse(categoria));
                listacat = listacat.OrderBy(Producto => Producto.nombre).ToList();

                dvgListaProductos.DataSource = listacat;
            }
            else
            {
                CargarListaProductoDVG();
            }
        }


        private void FormListaProductos_Load(object sender, EventArgs e)
        {

        }

        
    }
}
