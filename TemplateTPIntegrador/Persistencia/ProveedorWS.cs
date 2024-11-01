using Datos;
using Persistencia.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Datos.Proveedor;

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


        public static void BajaProveedor(string id, string idAdmin)
        {
            String path = "/api/Proveedor/BajaProveedor";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", id);
            map.Add("idUsuario", idAdmin);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.\nVerifique los datos ingresados");
            }
            else
            {
                Console.WriteLine("Proveedor dado de baja correctamente");
            }
        }


        public void AgregarProveedor(PostProveedor postProveedor)
        {
            String path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(postProveedor);

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
