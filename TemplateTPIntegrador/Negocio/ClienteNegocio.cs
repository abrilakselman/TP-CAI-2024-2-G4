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
            
            return clienteWS.GetClientes();

        }

        public List<Clientes> ListarCliente2()
        {

            return clienteWS.getClientes();

        }



    }
}
