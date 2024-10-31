using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cliente : PersonaCliente
{

    public int idUsuario { get; set; }
    public string host { get; set; }

    public Cliente(string nombre, string apellido, string email, DateTime fechaalta, DateTime fechabaja,
        string direccion, string telefono, int dni, DateTime fechaNacimiento, int idUsuario, string host)
        : base(nombre, apellido, email, fechaalta, fechabaja, direccion, telefono, dni, fechaNacimiento)
    {
        this.idUsuario = idUsuario;
        this.host = host;
    }

    public override string ToString()
    {
        return $"{nombre} {apellido} {direccion}";
    }

}


