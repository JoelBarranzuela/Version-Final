using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
   public class ConsultaReporteNEG
    {
        ConsultaReporteDAO rdao = new ConsultaReporteDAO();
        public DataSet lista_tipoproductos()
        {
            return rdao.lista_tipoproductos();
        }

        public DataSet lista_presentacion_producto() {
            return rdao.lista_presentacion_producto();
        }
   
    }
}
