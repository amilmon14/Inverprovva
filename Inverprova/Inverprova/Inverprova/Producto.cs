using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverprova
{
  public  class Producto
    {

        public Int64 Codigo_producto { get; set; }
        public String Nombre_producto { get; set; }
        public String Descripcion_producto { get; set; }
        public Int64 Codigo_proveedor { get; set; }
        public double PrecioVenta_producto { get; set; }
        public double PrecioCompra_producto { get; set; }
        public Producto() { }

        public Producto(Int64 pCodigo_producto, String pNombre_producto, String pDescripcion_producto, Int64 pCodigo_proveedor, double pPrecioVenta_producto, double pPrecioCompra_producto)
        {
            this.Codigo_producto = pCodigo_producto;
            this.Nombre_producto = pNombre_producto;
            this.Descripcion_producto = pDescripcion_producto;
            this.Codigo_proveedor = pCodigo_proveedor;
            this.PrecioVenta_producto = pPrecioVenta_producto;
            this.PrecioCompra_producto = pPrecioCompra_producto;
        }
    }
}
