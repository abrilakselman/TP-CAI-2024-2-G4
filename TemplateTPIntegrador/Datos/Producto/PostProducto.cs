using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Producto
{
    public class PostProducto
    {
        int _idcategoria;
        string _idusuario;
        string _idproveedor;
        string _nombre;
        double _precio;
        int _stock;

        public PostProducto(int idcategoria, string idusuario, string idproveedor, string nombre, double precio, int stock)
        {
            _idcategoria = idcategoria;
            _idusuario = idusuario;
            _idproveedor = idproveedor;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }

        public int idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public string idusuario { get => _idusuario; set => _idusuario = value; }
        public string idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public double precio { get => _precio; set => _precio = value; }
        public int stock { get => _stock; set => _stock = value; }
    }
}
