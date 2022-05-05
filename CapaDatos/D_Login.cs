using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using CapaEntidades.Cache;

namespace CapaDatos
{
    public class D_Login
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public bool Login(E_Login login)
        {
            conexion.Open();
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conexion;
                cmd.CommandText = "select * from inv_usuarios where LOGIN_USUARIO=@user and CLAVE_USUARIO=@pass";
                cmd.Parameters.AddWithValue("@user", login.LoginUsuario);
                cmd.Parameters.AddWithValue("@pass", login.ClaveUsuario);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CacheInicioSesion.IdUsuario = reader.GetInt32(0);
                        CacheInicioSesion.Nombre = reader.GetString(1);
                        CacheInicioSesion.Cargo = reader.GetString(2);
                    }
                    return true;
                }
                else
                        return false;
            }
        }

    }
}
