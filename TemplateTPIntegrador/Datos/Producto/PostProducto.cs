using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Producto
{
    public class PostProducto
    {
        Guid _idcategoria;
        Guid _idUsuario;
        Guid _idproveedor;
        string _nombre;
        double _precio;
        int _stock;

        public PostProducto(Guid idcategoria, Guid idUsuario, Guid idproveedor, string nombre, double precio, int stock)
        {
            _idcategoria = idcategoria;
            _idUsuario = idUsuario;
            _idproveedor = idproveedor;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }

        public Guid idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public Guid idusuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public double precio { get => _precio; set => _precio = value; }
        public int stock { get => _stock; set => _stock = value; }
    }
}
