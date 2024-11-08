using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador
{
    public class UsuarioInactivoFormato
    {

        string _usuario;
        string _contraseña;
        string _id;
        int _host;
        int _primerIngreso;
        public UsuarioInactivoFormato(string usuario, string contraseña, string id, int host)
        {
            _usuario = usuario;
            _contraseña = contraseña;
            _id = id;
            _host = host;
        }
        public UsuarioInactivoFormato()
        {
        }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Id { get => _id; set => _id = value; }
        public int Host { get => _host; set => _host = value; }
        public int PrimerIngreso { get => _primerIngreso; set => _primerIngreso = value; }


    }
}
