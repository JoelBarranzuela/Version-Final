using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
    public class DetalleVenta
    {
        public int ID_DETVENTA { get; set; }
        public int ID_VENTA { get; set; }
        public String NOMBRE { get; set; }
        public String DESCRIPCION { get; set; }
    }
}
