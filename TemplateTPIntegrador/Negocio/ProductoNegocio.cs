using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;


namespace Negocio
{
    public class ProductoNegocio
    {

        ProductoWS productoWS = new ProductoWS();


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


    }
}
