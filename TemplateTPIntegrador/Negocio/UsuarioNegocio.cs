using Datos.Usuario;
using Persistencia;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        /*
         * Id creado y usado por el grupo
            "nombreUsuario": "Admin091800",
            "contraseña": "CAI20232"
         */
        private String idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f";
        UsuarioWS usuarioWS = new UsuarioWS();

        //Son las llamadas a la capa de Persistencia
        public Guid LogIn(string usuario, string password)
        {
            UsuarioWSLogin usuarioLogInReq = new UsuarioWSLogin(usuario, password);

            return usuarioWS.LogIn(usuarioLogInReq);
        }

        public List<Usuario> ListaTraerUsuariosActivos()
        {
            //trate de no poner esta linea porque lo instancia afuera, pero el programa falla.
            //asi que la agregue dentro del metodo
            UsuarioWS usuarioWS = new UsuarioWS();
            return usuarioWS.TraerUsuariosActivos(Guid.Parse("4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f")); //paso como parametro el ID del administrador del grupo G4
        }



        //Funciones solo para saber el rol de cada usuario
        public int LogInRol(string usuario, string contraseña)
        {
            // 1. usar logica de login para comprobar si existe
            UsuarioWSLogin usuarioDatos = new UsuarioWSLogin(usuario, contraseña);

            int login = usuarioWS.Login(usuarioDatos);


            // buscar rol 
            if (login == 1)
            {
                // 1 vendedor, 2 supervisor, 3 administrador
                login = BuscarRol(usuario);

            }  
            return login;
        }

        public int BuscarRol(string usuario)
        {
            int rol = usuarioWS.RolUsuarioWS(usuario, idAdmin);
            return rol;
        }


        public void BajaUsuario(String idUsuario)
        {
            UsuarioWS.BajaUsuario(idUsuario);
        }


        public void AgregarUsuario(string idUsuario, int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            UsuarioPost usuarioPost = new UsuarioPost(idUsuario, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioWS.AgregarUsuario(usuarioPost);
        }


    }

}
