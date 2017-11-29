using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CAPA_DATOS;
using CAPA_ENTIDAD;
namespace CAPA_NEGOCIO
{
    public class ConsultacomboNEG
    {
        ConsultacomboDAO cdao = new ConsultacomboDAO();
        public DataSet lista_tipoproductos()
        {
            return cdao.lista_tipoproductos();
        }

        public DataSet tipos_usuarios()
        {
            return cdao.tipos_usuarios();
        }

        public DataSet lista_presentacion_producto()
        {
            return cdao.lista_presentacion_producto();
        }

        public DataSet lista_principio_activo()
        {
            return cdao.lista_principio_activo();
        }

        public DataSet lista_laboratorios()
        {
            return cdao.lista_laboratorios();
        }
        public DataSet producto_por_tipo_nombre(Producto p)
        {
            return cdao.producto_por_tipo_nombre(p);
        }
        public DataSet confirmar_acceso(Usuario u)
        {
            return cdao.confirmar_acceso(u);
        }
    }
}
