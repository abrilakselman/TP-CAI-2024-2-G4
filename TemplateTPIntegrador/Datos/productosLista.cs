using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Datos
{
    public class productosLista
    {
        String _id;
        String _valor;

        public productosLista(string id, string valor)
        {
            _id = id;
            _valor = valor;
        }

        public productosLista(string valor)
        {
            
            _valor = valor;
        }
        public string Id { get => _id; set => _id = value; }
        public string Valor { get => _valor; set => _valor = value; }

        public override string ToString()
        {
            return Valor;
        }



    }
}
