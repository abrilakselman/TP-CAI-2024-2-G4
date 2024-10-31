using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* //SE LO COMENTA PORQUE NO LLENABA EL DATAGRID CON LOS PROVEEDORES Y NO NOS DAMOS CUENTA DONDE ESTA MAL APLICADA LA HERENCIA EN ESTE CASO
public class Proveedor : Persona
{
    public string cuit { get; set; }
    public string categorias { get; set; }




    //public string nombre { get; set; }   --> se puede eliminar, esta en persona

    //public Proveedor(string nombre, string apellido, string email, DateTime fechaAlta, DateTime fechaBaja, string cuit, string categorias) { }
    //uso el heredado

    public Proveedor(string nombre, string apellido, string email, DateTime fechaalta, DateTime fechabaja, string cuit,
        string categorias) : base(nombre, apellido, email, fechaalta, fechabaja)
    {
        this.cuit = cuit;
        this.categorias = categorias;
    }

   
}

*/


//NUEVOS CONSTRUCTORES - sin herencia
public class Proveedor
{
    public Guid Id { get; set; }
    public string IdCategoria { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaAlta { get; set; }
    public DateTime? FechaBaja { get; set; }
    public string CUIT { get; set; }
    public string Email { get; set; }
    
    public Proveedor(Guid id, string idCategoria, string nombre, string apellido, DateTime fechaAlta, string cuit, string email)
    {
        Id = id;
        IdCategoria = idCategoria;
        Nombre = nombre;
        Apellido = apellido;
        FechaAlta = fechaAlta;
        CUIT = cuit;
        Email = email;
        
    }

    public override string ToString()
    {
        return $"{Nombre} {Apellido} {CUIT}";
    }

}