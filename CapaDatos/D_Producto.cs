using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Producto
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); //escribir en cada clase de la Capa de Datos

        public List<E_Producto> ListarProductos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("USP_BUSCARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Producto> Listar = new List<E_Producto>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Producto
                {
                    IdProducto = LeerFilas.GetInt32(0),
                    CodigoProducto = LeerFilas.GetString(1),
                    NombreProducto = LeerFilas.GetString(2),
                    OrigenProducto = LeerFilas.GetString(3),
                    //EstadoProducto = LeerFilas.GetInt32(4),
                    EmpaqueProducto = LeerFilas.GetString(5),
                    AbreviaturaProducto = LeerFilas.GetString(6),
                    ObsProducto = LeerFilas.GetString(7)
                }
                );
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void CrearProducto(E_Producto empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_INSERTARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE_PRODUCTO", empresa.NombreProducto);
            cmd.Parameters.AddWithValue("@ORIGEN", empresa.OrigenProducto);
            cmd.Parameters.AddWithValue("@ESTADO", empresa.EstadoProducto);
            cmd.Parameters.AddWithValue("@EMPAQUE", empresa.EmpaqueProducto);
            cmd.Parameters.AddWithValue("@ABREVIATURA", empresa.AbreviaturaProducto);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsProducto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarProducto(E_Producto empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_EDITARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //conexion.Open();

            cmd.Parameters.AddWithValue("@ID_PRODUCTO", empresa.IdProducto);
            cmd.Parameters.AddWithValue("@NOMBRE_PRODUCTO", empresa.NombreProducto);
            cmd.Parameters.AddWithValue("@ORIGEN", empresa.OrigenProducto);
            cmd.Parameters.AddWithValue("@ESTADO", empresa.EstadoProducto);
            cmd.Parameters.AddWithValue("@EMPAQUE", empresa.EmpaqueProducto);
            cmd.Parameters.AddWithValue("@ABREVIATURA", empresa.AbreviaturaProducto);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsProducto);

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

        public void EliminarProducto(E_Producto empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_ELIMINARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_PRODUCTO", empresa.IdProducto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}