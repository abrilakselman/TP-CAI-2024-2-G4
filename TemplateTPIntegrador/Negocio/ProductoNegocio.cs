using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos.Producto;
using System.Xml.Linq;

namespace Negocio
{
    public class ProductoNegocio
    {

        ProductoWS productoWS = new ProductoWS();

        private String idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f";
        public List<Producto> ListarProducto()
        {
            ProductoWS productoWS = new ProductoWS();
            var productos = new List<Producto>();
            try
            {
                productos = productoWS.TraerProductos();
                Console.WriteLine($"Número de productos recibidos del WS: {productos.Count}");

                foreach (Producto producto in productos.Where(x => x.stock <= 10))
                {
                    producto.stockBajo = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
            }

            return productos;
        }


        /*
        public List<Producto> ListarProducto()
        {
            var productos = productoWS.TraerProductos();

            foreach (Producto producto in productos.Where(x => x.stock <= 10))
            {
                producto.stockBajo = true;
            }
            return productos;
        }*/



        public List<Producto> ListarCategoriadeProducto(int categoria)
        {
            ProductoWS productoWS = new ProductoWS();
            
            var productos = productoWS.TraerProductosPorCategoria(categoria);

            foreach (Producto producto in productos.Where(x => x.stock <= 10))
            {
                producto.stockBajo = true;
            }
            return productos;

        }

        public void BajaProducto(Guid id, Guid idUsuario)
        {
            productoWS.BajaProducto(id, idUsuario);
        }

        public void ModificarProducto(Guid id, string idAdmin, int precio, int stock)
        {
            productoWS.ModificarProducto(id, idAdmin, precio, stock);
        }

        public void agregarProducto(int idCategoria, string idAdmin, string idProveedor, string nombre, int precio, int stock)
        {
            PostProducto productoPost = new PostProducto(idCategoria, idAdmin, idProveedor, nombre, precio, stock);
            productoWS.AgregarProducto(productoPost);

        }


        


    }
}
