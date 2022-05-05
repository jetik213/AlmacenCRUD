using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Login
    {
        private int _idusuario;
        private String _nombre;
        private String _cargo;
        private String _loginUsuario;
        private String _claveUsuario;

        public int IdUsuario { get => _idusuario; set => _idusuario = value; }
        public String Nombre { get => _nombre; set => _nombre = value; }
        public String Cargo { get => _cargo; set => _cargo = value; }
        public String LoginUsuario { get => _loginUsuario; set => _loginUsuario = value; }
        public String ClaveUsuario { get => _claveUsuario; set => _claveUsuario = value; }
    }
}
