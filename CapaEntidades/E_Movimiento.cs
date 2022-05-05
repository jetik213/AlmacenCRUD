using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Movimiento
    {
        private int _idAlmacen;
        private int _idProducto;
        private int _idUsuario;
        private int _idEmpresa;
        private string _cantidad;
        private string _guia;
        private string _obsMov;

        public int IdAlmacen { get => _idAlmacen; set => _idAlmacen = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Guia { get => _guia; set => _guia = value; }
        public string ObsMov { get => _obsMov; set => _obsMov = value; }
    }
}