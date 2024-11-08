using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TemplateTPIntegrador
{
    public class UsuarioInactivo
    {
        // Define la ruta de la carpeta y archivo JSON
        private string carpeta { get => @"C:\Grupo4"; }
        private string archivo { get => "UsersInactivos.json"; }
        private string rutaCompleta { get => Path.Combine(carpeta, archivo); }

        // Constructor que llama al método para crear el archivo
        public UsuarioInactivo()
        {
            CrearArchivo();
        }

        // Método para crear el archivo JSON si no existe
        private void CrearArchivo()
        {
            try
            {
                // Crear la carpeta si no existe
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                // Crear el archivo si no existe
                if (!File.Exists(rutaCompleta))
                {
                    using (FileStream fs = File.Open(rutaCompleta, FileMode.Create, FileAccess.Write))
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear archivo: {ex.Message}");
            }
        }

        // Método para guardar un usuario inactivo
        public void GuardarInactivo(string usuario, string contraseña, string id, int host)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(id) || host < 0)
            {
                throw new ArgumentException("Uno o más parámetros son inválidos.");
            }

            // Recuperar los registros actuales
            List<UsuarioInactivoFormato> list = RecuperarRegistros();
            UsuarioInactivoFormato usuarioLog = new UsuarioInactivoFormato(usuario, contraseña, id, host);

            // Configurar el primer ingreso basado en el valor del host
            if (usuarioLog.Host == 3)
            {
                usuarioLog.PrimerIngreso = 1;
            }
            else
            {
                usuarioLog.PrimerIngreso = 0;
            }

            // Agregar el nuevo registro a la lista y guardar en el archivo
            list.Add(usuarioLog);
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);
        }

        // Método para obtener el ID de un usuario basado en el usuario y contraseña
        public string ObtenerId(string usuario, string contraseña)
        {
            // Validar entradas
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos.");
            }

            // Recuperar los registros actuales
            List<UsuarioInactivoFormato> list = RecuperarRegistros();
            UsuarioInactivoFormato usuarioExistente = list.FirstOrDefault(x => x.Usuario == usuario && x.Contraseña == contraseña);

            // Validar que el usuario existe
            if (usuarioExistente == null)
            {
                throw new InvalidOperationException("Usuario o contraseña incorrectos.");
            }

            return usuarioExistente.Id;
        }

        // Método para actualizar el primer ingreso de un usuario
        public void ActualizarIngresos(string id)
        {
            // Validar entrada
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("El ID no puede estar vacío.");
            }

            // Recuperar los registros actuales
            List<UsuarioInactivoFormato> list = RecuperarRegistros();
            UsuarioInactivoFormato usuarioExistente = list.FirstOrDefault(x => x.Id == id);

            // Validar que el usuario existe
            if (usuarioExistente == null)
            {
                throw new InvalidOperationException("Usuario no encontrado.");
            }

            usuarioExistente.PrimerIngreso = 1;

            // Actualizar y guardar los registros
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);
        }

        // Método para recuperar los registros del archivo JSON
        private List<UsuarioInactivoFormato> RecuperarRegistros()
        {
            try
            {
                var file = File.ReadAllText(rutaCompleta);
                if (String.IsNullOrEmpty(file))
                {
                    return new List<UsuarioInactivoFormato>();
                }
                return JsonConvert.DeserializeObject<List<UsuarioInactivoFormato>>(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al recuperar registros: {ex.Message}");
                return new List<UsuarioInactivoFormato>(); // Devuelve una lista vacía en caso de error
            }
        }
    }



}
