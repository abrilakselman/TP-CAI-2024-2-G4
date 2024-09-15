using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        private ValidacionesUtils _validacionesUtils;
        public bool Login(string usuario, string contraseña)
        {
            _validacionesUtils = new ValidacionesUtils();

            if (_validacionesUtils.validarNombreUsuario(usuario) && _validacionesUtils.validarContraseñaUsuario(contraseña))
            {
                return usuario == "usuarioValido" && contraseña == "contraseñaValida";
            }
            return false;

        }
    }
}
