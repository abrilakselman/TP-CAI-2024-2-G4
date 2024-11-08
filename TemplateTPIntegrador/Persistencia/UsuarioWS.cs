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
       
        //metodo para LogIn del swagger
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
                    throw new Exception("Cuenta inactiva (Cod.50687). Porfavor contactese con el Administrador");
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception("Las credenciales ingresadas son incorrectas. Vuelva a intentar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        //metodo de TraerUsuariosActivos del swagger

        public List<Usuario> TraerUsuariosActivos(Guid idadmin)
        {
            String path = "/api/Usuario/TraerUsuariosActivos?id=" + idadmin;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Usuario> listadoUsuariosActivos = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
                    return listadoUsuariosActivos;
                }
                else
                {
                    Console.WriteLine($"Código de Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return usuarios;

        }



        //segundo metodo de login para obtener el rol
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
            if (usuarioRol != null)
            {
                int rol = usuarioRol["host"].Value<int>(); // me aseguro que el campo sea correcto
                return rol;
            }
            return 0; // Usuario no encontrado
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

        public static void BajaUsuario(string idUsuario)
        {
            String IdUsuarioMaster = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f";
            String path = "/api/Usuario/BajaUsuario";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", IdUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.\nVerifique los datos ingresados");
            }
            else
            {
                Console.WriteLine("Usuario dado de baja correctamente");
            }
        }

        public void AgregarUsuario(UsuarioPost usuarioPost)
        {
            String path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(usuarioPost);

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


        public DateTime VerFechaAltaUsuario(string usuario, string idAdmin)
        {
            JToken usuariofechaAlta = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            DateTime fechaAlta = DateTime.Now;
            return fechaAlta;
        }


        public void CambiarContraseña(String nombreUsuario, String contraseña, String contraseñaNueva)
        {
            String path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Cambio contraseña exitoso: {response.StatusCode} - {response.ReasonPhrase}");
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
        }


        public void ReactivarUsuario(Guid id, Guid idUsuario)
        {
            String path = "/api/Usuario/ReactivarUsuario";

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("idUsuario", idUsuario.ToString());

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
        }


    }
}
