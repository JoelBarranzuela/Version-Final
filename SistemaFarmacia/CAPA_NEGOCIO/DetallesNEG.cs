using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class DetallesNEG
    {
        DetallesDAO ddao = new DetallesDAO();
        public DataSet detalle_nuevo_usuario(int codigo)
        {
            return ddao.detalle_nuevo_usuario(codigo);
        }
        public DataSet venta_detalle(String x)
        {
            return ddao.venta_detalle(x);
        }

        public DataSet detalle_Venta_boleta(int x)
        {
            return ddao.detalle_Venta_boleta(x);
        }

    }
}
