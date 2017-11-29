using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CAPA_ENTIDAD;
namespace CAPA_DATOS
{
    public class RegistrosDAO
    {

        public int registrar_producto(Producto p, int opcion_adicional, Medicamento m = null)
        {

            SqlConnection cn = Conexion.getCadenaConexion();
            SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PRODUCTO", cn);
            SqlCommand cmd2 = new SqlCommand("SP_REGISTRAR_DETALLE_PRO", cn);

            cn.Open();
            SqlTransaction trx;
            trx = cn.BeginTransaction();


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = trx;


            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Transaction = trx;

            //REGISTRANDO PRODUCTO , QUE DEVUELVE EL CODIGO DEL PRODUCTO REGISTRADO
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID_TPROD", p.CodigoCategoria);
            cmd.Parameters.AddWithValue("@ID_PP", p.CodigoTipopresentacion);
            cmd.Parameters.AddWithValue("@NOMBRE", p.Nombre_producto);
            cmd.Parameters.AddWithValue("@PRECIO_UNI", p.Precio_uni);
            cmd.Parameters.AddWithValue("@STOCK", p.Stock);
            cmd.Parameters.AddWithValue("@DESCRIPCION", p.Descripcion);
            // OBTENEMOS EL CODIGO DEL PRODUCTO
            cmd.Parameters.Add("@CODIGONUEVO", SqlDbType.Int).Direction = ParameterDirection.Output;
            // SE EJECUTA LA CONSULTA A LA BASE DE DATOS 
            cmd.ExecuteNonQuery();

            // COMO LA CONSULTA DEVUELVE UN OBJETO , SE TIENE QUE HACER LA CONVERSION 
            // DEL OBJETO A STRING ,Y DE STRING A ENTERO.
            int cod = Int32.Parse(cmd.Parameters["@CODIGONUEVO"].Value.ToString());

            // SI OPCION ADICIONAL 1  ENTONCES EL PRODUCTO ES DE TIPO MEDICAMENTO
            // SI ES 0 NO ES NECESARIO ESTE PASO .
            if (opcion_adicional == 1)
            {
                //LIMPIAMOS LOS PARAMETROS
                cmd2.Parameters.Clear();
                // NUESTRO STORED PROCEDURE PIDE 7 PARAMETROS
                //CODIGO DEL PRODUCTO
                cmd2.Parameters.AddWithValue("@ID_PROD", cod);
                // CODIGO DEL PRINCIPIO ACTIVO
                cmd2.Parameters.AddWithValue("@ID_PA", m.Id_codigoprincipioact);
                // CODIGO DEL LABORATORIO
                cmd2.Parameters.AddWithValue("@ID_LAB", m.Id_codigolaboratorio);
                // NUMERO DE LOTE DE VENTA DEL PRODUCTO
                cmd2.Parameters.AddWithValue("@NRO_LOTE", m.Nro_lote);
                // FECHA VENCIMIENTO
                cmd2.Parameters.AddWithValue("@FECHA_VENCIMIENTO", m.Fecha_vencimimiento);
                // CONDICION DE VENTA , SI ES CON RECETA MEDICA O NO 
                cmd2.Parameters.AddWithValue("@CONDICION_VENTA", m.Condicion_Venta);
                // TIPO DE MEDICAMENTO , SI ES GENERICO O DE MARCA.
                cmd2.Parameters.AddWithValue("@TIPO_MEDICAMENTO", m.Tipo_medicamento1);
                // SE EJECUTA EL STORED PROCEDURE EN MI GESTOR DE BASE DE DATOS
                cmd2.ExecuteNonQuery();
            }


            try
            {
                // SI NO HUBO ERROR , CONFIRMA LA TRANSACCIONES
                trx.Commit();

            }
            catch (Exception)
            {
                // SI HAY ERROR , NO SE REALIZA NINGUN CAMBIO 
                trx.Rollback();

            }

            // CERRAMOS LA CONEXION A LA BASE DE DATOS
            cn.Close();


            // ME REGRESA EL CODIGO DE PRODUCTO PARA ESTE NUEVO REGISTRO
            return cod;


        }

        public int Registrar_venta(VentaEnt V, DataTable dt)
        {
            SqlConnection cn = Conexion.getCadenaConexion();
            SqlCommand cmd1 = new SqlCommand("SP_REGISTRAR_VENTA", cn);
            SqlCommand cmd2 = new SqlCommand("SP_REGISTRAR_DETALLE_VENTA", cn);

            cn.Open();
            SqlTransaction trx;


            trx = cn.BeginTransaction();

            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Transaction = trx;

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Transaction = trx;


            // PEDIDO CABECERA 
            cmd1.Parameters.AddWithValue("@ID_USUARIO", V.ID_USUARIO1);
            cmd1.Parameters.Add("@CODIGOSALIDA", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd1.ExecuteNonQuery();

            int cod = Int32.Parse(cmd1.Parameters["@CODIGOSALIDA"].Value.ToString());

            // RECOREMOS LAS FILAS DE LA TABLA TEMPORAL CREADA



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow row = dt.Rows[i];
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@ID_VENTA", cod);
                cmd2.Parameters.AddWithValue("@ID_PROD ", row[0]);
                cmd2.Parameters.AddWithValue("@CANTIDAD", row[3]);
                cmd2.Parameters.AddWithValue("@DESCUENTO", 0.0);
                cmd2.ExecuteNonQuery();
            }



            try
            {
                trx.Commit();

            }
            catch (Exception)
            {
                trx.Rollback();
                throw;
            }

            cn.Close();

            return cod;
        }

        public int registrar_usuario(Usuario u)
        {
            int cod;
            SqlConnection cn = Conexion.getCadenaConexion();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("REGISTRAR_USUARIO", cn))
                {
                    cn.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@USERNAME", u.Username);
                    da.SelectCommand.Parameters.AddWithValue("@XPASSWORD", u.Password);
                    da.SelectCommand.Parameters.AddWithValue("@ID_TPUS", u.Tipo_usuario);
                    da.SelectCommand.Parameters.AddWithValue("@DESCRIPCION", u.Descripcion);
                    da.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.Int).Direction = ParameterDirection.Output;
                    da.SelectCommand.ExecuteNonQuery();
                    cod = Int32.Parse(da.SelectCommand.Parameters["@CODIGO"].Value.ToString());
                    cn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return cod;

        }

        public void registrar_laboratorio(LaboratorioEnt l)
        {
            
            SqlConnection cn = Conexion.getCadenaConexion();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("USP_REGISTRAR_LABORATORIO", cn))
                {
                   
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@RAZON_SOCIAL",l.RAZON_SOCIAL1);
                    da.SelectCommand.Parameters.AddWithValue("@UBICACION", l.UBICACION1);
                    da.SelectCommand.Parameters.AddWithValue("@TELEFONO", l.TELEFONO1);
                    da.SelectCommand.Parameters.AddWithValue("@HORA_ATENCION", l.HORA_ATENCION1);
                    da.SelectCommand.Parameters.AddWithValue("@DIRECTOR", l.DIRECTOR1);
                    cn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    cn.Close();

                   

                }
            }
            catch (Exception)
            {

                throw;
            }

            

        }

        public DataSet lista_laboratorios()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("select  ID_LAB,  RAZON_SOCIAL, DIRECTOR from LABORATORIO ORDER BY ID_LAB DESC", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "laboratorio");
                return ds;

            }
        }


        public void registrar_proveedor(ProveedorEnt p)
        {

            SqlConnection cn = Conexion.getCadenaConexion();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("USP_NUEVO_PROVEEDOR", cn))
                {

                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@RAZON_SOCIAL", p.RAZON_SOCIAL1);
                    da.SelectCommand.Parameters.AddWithValue("@TELEFONO", p.TELEFONO1);
                    da.SelectCommand.Parameters.AddWithValue("@EMAIL", p.EMAIL1);
                    cn.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    cn.Close();



                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public DataSet lista_proveedor()
        {
            using (SqlConnection cn = Conexion.getCadenaConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("select ID_PROV, RAZON_SOCIAL , TELEFONO,EMAIL from PROVEEDOR ORDER BY ID_PROV DESC", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "prov");
                return ds;

            }
        }


    }
}
