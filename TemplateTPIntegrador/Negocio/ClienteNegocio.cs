using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;
using Datos.Cliente;

namespace Negocio
{
    public class ClienteNegocio
    {
        ClienteWS clienteWS = new ClienteWS();
        public List<Cliente> ListarCliente()
        {
            ClienteWS clienteWS = new ClienteWS();
            return clienteWS.GetClientes();

        }

        public List<Clientes> ListarCliente2()
        {

            return clienteWS.getClientes();

        }


        public void BajaCliente(Guid idCliente)
        {
            try
            {
                clienteWS.BajaCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente", ex);
            }
        }


        public Cliente BuscarUnCliente(Guid id)
        {
            
            return clienteWS.BuscarUnCliente(id);
        }

        public void ModificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {


            clienteWS.PatchCliente(idCliente, direccion, telefono, email);
        }


    }
}
