using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace CAPA_DATOS
{
   public class ConsultaReporteDAO
    {
        public DataSet lista_tipoproductos()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_TPROD  AS CODIGO , DESCRIPCION AS NOMBRE  FROM TIPO_PRODUCTO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tproductos");
                DataRow dr = ds.Tables[0].NewRow();
                dr["CODIGO"] = 0;
                dr["NOMBRE"] = "TODOS";// Some ID
                ds.Tables[0].Rows.Add(dr);
                return ds;

            }
        }

        public DataSet lista_presentacion_producto()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("select ID_PP as codigo ,  DESCRIPCION as nombre from PRESENTACION_PRODUCTO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "presentacion_producto");
                DataRow dr = ds.Tables[0].NewRow();
                dr["codigo"] = 0;
                dr["nombre"] = "TODOS";// Some ID
                ds.Tables[0].Rows.Add(dr);
                return ds;

            }
        }
    }
}
