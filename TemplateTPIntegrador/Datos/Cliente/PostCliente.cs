using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cliente
{
    public class PostCliente
    {
        string _nombre;
        string _apellido;
        int _dni;
        string _direccion;
        string _telefono;
        string _email;
        Guid _idUsuario;
        DateTime _fechaNacimiento;
        string _host;

        public PostCliente(string nombre, string apellido, int dni, string direccion, string telefono, string email, Guid idUsuario, DateTime fechaNacimiento, string host)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _idUsuario = idUsuario;
            _fechaNacimiento = fechaNacimiento;
            _host = host;

        }

        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public int dni { get => _dni; set => _dni = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string host { get => _host; set => _host = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
