using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Empresa
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); //escribir en cada clase de la Capa de Datos

        public List<E_Empresa> ListarEmpresas(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("USP_BUSCAREMPRESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Empresa> Listar = new List<E_Empresa>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Empresa
                {
                    IdEmpresa = LeerFilas.GetInt32(0),
                    CodigoEmpresa = LeerFilas.GetString(1),
                    RucEmpresa = LeerFilas.GetString(2),
                    NombreEmpresa = LeerFilas.GetString(3),
                    DireccionEmpresa = LeerFilas.GetString(4),
                    ObsEmpresa = LeerFilas.GetString(5)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void CrearEmpresa(E_Empresa empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_INSERTAREMPRESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RUC", empresa.RucEmpresa);
            cmd.Parameters.AddWithValue("@EMPRESA", empresa.NombreEmpresa);
            cmd.Parameters.AddWithValue("@DIRECCION", empresa.DireccionEmpresa);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsEmpresa);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarEmpresa(E_Empresa empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_EDITAREMPRESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EMPRESA", empresa.IdEmpresa);
            cmd.Parameters.AddWithValue("@RUC", empresa.RucEmpresa);
            cmd.Parameters.AddWithValue("@EMPRESA", empresa.NombreEmpresa);
            cmd.Parameters.AddWithValue("@DIRECCION", empresa.DireccionEmpresa);
            cmd.Parameters.AddWithValue("@OBSERVACIONES", empresa.ObsEmpresa);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEmpresa(E_Empresa empresa)
        {
            SqlCommand cmd = new SqlCommand("USP_ELIMINAREMPRESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EMPRESA", empresa.IdEmpresa);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}