using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class ValidacionesUtils
    {

        public Boolean valudarNombreUsuario(string usuario)
        {
            if (usuario.Length <=8)
            {
                return true;
            }
            else { MessageBox.Show("el usuario no debe contener mas de 8 caracteres"); 
            return false;
            }



        }
    }
}
