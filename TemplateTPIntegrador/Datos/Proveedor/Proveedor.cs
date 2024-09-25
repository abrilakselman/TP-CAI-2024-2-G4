using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Proveedor
{
    public class Proveedor
    {
        public string cuit { get; set; }
        public string categorias { get; set; }

        public Proveedor(string nombre, string apellido, string email, DateTime fechaAlta, DateTime fechaBaja, string cuit, string categorias) { }
        
       
    }
}
