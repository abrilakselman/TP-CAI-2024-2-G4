using Datos.Ventas;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaNegocio
    {

        VentaWS ventaWS = new VentaWS();
        public List<Venta> Listar(Guid idCliente)
        {
            
            return ventaWS.Listar<Venta>(idCliente);
        }

        public void CrearVenta(Guid idCliente, Guid idProducto, Guid idUsuario, int cantidad)
        {
            
            VentaPost ventaPost = new VentaPost(idCliente, idUsuario, idProducto, cantidad);

            ventaWS.Crear(ventaPost);
        }

    }
}
