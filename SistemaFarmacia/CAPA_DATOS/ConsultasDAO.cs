using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAPA_ENTIDAD;
using System.Data.SqlClient;
using System.Data;
namespace CAPA_DATOS
{
    public  class ConsultasDAO
    {
        public DataSet listar_medicamentos(){
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("USP_LISTAR_MEDICAMENTOS", cn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                        da.Fill(ds, "listamedicamento");
                   return ds;
                    
                }
            }
        }
        public DataSet listar_otros_productos()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("USP_LISTAR_OTROS", cn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "listaproductos");
                    return ds;

                }
            }
        }

        public DataSet ventas_por_codigo(String x)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("USP_VENTAS", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@X", x);
                DataSet ds = new DataSet();
                da.Fill(ds, "ventasa");
                return ds;

            }
        }

        public DataSet ventas_por_fechas(DateTime ? fechaini = null , DateTime ? fechafin = null)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("USP_FILTRAR_VENTA_FECHAS", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@FECHAINI", fechaini);
                da.SelectCommand.Parameters.AddWithValue("@FECHAFIN", fechafin);

                DataSet ds = new DataSet();
                da.Fill(ds, "v");
                return ds;

            }
        }

    }
}
