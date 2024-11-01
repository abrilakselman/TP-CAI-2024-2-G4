using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cliente
{
    public class Clientes
    {

        public String id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int dni { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaalta { get; set; }
        public DateTime fechabaja { get; set; }
        public String host { get; set; }

        public Clientes() { }
        public Clientes(string id, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechanacimiento, string host)
        {
            id = id;
            nombre = nombre;
            apellido = apellido;
            dni = dni;
            direccion = direccion;
            telefono = telefono;
            email = email;
            fechanacimiento = fechaNacimiento;
            host = host;
        }

        public Clientes(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechanacimiento)
        {
            nombre = nombre;
            apellido = apellido;
            dni = dni;
            direccion = direccion;
            telefono = telefono;
            email = email;
            fechanacimiento = fechaNacimiento;

        }
    }
}
