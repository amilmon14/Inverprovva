using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverprova
{
    public class Empleado
    {
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String telefono { get; set; }
        public String Fecha_Nac { get; set; }
        public String fecha_contrato { get; set; }
        public Int64 Rol { get; set; }
        public String usuario { get; set; }
        public String contra { get; set; }
        public Empleado() { }

        public Empleado(Int64 pId, String pNombre, String pApellido, String pDireccion, String pFecha_Nac, String pfecha_contrato, Int64 pRol, String pusuario, String pcontra)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
            this.fecha_contrato = pfecha_contrato;
            this.Rol = pRol;
            this.usuario = pusuario;
            this.contra = pcontra;
        }

    }
}
