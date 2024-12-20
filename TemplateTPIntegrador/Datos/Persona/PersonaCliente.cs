﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class PersonaCliente : Persona
{
    public string direccion { get; set; }
    public string telefono { get; set; }
    public int dni { get; set; }
    public DateTime fechaNacimiento { get; set; }

    public PersonaCliente(string nombre, string apellido, string email, DateTime fechaalta, DateTime fechabaja,
        string direccion, string telefono, int dni, DateTime fechaNacimiento) : base(nombre, apellido, email, fechaalta, fechabaja)
    {
        this.direccion = direccion;
        this.telefono = telefono;
        this.dni = dni;
        this.fechaNacimiento = fechaNacimiento;
    }

}

