using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public bool validarSoloNumeros(KeyPressEventArgs evento)
        {
            bool esValido = char.IsNumber(evento.KeyChar) || char.IsControl(evento.KeyChar);
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


        public bool validarIguales(string a, string b)
        {
            bool retorno = true;

            if (a == b)
            {
                retorno = false;
            }
            return retorno;
        }


        //Proveedor

        //cree uno auxiliar porque con los otros metodos no me daba bien, y no encontre problema
        public bool ValidarSoloLetrasProv(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false; // Devuelve falso si el string está vacío
            }
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false; // Devuelve falso si encuentra un carácter que no es una letra
                }
            }
            return true; // Devuelve verdadero si todos los caracteres son letras
        }


        public bool ValidarCUIT(string cuit)
        {
            // Verifica que el CUIT no esté vacío
            if (string.IsNullOrWhiteSpace(cuit))
            {
                return false;
            }

            // Verifica que el CUIT tenga exactamente 11 caracteres
            if (cuit.Length != 11)
            {
                return false;
            }

            // Verifica que todos los caracteres sean números
            foreach (char c in cuit)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Si pasa todas las validaciones, retorna true
            return true;
        }


        public static string ValidarCUIT_PB(string cuit)  //validacion creada especialmente para el picturebox
        {
            // Verifica que el CUIT no esté vacío
            if (string.IsNullOrWhiteSpace(cuit))
            {
                return "CUIT no puede estar vacio";
            }

            // Verifica que el CUIT tenga exactamente 11 caracteres
            if (cuit.Length != 11)
            {
                return "cuit no puede ser mas de 11 caracteres";
            }

            // Verifica que todos los caracteres sean números
            foreach (char c in cuit)
            {
                if (!char.IsDigit(c))
                {
                    return "cuit tiene que ser un numero";
                }
            }

            // Si pasa todas las validaciones, retorna true
            return cuit;
        }


        public bool ValidarEmailProv(string email)
        {
            // Convierte el email a minúsculas
            email = email.ToLower();

            // Verifica que no esté vacío
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            // Verifica que contenga '@'
            if (!email.Contains("@"))
            {
                return false;
            }

            // Verifica que termine con '.com'
            if (!email.EndsWith(".com") )
            {
                return false;
            }

            return true;
        }



        //Producto

        public static string ValidarNumero(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Error: el valor está vacío.";
            }

            if (!int.TryParse(input, out int numero))
            {
                return "Error: el valor no es un número válido.";
            }

            if (numero < 0)
            {
                return "Error: el número no puede ser negativo.";
            }

            return numero.ToString();

        }


        public bool ValidarSoloLetras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false; // Devuelve falso si el string está vacío
            }

            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false; // Devuelve falso si encuentra un carácter que no es una letra
                }
            }

            return true; // Devuelve verdadero si todos los caracteres son letras
        }



        //Usuario 


        public static bool ValidarPerfil(string perfilText, out int perfil)
        {
        return int.TryParse(perfilText, out perfil);
        }


        public static string ValidarNombre(string Text)
        {
            string nombre = Text.ToLower();

            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3 || nombre.Length > 50 || !Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                nombre = "\nError! Nombre no puede ser vacios, menos de 3 caracterses, mas de 50 caracteres ni contener carácteres especiales\n";
            }
            return nombre;
        }

        public static string ValidarApellido(string Text)
        {
            string apellido = Text.ToLower();

            if (string.IsNullOrEmpty(apellido) || apellido.Length < 3 || apellido.Length > 50 || !Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                apellido = "\nError! Apellido no puede ser vacios, menos de 3 caracterses, mas de 50 caracteres ni contener carácteres especiales\n";
            }
            return apellido;
        }


        public static int ValidarDNI(string text)
        {
            // Validar si el texto es nulo o su longitud no es la correcta
            if (string.IsNullOrEmpty(text) || text.Length < 7 || text.Length > 8)
            {
                return -1; // DNI incorrecto
            }

            // Intentar convertir el texto a un entero
            if (!int.TryParse(text, out int dni))
            {
                return -1; // No se pudo convertir a entero
            }

            return dni; // Retornar el DNI válido
        }


        public static string ValidarTelefono(string telefono)
        {

            string patron = @"^\d+$";

            if (!Regex.IsMatch(telefono, patron) || (telefono.Length < 8 || telefono.Length > 11))
            {
                telefono = "\nError! No es un Teléfono válido\n";
            }
            return telefono;
        }

        public static string ValidarEmail(string text)
        {
            string email = text.ToLower();

            if (!email.Contains("@") || !email.EndsWith(".com") )
            {
                email = "\nError! No es un mail válido\n";
            }
            return email;
        }

        public static string ValidarDireccion(string direccion)
        {
            if (string.IsNullOrEmpty(direccion) || direccion.Length < 3 || direccion.Length > 255)
            {
                direccion = "\nError! Direccion no puede ser vacios, menos de 3 caracterses ni mas de 255 caracteres\n";
            }
            return direccion;
        }

        public static DateTime ValidarFechaNac(DateTime fechaNacimiento)
        {

            {
                // Calcular la edad a partir de la fecha de nacimiento
                int edad = DateTime.Today.Year - fechaNacimiento.Year;

                // Ajustar la edad si aún no ha cumplido años este año
                if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }

                // Validar que la edad esté dentro del rango deseado
                if (edad <= 18 || edad >= 100)
                {
                    fechaNacimiento = Convert.ToDateTime("01/01/1800");
                }

            }
            return fechaNacimiento;
        }


        public void ValidarInfoButton(String txtIngresado, String txtValidado, PictureBox pbError, PictureBox pbValidado)
        {
            if (txtIngresado != txtValidado)
            {
                pbError.BringToFront();
            }
            else
            {
                pbValidado.BringToFront();
            }
        }


        //validarciones de acceso de user

        public bool validarMin(string campo, int min)
        {
            bool retorno = false;
            if (campo.Length < min)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool validarMax(string campo, int max)
        {
            bool retorno = false;
            if (campo.Length > max)
            {
                retorno = true;
            }
            return retorno;
        }




        public static string ValidarContraseña(string contraseña)
        {
            // Verifica que la contraseña no sea vacía
            if (string.IsNullOrEmpty(contraseña))
            {
                return string.Empty;
            }

            // Verifica que la contraseña tenga entre 8 y 15 caracteres
            if (contraseña.Length < 8 || contraseña.Length > 15)
            {
                return string.Empty;
            }

            // Verifica que la contraseña contenga al menos una letra mayúscula y un número
            bool contieneMayuscula = false;
            bool contieneNumero = false;

            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                {
                    contieneMayuscula = true;
                }
                if (char.IsDigit(c))
                {
                    contieneNumero = true;
                }
            }

            if (!contieneMayuscula || !contieneNumero)
            {
                return string.Empty;
            }

            // Verifica que la contraseña contenga solo letras y números
            if (!Regex.IsMatch(contraseña, @"^[a-zA-Z0-9]+$"))
            {
                return string.Empty;
            }

            // Si pasa todas las validaciones, retorna la contraseña
            return contraseña;


        }

        public bool longitudCampo(string txt, int inf, int sup)
        {
            bool esValido = (txt.Length < inf || txt.Length > sup);
            return esValido;
        }


        


    }

}



       
    
