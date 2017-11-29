using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CAPA_ENTIDAD;
namespace CAPA_DATOS
{
    public class ConsultacomboDAO
    {
        public DataSet lista_tipoproductos()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_TPROD  AS CODIGO , DESCRIPCION AS NOMBRE  FROM TIPO_PRODUCTO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tproductos");
                return ds;

            }
        }

        public DataSet tipos_usuarios()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_TPUS  AS CODIGO , DESCRIPCION AS NOMBRE  FROM TIPO_USUARIO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tusuarios");
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
                return ds;

            }
        }

        public DataSet lista_principio_activo()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("select ID_PA as codigo ,  DESCRIPCION as nombre from PRINCIPIO_ACTIVO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "principio_activo");
                return ds;

            }
        }

        public DataSet lista_laboratorios()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("select ID_LAB as codigo ,  RAZON_SOCIAL as nombre from LABORATORIO", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "laboratorio");
                return ds;

            }
        }

        public DataSet producto_por_tipo_nombre(Producto p)
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_PRODUCTO", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("@ID_TPROD", p.CodigoCategoria);
                da.SelectCommand.Parameters.AddWithValue("@TEXTO", p.Nombre_producto);
                DataSet ds = new DataSet();
                da.Fill(ds, "filtro");
                return ds;

            }
        }

        public DataSet confirmar_acceso(Usuario u)
        {
            SqlConnection cn = Conexion.getCadenaConexion();
            SqlDataAdapter da = new SqlDataAdapter("select ID_USUARIO , ID_TPUS from USUARIO where USERNAME = @user and  XPASSWORD = @UserPassword", cn);
            da.SelectCommand.Parameters.Clear();
            da.SelectCommand.Parameters.AddWithValue("@user", u.Username);
            da.SelectCommand.Parameters.AddWithValue("@UserPassword", u.Password);
            DataSet ds = new DataSet();
            da.Fill(ds, "filtro");
            return ds;



        }


    }
}
