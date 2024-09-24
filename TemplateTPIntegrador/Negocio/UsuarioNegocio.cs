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
            "contraseña": "Adm1inadm1n"
         */
        private String idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f";
        UsuarioWS usuarioWS = new UsuarioWS();

        /*
        public Guid LogIn(string usuario, string password)
        {
            UsuarioWSLogin usuarioLogInReq = new UsuarioWSLogin(usuario, password);

            return UsuarioWS.LogIn(usuarioLogInReq);
        }*/

        public int LogInRol(string usuario, string contraseña)
        {
            // 1. usar logica de login para comprobar si existe
            UsuarioWSLogin usuarioDatos = new UsuarioWSLogin(usuario, contraseña);

            int loginComprobado = usuarioWS.Login(usuarioDatos);


            // buscar rol 
            if (loginComprobado == 1)
            {
                // 1 vendedor, 2 supervisor, 3 administrador
                loginComprobado = usuarioWS.BuscarRol(usuario, idAdmin);

            }

            
            return loginComprobado;
        }
    }

}
