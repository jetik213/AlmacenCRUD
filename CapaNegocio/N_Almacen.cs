using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Almacen
    {
        D_Almacen data = new D_Almacen();

        public List<E_Almacen> ListarAlmacen(string buscar)
        {
            return data.ListarAlmacen(buscar);
        }

        public void CreandoAlmacen(E_Almacen empresa)
        {
            data.CrearAlmacen(empresa);
        }

        public void EditandoAlamcen(E_Almacen empresa)
        {
            data.EditarAlmacen(empresa);
        }

        public void EliminandoAlmacen(E_Almacen empresa)
        {
            data.EliminarAlmacen(empresa);
        }
    }
}