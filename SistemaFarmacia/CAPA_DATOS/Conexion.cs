using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
     public static  class Conexion
    {

         public static SqlConnection getCadenaConexion()
         {
            return   new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
         }

        
       
    }
}
