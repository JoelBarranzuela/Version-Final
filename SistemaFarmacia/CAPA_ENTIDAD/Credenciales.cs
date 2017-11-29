using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
   public static class Credenciales
    {
        static String username;

        public static String Username
        {
            get { return Credenciales.username; }
            set { Credenciales.username = value; }
        }
        static String password;

        public static String Password
        {
            get { return Credenciales.password; }
            set { Credenciales.password = value; }
        }
        static int codigoUsuario;

        public static int CodigoUsuario
        {
            get { return Credenciales.codigoUsuario; }
            set { Credenciales.codigoUsuario = value; }
        }

        static int tipo_usuario_cod;

        public static int Tipo_usuario_cod
        {
            get { return Credenciales.tipo_usuario_cod; }
            set { Credenciales.tipo_usuario_cod = value; }
        }



    }
}
