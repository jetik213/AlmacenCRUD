using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Empresa
    {
        D_Empresa data = new D_Empresa();

        public List<E_Empresa> ListaEmpresas(string buscar)
        {
            return data.ListarEmpresas(buscar);
        }

        public void CreandoEmpresa(E_Empresa empresa)
        {
            data.CrearEmpresa(empresa);
        }

        public void EditandoEmpresa(E_Empresa empresa)
        {
            data.EditarEmpresa(empresa);
        }

        public void EliminandoEmpresa(E_Empresa empresa)
        {
            data.EliminarEmpresa(empresa);
        }

    }
}