using Datos;
using Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProveedorWS
    {

        //Lista todos los proveedores con el swagger TraerProveedores



        public List<Proveedor> TraerProveedores()
        {
            //String path = "/api/Proveedor/TraerProveedores";
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                HttpResponseMessage response = WebHelper.Get("/api/Proveedor/TraerProveedores");
                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                Console.WriteLine($"Response Reason Phrase: {response.ReasonPhrase}");

                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(contentStream))
                    {
                        proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
                        Console.WriteLine($"Número de proveedores recibidos: {proveedores.Count}");
                        if (proveedores == null || proveedores.Count == 0)
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
            return proveedores;
        }






    }

}
