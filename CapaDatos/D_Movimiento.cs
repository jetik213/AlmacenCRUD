using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Movimiento
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void add_MultipleStatements(IEnumerable<E_Movimiento> entities)
        {
            conexion.Open();
            using (SqlTransaction transaction = conexion.BeginTransaction())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.Transaction = transaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into INV_MOVIMIENTO values (@ID_ALMACEN,@ID_PRODUCTO,@ID_USUARIO,@ID_EMPRESA,@CANTIDAD,@GUIA_TRANSP,@OBSERVACIONES)";
                    command.Parameters.Add("@ID_ALMACEN", SqlDbType.Int);
                    command.Parameters.Add("@ID_PRODUCTO", SqlDbType.Int);
                    command.Parameters.Add("@ID_USUARIO", SqlDbType.Int);
                    command.Parameters.Add("@ID_EMPRESA", SqlDbType.Int);
                    command.Parameters.Add("@CANTIDAD", SqlDbType.Int);
                    command.Parameters.Add("@GUIA_TRANSP", SqlDbType.VarChar);
                    command.Parameters.Add("@OBSERVACIONES", SqlDbType.VarChar);
                    try
                    {
                        foreach (var item in entities)
                        {
                            command.Parameters["@ID_ALMACEN"].Value = item.IdAlmacen;
                            command.Parameters["@ID_PRODUCTO"].Value = item.IdProducto;
                            command.Parameters["@ID_USUARIO"].Value = item.IdUsuario;
                            command.Parameters["@ID_EMPRESA"].Value = item.IdEmpresa;
                            command.Parameters["@CANTIDAD"].Value = item.Cantidad;
                            command.Parameters["@GUIA_TRANSP"].Value = item.Guia;
                            command.Parameters["@OBSERVACIONES"].Value = item.ObsMov;
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        conexion.Close();
                        throw;
                    }
                }
            }
        }
    }
}