using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Empresa
    {
        private int _idEmpresa;
        private string _codigoEmpresa;
        private string _rucEmpresa;
        private string _nombreEmpresa;
        private string _direccionEmpresa;
        private string _obsEmpresa;
        private string _activoEmpresa;

        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string CodigoEmpresa { get => _codigoEmpresa; set => _codigoEmpresa = value; }
        public string RucEmpresa { get => _rucEmpresa; set => _rucEmpresa = value; }
        public string NombreEmpresa { get => _nombreEmpresa; set => _nombreEmpresa = value; }
        public string DireccionEmpresa { get => _direccionEmpresa; set => _direccionEmpresa = value; }
        public string ObsEmpresa { get => _obsEmpresa; set => _obsEmpresa = value; }
    }
}