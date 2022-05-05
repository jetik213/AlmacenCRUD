using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Producto
    {
        private int _idProducto;
        private string _codigoProducto;
        private string _nombreProducto;
        private string _origenProducto;
        private int _estadoProducto;
        private string _empaqueProducto;
        private string _abreviaturaProducto;
        private string _obsProducto;
        private string _activoProducto;

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }
        public string OrigenProducto { get => _origenProducto; set => _origenProducto = value; }
        public int EstadoProducto { get => _estadoProducto; set => _estadoProducto = value; }
        public string EmpaqueProducto { get => _empaqueProducto; set => _empaqueProducto = value; }
        public string AbreviaturaProducto { get => _abreviaturaProducto; set => _abreviaturaProducto = value; }
        public string ObsProducto { get => _obsProducto; set => _obsProducto = value; }
        public string ActivoProducto { get => _activoProducto; set => _activoProducto = value; }


    }
}