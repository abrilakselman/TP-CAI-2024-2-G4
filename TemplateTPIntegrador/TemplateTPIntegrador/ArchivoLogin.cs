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
    public class ArchivoLogin
    {
        private int reintentos { get => 3; }
        private string carpeta { get => @"C:\Grupo4"; }  //se van a guardar los archivos en c:/
        private string archivo { get => "datos.json"; }
        private string rutaCompleta { get => Path.Combine(carpeta, archivo); }

        public ArchivoLogin()
        {
            CrearArchivo();
        }

        private void CrearArchivo() //Verifica si la carpeta y el archivo existen. Si no, los crea.
        {
            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

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


        //Registra un intento de inicio de sesión fallido para un usuario específico
        public bool GuardarLoginFallido(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            List<LogFormato> list = RecuperarRegistros();
            LogFormato usuarioExistente = list.FirstOrDefault(x => x.Usuario == usuario);

            if (usuarioExistente != null)
            {
                usuarioExistente.Intentos++;
            }
            else
            {
                LogFormato usuarioLog = new LogFormato(usuario);
                usuarioLog.Intentos = 1;
                list.Add(usuarioLog);
            }

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);

            return ConsultarReintentos(usuarioExistente);
        }



        //Verifica si un usuario tiene reintentos disponibles
        public bool TieneReintentos(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            List<LogFormato> list = RecuperarRegistros();
            LogFormato usuarioExistente = list.FirstOrDefault(x => x.Usuario == usuario);

            return ConsultarReintentos(usuarioExistente);
        }


        //Retorna true si el usuario tiene reintentos disponibles
        private bool ConsultarReintentos(LogFormato usuarioExistente)
        {
            return usuarioExistente == null || usuarioExistente.Intentos < reintentos;
        }


        //Restablece los intentos fallidos del usuario y actualiza la fecha del último login.
        public void ActualizarLogin(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            }

            List<LogFormato> list = RecuperarRegistros();
            LogFormato usuarioExistente = list.FirstOrDefault(x => x.Usuario == usuario);

            if (usuarioExistente != null)
            {
                usuarioExistente.Intentos = 0;
                usuarioExistente.UltimoLogin = DateTime.Now;
            }
            else
            {
                LogFormato usuarioLog = new LogFormato(usuario);
                usuarioLog.Intentos = 1;
                list.Add(usuarioLog);
            }

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);
        }


        //Recupera la lista de registros de intentos de login desde el archivo JSON.
        private List<LogFormato> RecuperarRegistros()
        {
            try
            {
                var file = File.ReadAllText(rutaCompleta);
                if (string.IsNullOrEmpty(file))
                {
                    return new List<LogFormato>();
                }
                return JsonConvert.DeserializeObject<List<LogFormato>>(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al recuperar registros: {ex.Message}");
                return new List<LogFormato>(); // Devuelve una lista vacía en caso de error
            }
        }
    }

}
