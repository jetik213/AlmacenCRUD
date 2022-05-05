using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Mov
    {
        private int _idMov;
        private int _idAlmacen;
        private string _nomAlmacen;
        private int _idProducto;
        private string _nomProducto;
        private int _idUsuario;
        private string _nomUsuario;
        private int _idEmpresa;
        private string _nomEmpresa;
        private string _cantidad;
        private string _guia;
        private string _obsMov;

        public int IdMov { get => _idMov; set => _idMov = value; }
        public int IdAlmacen { get => _idAlmacen; set => _idAlmacen = value; }
        public string NomAlmacen { get => _nomAlmacen; set => _nomAlmacen = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string NomProducto { get => _nomProducto; set => _nomProducto = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string NomUsuario { get => _nomUsuario; set => _nomUsuario = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string NomEmpresa { get => _nomEmpresa; set => _nomEmpresa = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Guia { get => _guia; set => _guia = value; }
        public string ObsMov { get => _obsMov; set => _obsMov = value; }
    }
}
