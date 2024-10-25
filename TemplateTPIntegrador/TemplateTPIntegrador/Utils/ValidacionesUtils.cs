using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
        public bool validarSoloLetras(KeyPressEventArgs evento)
        {
            bool esValido = char.IsLetter(evento.KeyChar) || char.IsControl(evento.KeyChar);
            evento.Handled = !esValido;
            return esValido;
        }
        public bool validarSoloCorreo(KeyPressEventArgs evento)
        {
            // Permite letras, números, '@', '.', '-' y teclas de control como Backspace.
            bool esValido = char.IsLetterOrDigit(evento.KeyChar) || evento.KeyChar == '@' || evento.KeyChar == '.' || evento.KeyChar == '-' || char.IsControl(evento.KeyChar);
            evento.Handled = !esValido;
            return esValido;
        }

        public bool validarNumyNeg(string num)
        {
            if (!int.TryParse(num, out int n))
            {
                return true;
            }
            if (n <= 0)
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
