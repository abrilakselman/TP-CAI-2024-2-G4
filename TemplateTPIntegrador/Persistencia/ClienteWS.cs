using Datos.Cliente;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClienteWS
    {

        public List<Cliente> GetCliente()
        {
            
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                HttpResponseMessage response = WebHelper.Get("/api/Cliente/GetClientes");
                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                Console.WriteLine($"Response Reason Phrase: {response.ReasonPhrase}");

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(contentStream))
                    {
                        clientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
                        Console.WriteLine($"Número de clientes recibidos: {clientes.Count}");
                        if (clientes == null || clientes.Count == 0)
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
                    Console.WriteLine($"Error encontrado: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return clientes;
        }
        






    }
}
