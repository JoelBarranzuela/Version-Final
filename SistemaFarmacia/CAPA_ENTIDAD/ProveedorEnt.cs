using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
    public class ProveedorEnt
    {
        int ID_PROV;

        public int ID_PROV1
        {
            get { return ID_PROV; }
            set { ID_PROV = value; }
        }
        string RAZON_SOCIAL;

        public string RAZON_SOCIAL1
        {
            get { return RAZON_SOCIAL; }
            set { RAZON_SOCIAL = value; }
        }
        string TELEFONO;

        public string TELEFONO1
        {
            get { return TELEFONO; }
            set { TELEFONO = value; }
        }
        string EMAIL;

        public string EMAIL1
        {
            get { return EMAIL; }
            set { EMAIL = value; }
        }
    }
}
