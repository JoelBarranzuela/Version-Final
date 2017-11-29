using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_ENTIDAD
{
    public class Producto 
    {
        int codigoProducto;

        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        String nombre_producto;

        public String Nombre_producto
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        int codigoCategoria;

        public int CodigoCategoria
        {
            get { return codigoCategoria; }
            set { codigoCategoria = value; }
        }
        
        int codigoTipopresentacion;

        public int CodigoTipopresentacion
        {
            get { return codigoTipopresentacion; }
            set { codigoTipopresentacion = value; }
        }
        int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        float precio_uni;

        public float Precio_uni
        {
            get { return precio_uni; }
            set { precio_uni = value; }
        }

        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
