using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Persona
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public Guid ID { get; set; }    
        public DateTime fechaalta { get; set; }
        public DateTime fechabaja { get; set; } 

    }
}
