using Datos;
using Datos.Proveedor;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProveedorNegocio
    {
        /*
         * Id creado y usado por el grupo
            "nombreUsuario": "Admin091800",
            "contraseña": "CAI20232"
         */
        private String idAdmin = "4f3cfd0b-ba68-4f31-a8a5-63892d7e0c6f"; 


        ProveedorWS proveedorWS = new ProveedorWS();

        public List<Proveedor> ListarProveedores()
        {
            //ProveedorWS proveedorWS = new ProveedorWS();
            return proveedorWS.TraerProveedores(); //llama al swagger
        }

        public void BajaProveedor(String idProveedor)
        {
            ProveedorWS.BajaProveedor(idProveedor, idAdmin);
        }

        public void agregarProveedor(string idUsuario, string nombre, string apellido, string email, string cuit)
        {
            PostProveedor postProveedor = new PostProveedor(idUsuario, nombre, apellido, email, cuit);
            proveedorWS.AgregarProveedor(postProveedor);
        }



    }
}
