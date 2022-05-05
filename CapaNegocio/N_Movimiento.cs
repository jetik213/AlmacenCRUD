using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Movimiento
    {

        D_Movimiento data = new D_Movimiento();

        public void add_MultipleStatements(IEnumerable<E_Movimiento> entities)
        {
            data.add_MultipleStatements(entities);
        }
        /*
        public List<E_Movimiento> ListaMovimientos(string buscar)
        {
            return data.ListarMovimientos(buscar);
        }

        public void CreandoMovimiento(E_Movimiento movimiento)
        {
            data.CrearMovimiento(movimiento);
        }

        public void EditandoMovimiento(E_Movimiento movimiento)
        {
            data.EditarMovimiento(movimiento);
        }

        public void EliminandoMovimiento(E_Movimiento movimiento)
        {
            data.EliminarMovimiento(movimiento);
        }*/


    }
}