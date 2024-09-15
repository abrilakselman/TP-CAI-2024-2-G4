using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ValidacionesUtils
    {

        //tanto el user y contraseña deben tener entre 8 y 15 caracteres.
        //podria haber usado 1 sola funcion que valide ambos
        public bool validarNombreUsuario(string usuario)
        {
            //user debe tener entre 8 y 15 caracteres
            if (usuario.Length <= 15 && usuario.Length >= 8)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool validarContraseñaUsuario(string contraseña)
        {
            //user debe tener entre 8 y 15 caracteres
            if (contraseña.Length <= 15 && contraseña.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
