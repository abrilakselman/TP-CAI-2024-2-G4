using Datos.Producto;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
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


        //Borrar producto del swagger, pide id del producto y idusuario logueado

        public async Task BajaProducto(Guid id, Guid idUsuario)
        {
            string path = "/api/Producto/BajaProducto";
            var map = new Dictionary<string, string>
            {
                { "id", id.ToString() },
                { "idUsuario", idUsuario.ToString() }
            };
            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
                string respuesta = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Producto seleccionado eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine($"Error encontrado: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception(respuesta);
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HTTP Request Exception: {httpEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }


        //Modificar producto del swagger toma 4 parametros: id, idAdmin, precio y stock
        public void ModificarProducto(Guid id, string idAdmin, int precio, int stock)
        {

            String path = "/api/Producto/ModificarProducto";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idAdmin.ToString());
            map.Add("precio", precio.ToString());
            map.Add("stock", stock.ToString());

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex;
            }

            /*

            string path = "/api/Producto/ModificarProducto";
            var map = new Dictionary<string, string>
                {
                    {"id", id.ToString()},
                    {"idUsuario", idUsuario.ToString()},
                    {"precio", precio.ToString()},
                    {"stock", stock.ToString()}
                };
            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                var response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    using (var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                    {
                        string respuesta = reader.ReadToEnd();
                        // Procesar la respuesta según sea necesario
                    }
                }
                else
                {
                    using (var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                    {
                        string respuesta = reader.ReadToEnd();
                        Console.WriteLine($"Error encontrado: {response.StatusCode} - {response.ReasonPhrase}");
                        throw new Exception(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }*/
        }


        public void AgregarProducto(PostProducto Productopost)
        {
            String path = "/api/Producto/AgregarProducto";

            var jsonRequest = JsonConvert.SerializeObject(Productopost);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex;
            }
        }



    }
}
