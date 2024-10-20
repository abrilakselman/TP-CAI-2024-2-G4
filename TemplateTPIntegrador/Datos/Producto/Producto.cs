using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Producto
{
    public class Producto
    {
        //aclaracion: todos los id por ahora, los pongo con GUID (a chequear)
        public string nombre {  get; set; }
        public Guid id { get; set; }

        public Guid idcategoria { get; set; }
        public DateTime fechaalta { get; set; }
        public DateTime fechabaja { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public Guid idusuario { get; set; }

        public Guid idproveedor { get; set; }

        public bool stockBajo { get; set; } //calculo del sotck bajo de cada producto segun categoria


        public Producto(string nombre, Guid id, Guid idcategoria, DateTime fechaalta, DateTime fechabaja, double precio, int stock, Guid idusuario, Guid idproveedor)
        {
            this.nombre = nombre;
            this.id = id;
            this.idcategoria = idcategoria;
            this.fechaalta = DateTime.Now;
            this.fechabaja = fechabaja;
            this.precio = precio;
            this.stock = stock;
            this.idusuario = idusuario;
            this.idproveedor = idproveedor;
        }
    }
}
