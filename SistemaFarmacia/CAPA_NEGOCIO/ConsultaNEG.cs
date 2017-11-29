using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAPA_DATOS;
using System.Data;
namespace CAPA_NEGOCIO
{
    public class ConsultaNEG
    {
        ConsultasDAO cdao = new ConsultasDAO();
        public DataSet listar_medicamentos() {
           return cdao.listar_medicamentos();
        }
        public DataSet listar_otros_productos() {
            return cdao.listar_otros_productos();
        }

        public DataSet ventas_por_codigo(String x )
        {
            return cdao.ventas_por_codigo(x);
        }
        public DataSet ventas_por_fechas(DateTime? fechaini = null, DateTime? fechafin = null)
        {
            return cdao.ventas_por_fechas(fechaini, fechafin);
        }
    }
}
