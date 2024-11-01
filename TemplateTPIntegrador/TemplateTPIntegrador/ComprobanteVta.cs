using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Ventas;

namespace TemplateTPIntegrador
{
    public class ComprobanteVta
    {
        // Propiedades privadas para la carpeta y archivo donde se guardan los datos
        private string carpeta { get => @"C:\G4"; }  // guarda en el disco C:
        private string archivo { get => "datosComprobante.json"; }
        private string rutaCompleta { get => Path.Combine(carpeta, archivo); }  // Combina la carpeta y el archivo en una ruta completa

        // Constructor de la clase
        public ComprobanteVta()
        {
            CrearArchivo();  // Llama al método para crear el archivo si no existe
        }

        // Método para crear el archivo y la carpeta si no existen
        private void CrearArchivo()
        {
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);  // Crea la carpeta si no existe
            }

            if (!File.Exists(rutaCompleta))
            {
                using (FileStream fs = File.Open(rutaCompleta, FileMode.Create, FileAccess.Write))
                {
                    // Crea el archivo si no existe
                }
            }
        }

        // Método para obtener el último ID de los comprobantes y sumar uno
        public int UltimoId()
        {
            var registros = RecuperarRegistros();  // Recupera los registros actuales
            int ultimoId = 0;
            if (registros.Count() > 0)
            {
                ultimoId = registros.Max(x => x.Id);  // Encuentra el ID máximo
            }
            return ultimoId + 1;  // Devuelve el siguiente ID
        }

        // Método para agregar un nuevo comprobante a la lista
        public void Agregar(int id, Cliente cliente, string path)
        {
            var registros = RecuperarRegistros();  // Recupera los registros actuales
            registros.Add(new Comprobante(id, cliente.id, cliente.ToString(), path, DateTime.Now));  // Agrega un nuevo comprobante

            string json = JsonConvert.SerializeObject(registros, Formatting.Indented);  // Convierte la lista a JSON
            File.WriteAllText(rutaCompleta, json);  // Escribe el JSON en el archivo
        }

        // Método para recuperar todos los registros de comprobantes
        public List<Comprobante> RecuperarRegistros()
        {
            var file = File.ReadAllText(rutaCompleta);  // Lee el contenido del archivo
            if (String.IsNullOrEmpty(file))
            {
                return new List<Comprobante>();  // Si el archivo está vacío, devuelve una lista vacía
            }
            return JsonConvert.DeserializeObject<List<Comprobante>>(file);  // Convierte el contenido JSON a una lista de comprobantes
        }

        // Método para eliminar un comprobante por su ID
        public void Eliminar(int id)
        {
            List<Comprobante> listaComprobantes = RecuperarRegistros();  // Recupera los registros actuales
            var eliminar = listaComprobantes.Find(x => x.Id == id);  // Encuentra el comprobante por su ID
            listaComprobantes.Remove(eliminar);  // Lo elimina de la lista

            string json = JsonConvert.SerializeObject(listaComprobantes, Formatting.Indented);  // Convierte la lista a JSON
            File.WriteAllText(rutaCompleta, json);  // Escribe el JSON actualizado en el archivo
        }
    }





}
