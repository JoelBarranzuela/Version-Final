using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
   public class Medicamento
    {
        int id_codigoproducto;

        public int Id_codigoproducto
        {
            get { return id_codigoproducto; }
            set { id_codigoproducto = value; }
        }
        int id_codigoprincipioact;

        public int Id_codigoprincipioact
        {
            get { return id_codigoprincipioact; }
            set { id_codigoprincipioact = value; }
        }
        int id_codigolaboratorio;

        public int Id_codigolaboratorio
        {
            get { return id_codigolaboratorio; }
            set { id_codigolaboratorio = value; }
        }
        String nro_lote;

        public String Nro_lote
        {
            get { return nro_lote; }
            set { nro_lote = value; }
        }
        DateTime fecha_vencimimiento;

        public DateTime Fecha_vencimimiento
        {
            get { return fecha_vencimimiento; }
            set { fecha_vencimimiento = value; }
        }
        String condicion_Venta;

        public String Condicion_Venta
        {
            get { return condicion_Venta; }
            set { condicion_Venta = value; }
        }
        String Tipo_medicamento;

        public String Tipo_medicamento1
        {
            get { return Tipo_medicamento; }
            set { Tipo_medicamento = value; }
        }
    }
}
