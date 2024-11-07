using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador
{
    public class LogFormato
    {
        string _usuario;
        int _intentos;
        DateTime _ultimoLogin;
        int _rol;
        public LogFormato(string usuario)
        {
            _usuario = usuario;
        }
        public LogFormato()
        {
        }
        public DateTime UltimoLogin { get => _ultimoLogin; set => _ultimoLogin = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int Intentos { get => _intentos; set => _intentos = value; }
        public int Rol { get => _rol; set => _rol = value; }

    }
}
