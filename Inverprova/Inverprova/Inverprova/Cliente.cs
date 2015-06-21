using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverprova
{
    public  class Cliente
    {

        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public Int64 telefono { get; set; }

        public String Direccion { get; set; }

        public String email { get; set; }

        public Cliente() { }

        public Cliente(Int64 pId, String pNombre, String pApellido, Int64 ptelefono, String pDireccion, String pemail)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.telefono = ptelefono;
            this.Direccion = pDireccion;
            this.email = pemail;

        }
    }
}
