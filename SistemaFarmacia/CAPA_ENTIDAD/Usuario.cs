using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
    public class Usuario
    {
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private int codigoUsuario;

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }
        private int tipo_usuario;

        public int Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private DateTime alta;

        public DateTime Alta
        {
            get { return alta; }
            set { alta = value; }
        }
        private DateTime baja;

        public DateTime Baja
        {
            get { return baja; }
            set { baja = value; }
        }



    }
}
