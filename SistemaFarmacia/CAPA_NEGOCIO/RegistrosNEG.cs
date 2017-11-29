using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAPA_ENTIDAD;
using System.Data;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class RegistrosNEG
    {
        RegistrosDAO rdao = new RegistrosDAO();
         public int registrar_producto(Producto p, int opcion_adicional, Medicamento m = null)
        {
            return rdao.registrar_producto(p,opcion_adicional,m);
        }

         public int Registrar_venta(VentaEnt V, DataTable dt)
         {
            return  rdao.Registrar_venta(V, dt);
         }

         public int registrar_usuario(Usuario u) {
             return rdao.registrar_usuario(u);
         }
         public void registrar_laboratorio(LaboratorioEnt l) {
             rdao.registrar_laboratorio(l);
         }
         public DataSet lista_laboratorios()
         {
             return rdao.lista_laboratorios();
         }
         public void registrar_proveedor(ProveedorEnt p)
         {
             rdao.registrar_proveedor(p);
         }

       
         public DataSet lista_proveedor()
         {
             return rdao.lista_proveedor();
         }
    }
}
