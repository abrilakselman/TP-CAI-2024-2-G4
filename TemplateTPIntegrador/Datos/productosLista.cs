using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class productosLista
    {
        string _id;
        string _valor;

        public productosLista(string id, string valor)
        {
            _id = id;
            _valor = valor;
        }
        public string Id { get => _id; set => _id = value; }
        public string Valor { get => _valor; set => _valor = value; }
    }
}
