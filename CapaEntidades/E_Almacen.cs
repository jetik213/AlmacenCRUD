using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Almacen
    {
        private int _idAlmacen;
        private string _codigoAlmacen;
        //private string _rucAlmacen; //RUC de empresa que se subcontrata, considero mejor reitrar 
        private string _nombreAlmacen;
        private string _ubicacionAlmacen;
        private string _direccionAlmacen;
        private int _capacidadAlmacen;
        private string _obsAlmacen;
        private string _activoAlmacen;

        public int IdAlmacen { get => _idAlmacen; set => _idAlmacen = value; }
        public string CodigoAlmacen { get => _codigoAlmacen; set => _codigoAlmacen = value; }

        //public string RucAlmacen { get => _rucAlmacen; set => _rucAlmacen = value; }
        public string NombreAlmacen { get => _nombreAlmacen; set => _nombreAlmacen = value; }
        public string UbicacionAlmacen { get => _ubicacionAlmacen; set => _ubicacionAlmacen = value; }
        public string DireccionAlmacen { get => _direccionAlmacen; set => _direccionAlmacen = value; }
        public int CapacidadAlmacen { get => _capacidadAlmacen; set => _capacidadAlmacen = value; }
        public string ObsAlmacen { get => _obsAlmacen; set => _obsAlmacen = value; }
        public string ActivoAlmacen { get => _activoAlmacen; set => _activoAlmacen = value; }
    }
}