using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Usuario
{
    public class UsuarioWSLogin
    {
        
        //datos para el metodo de login del WS
        string _NombreUsuario;
        string _Contraseña;

        public UsuarioWSLogin(string nombreUsuario, string contraseña)
        {
            _NombreUsuario = nombreUsuario;
            _Contraseña = contraseña;
        }

        public string nombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string contraseña { get => _Contraseña; set => _Contraseña = value; }
    }
}
