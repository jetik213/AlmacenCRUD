using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Almacen
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); //escribir en cada clase de la Capa de Datos

        public List<E_Almacen> ListarAlmacen(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("USP_BUSCARALMACEN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Almacen> Listar = new List<E_Almacen>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Almacen
                {
                    IdAlmacen = LeerFilas.GetInt32(0),
                    CodigoAlmacen = LeerFilas.GetString(1),
                    NombreAlmacen = LeerFilas.GetString(2),
                    UbicacionAlmacen = LeerFilas.GetString(3),
                    DireccionAlmacen = LeerFilas.GetString(4),
                    CapacidadAlmacen = LeerFilas.GetInt32(5),
                    ObsAlmacen = LeerFilas.GetString(6)
                }
                );
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void CrearAlmacen(E_Almacen empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_INSERTARALMACEN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            // cmd.Parameters.AddWithValue("@RUC", empresa.CodigoAlmacen);
            cmd.Parameters.AddWithValue("@NOMBRE_ALMACEN", empresa.NombreAlmacen);
            cmd.Parameters.AddWithValue("@UBICACION", empresa.UbicacionAlmacen);
            cmd.Parameters.AddWithValue("@DIRECCION", empresa.DireccionAlmacen);
            cmd.Parameters.AddWithValue("@CAPACIDAD", empresa.CapacidadAlmacen);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsAlmacen);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAlmacen(E_Almacen empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_EDITARALMACEN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@ID_ALMACEN", empresa.IdAlmacen);
            // cmd.Parameters.AddWithValue("@RUC", empresa.CodigoAlmacen);
            cmd.Parameters.AddWithValue("@NOMBRE_ALMACEN", empresa.NombreAlmacen);
            cmd.Parameters.AddWithValue("@UBICACION", empresa.UbicacionAlmacen);
            cmd.Parameters.AddWithValue("@DIRECCION", empresa.DireccionAlmacen);
            cmd.Parameters.AddWithValue("@CAPACIDAD", empresa.CapacidadAlmacen);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsAlmacen);

            conexion.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        public void EliminarAlmacen(E_Almacen empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_ELIMINARALMACEN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_ALMACEN", empresa.IdAlmacen);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}