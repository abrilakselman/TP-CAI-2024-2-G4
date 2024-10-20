using Datos.Producto;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProductoWS
    {
        public List<Producto> TraerProductos()
        {
            String path = "/api/Producto/TraerProductos";
            List<Producto> productos = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return listadoProductos;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return productos;

        }

        public List<Producto> TraerProductosPorCategoria(int categoria)
        {
            String path = $"/api/Producto/TraerProductosPorCategoria?catnum=" + categoria;
            List<Producto> resultado = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Producto> listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                    return listadoProductos;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return resultado;
        }






    }
}
