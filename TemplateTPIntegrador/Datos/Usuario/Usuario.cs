using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Usuario
{
    public class Usuario
    {
        //constructores del usuario


        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        //public bool Estado { get; set; }  --> posiblemente se use despues, por ahora esta comentado
        public int Host { get; set; }

        public Usuario(string nombre, string apellido,string direccion,string telefono, string email, string nombreusuario, 
            string contraseña, int dni, DateTime fechaNacimiento, int host) 
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            NombreUsuario = nombreusuario;
            Contraseña = contraseña;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = DateTime.Now;
            Host = host;
        }


    }
}
