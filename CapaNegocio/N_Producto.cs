using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Producto
    {
        D_Producto data = new D_Producto();

        public List<E_Producto> ListarProductos(string buscar)
        {
            return data.ListarProductos(buscar);
        }

        public void CreandoProducto(E_Producto empresa)
        {
            data.CrearProducto(empresa);
        }

        public void EditandoProducto(E_Producto empresa)
        {
            data.EditarProducto(empresa);
        }

        public void EliminandoProducto(E_Producto empresa)
        {
            data.EliminarProducto(empresa);
        }

    }
}