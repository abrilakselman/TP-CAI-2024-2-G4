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

    }
}
