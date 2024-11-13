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
    public class VentaWS
    {

        public string pathCrear { get; set; }


        public List<T> Listar<T>(Guid idCliente)
        {
            String path = "/api/Venta/GetVentaByCliente?id=" + idCliente;

            List<T> resultado = new List<T>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<T> listadoClientes = JsonConvert.DeserializeObject<List<T>>(contentStream);
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
            return resultado;
        }

        public void Crear<T>(T postData)
        {
            var jsonRequest = JsonConvert.SerializeObject(postData);

            try
            {
                HttpResponseMessage response = WebHelper.Post(pathCrear, jsonRequest);
                if (!response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception(respuesta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
