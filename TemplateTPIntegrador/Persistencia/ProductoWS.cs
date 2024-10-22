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
        /*
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
        */

        public List<Producto> TraerProductos()
        {
            //String path = "/api/Producto/TraerProductos";
            List<Producto> productos = new List<Producto>();
            try
            {
                HttpResponseMessage response = WebHelper.Get("/api/Producto/TraerProductos");
                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                Console.WriteLine($"Response Reason Phrase: {response.ReasonPhrase}");

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Content Stream: {contentStream}");

                    if (!string.IsNullOrEmpty(contentStream))
                    {
                        productos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                        Console.WriteLine($"Número de productos recibidos: {productos.Count}");

                        if (productos == null || productos.Count == 0)
                        {
                            Console.WriteLine("La lista deserializada es nula o está vacía.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El contenido de la respuesta está vacío.");
                    }
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
                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                Console.WriteLine($"Response Reason Phrase: {response.ReasonPhrase}");

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Content Stream: {contentStream}");

                    if (!string.IsNullOrEmpty(contentStream))
                    {
                        resultado = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
                        Console.WriteLine($"Número de productos recibidos: {resultado.Count}");

                        if (resultado == null || resultado.Count == 0)
                        {
                            Console.WriteLine("La lista deserializada es nula o está vacía.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El contenido de la respuesta está vacío.");
                    }
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
