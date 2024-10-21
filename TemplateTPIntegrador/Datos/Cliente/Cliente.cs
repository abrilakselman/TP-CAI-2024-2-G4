using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Cliente : Persona
    {
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idUsuario { get; set; }

        public string host { get; set; }

        public Cliente(string nombre, string apellido, string email, Guid id, DateTime fechaalta, DateTime fechabaja, string direccion, string telefono, int dni, DateTime fechaNacimiento, int idUsuario, string host) : base(nombre,apellido,email, id, fechaalta,fechabaja)
        {
            this.direccion = direccion;
            this.telefono = telefono;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.idUsuario = idUsuario;
            this.host = host;

        }
    }


