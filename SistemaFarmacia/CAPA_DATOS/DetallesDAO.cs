using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CAPA_DATOS
{
    public class DetallesDAO
    {
        public DataSet detalle_nuevo_usuario(int codigo)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT U.ID_USUARIO as codigo, U.USERNAME as usuario , U.XPASSWORD as password , TU.DESCRIPCION as tipousuario,  U.FECHAALTA as fechaalta   FROM USUARIO U INNER JOIN TIPO_USUARIO TU ON U.ID_TPUS = TU.ID_TPUS WHERE U.ID_USUARIO = @USUARIO", cn))
                {
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@USUARIO", codigo);
                    using (DataSet ds = new DataSet())
                    {
                        da.Fill(ds, "detalle");
                        return ds;
                    }

                }
            }
        }

        public DataSet venta_detalle(String x)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("USP_DETALLE_VENTAS", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@X", x);
                DataSet ds = new DataSet("ddd");
                da.Fill(ds, "ventas");
                return ds;

            }
        }

        public DataSet detalle_Venta_boleta(int x)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("USP_DETALLE_VENTABOLETA", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@CODIGO", x);
                DataSet ds = new DataSet();
                da.Fill(ds, "ventas");
                return ds;

            }
        }

    }
}
