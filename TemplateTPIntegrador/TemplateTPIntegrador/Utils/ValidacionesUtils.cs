using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public class ValidacionesUtils
    {
        public bool validarStringVacio(string dato)
            {
             if (dato == "")
            {
                return true;
            }
            return false;


        }

        public bool validarSoloNumeros (KeyPressEventArgs evento)
        { bool esValido = char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar);
            evento.Handled = !esValido;
            return esValido;
        }
        
        public bool SoloNumerosConGuion(KeyPressEventArgs evento)
        {
            bool esValido = char.IsDigit(evento.KeyChar) || char.IsControl(evento.KeyChar) || char.Equals(evento.KeyChar, '-');
            evento.Handled = !esValido;
            return esValido;
        }









    }
}
