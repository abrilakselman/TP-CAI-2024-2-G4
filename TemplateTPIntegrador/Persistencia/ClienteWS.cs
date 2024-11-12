using Datos.Cliente;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClienteWS
    {

        public List<Clientes> getClientes()
        {
            String path = "/api/Cliente/GetClientes";
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Clientes> listadoClientes = JsonConvert.DeserializeObject<List<Clientes>>(contentStream);
                    return listadoClientes;
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
            return clientes;

        }



        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                HttpResponseMessage response = WebHelper.Get("/api/Cliente/GetClientes");
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Response Content: {contentStream}"); // Imprimir el contenido de la respuesta en la consola
                    clientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
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
            return clientes;
        }


        public void BajaCliente(Guid idCliente)
        {
            String path = "/api/Cliente/BajaCliente?id=" + idCliente;

            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }



        public Cliente BuscarUnCliente(Guid id)
        {
            String path = "/api/Cliente/GetCliente?id=" + id;
          
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Cliente clienteBuscado = JsonConvert.DeserializeObject<Cliente>(contentStream);

                    return clienteBuscado;
                }
                else
                {
                    Console.WriteLine($"Error en búsqueda de cliente: {response.StatusCode} - {response.ReasonPhrase}");
                    throw new Exception("Excepcion");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw ex;
            }

        }


        public void PatchCliente(Guid idCliente, String direccion, String telefono, String email)
        {
            String path = "/api/Cliente/PatchCliente";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idCliente.ToString());
            map.Add("direccion", direccion);
            map.Add("telefono", telefono);
            map.Add("email", email);

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
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
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
