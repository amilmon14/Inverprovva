using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverprova
{
  public class Proveedor
    {

        public Int64 Codigo_Proveedor { get; set; }
        public String Nombre_Proveedor { get; set; }
        public Int64 Telefono_Proveedor { get; set; }
        public String Direccion_Proveedor { get; set; }
        public Proveedor() { }

        public Proveedor(Int64 pCodigo_Proveedor, String pNombre_Proveedor, Int64 pTelefono_Proveedor, String pDireccion_Proveedor)
        {
            this.Codigo_Proveedor = pCodigo_Proveedor;
            this.Nombre_Proveedor = pNombre_Proveedor;
            this.Telefono_Proveedor = pTelefono_Proveedor;
            this.Direccion_Proveedor = Direccion_Proveedor;
        }
    }
}
