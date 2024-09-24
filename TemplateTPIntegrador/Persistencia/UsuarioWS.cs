using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos.Usuario;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Persistencia
{
    public class UsuarioWS
    {
       
        //metodo alternativo
        public Guid LogIn(UsuarioWSLogin usuarioLogIn)
        {
            String path = "/api/Usuario/LogIn";

            var jsonRequest = JsonConvert.SerializeObject(usuarioLogIn);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    return Guid.Parse(respuesta.Replace(@"""", ""));
                }
                else if (((int)response.StatusCode) == 403)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception("Cuenta inactiva");
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception("Credenciales incorrectas");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        //segundo metodo de intento
        //metodos para saber el rol del user y derivarlo a la pantalla correcta

        public int Login(UsuarioWSLogin Login)
        {
            int valor = 0;
            {
                String path = "/api/Usuario/Login";

                var jsonRequest = JsonConvert.SerializeObject(Login);
                Console.WriteLine("Usuario ingresado:" + Login.nombreUsuario + "Contraseña ingresada:" + Login.contraseña);
                try
                {
                    HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                    if (response.IsSuccessStatusCode)
                    {
                        var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                        string respuesta = reader.ReadToEnd();
                        Console.WriteLine("Login request was successful.");
                        valor = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Login request failed with status code {response.StatusCode}.");
                        valor = -1;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"A Login error occurred: {ex.Message}");

                }
                return valor;

            }
        }

       public string TraerUsuariosActivos(String idAdmin)
        {

            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Usuario/TraerUsuariosActivos?id={idAdmin}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

       
        public JToken BuscarUsuarioPorNombreUsuario(string usuario, String idAdmin)
        {
            // Busca en los usuarios activos a un usuario por el id
            string content = TraerUsuariosActivos(idAdmin);
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);

            JToken usuarioEncontrado = jsonArray.FirstOrDefault(item => (string)item["nombreUsuario"] == usuario);

            return usuarioEncontrado;
        }

        public int RolUsuarioWS(string usuario, string idAdmin)
        {
            JToken usuarioRol = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            int rol = usuarioRol["host"].Value<int>();
            return rol;
        }

        //Fin


        //Otros metodos a crear del swagger/Usuario
        /*
         * AgregarUsuario
         * CambiarContraseña
         * BajaUsuario
         * ReactivarUsuario
         * */

        //Analizar como agregar el contador de los intentos de acceso

    }
}
