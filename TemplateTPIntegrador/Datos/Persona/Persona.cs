﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Persona
{

    public Guid id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string email { get; set; }
           
    public DateTime fechaalta { get; set; }
    public DateTime fechabaja { get; set; }

    //constructor//
    public Persona(string nombre, string apellido, string email,Guid id, DateTime fechaalta, DateTime fechabaja)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.id = id;
        this.fechaalta = DateTime.Now;
        this.fechabaja = fechabaja;

    }

    //constructor para usar con proveedores
    public Persona(string nombre, string apellido, string email, DateTime fechaalta, DateTime fechabaja)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.fechaalta = DateTime.Now;
        this.fechabaja = fechabaja;
    }
}