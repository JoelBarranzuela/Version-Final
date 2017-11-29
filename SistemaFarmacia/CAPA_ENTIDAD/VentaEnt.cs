using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
    public class VentaEnt
    {
        int ID_VENTA;

        public int ID_VENTA1
        {
            get { return ID_VENTA; }
            set { ID_VENTA = value; }
        }
        int ID_USUARIO;

        public int ID_USUARIO1
        {
            get { return ID_USUARIO; }
            set { ID_USUARIO = value; }
        }

        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

    }
}
