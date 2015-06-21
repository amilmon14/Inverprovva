using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
namespace Inverprova
{
    class Empleados
    {
        public static int Agregar(Empleado pEmpleado)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Empleados (nombre_empleado, apellido_empleado, direccion,telefono, fechanac_empleado, fechacontra_empleado, rol_id, usuario, password) values ('{0}','{1}','{2}', '{3}' ,'{4}','{5}', '{6}','{7}', convert(varbinary,'{8}'))",
               pEmpleado.Nombre, pEmpleado.Apellido, pEmpleado.Direccion, pEmpleado.telefono, pEmpleado.Fecha_Nac, pEmpleado.fecha_contrato, pEmpleado.Rol, pEmpleado.usuario, pEmpleado.contra), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }



        public static List<Empleado> BuscarEmpleados(String pNombre, Int64 pId)
        {

            List<Empleado> Lista = new List<Empleado>();
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_empleado, nombre_empleado, apellido_empleado, direccion,telefono, fechanac_empleado, fechacontra_empleado, rol_id, usuario,  convert(varchar,password) from Empleados where nombre_empleado='{0}' or codigo_empleado = '{1}'  ", pNombre, pId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado pEmpleado = new Empleado();
                    pEmpleado.Id = reader.GetInt64(0);
                    pEmpleado.Nombre = reader.GetString(1);
                    pEmpleado.Apellido = reader.GetString(2);
                    pEmpleado.Direccion = reader.GetString(3);
                    pEmpleado.telefono = reader.GetString(4);

                    pEmpleado.Fecha_Nac = reader.GetString(5);
                    pEmpleado.fecha_contrato = reader.GetString(6);
                    pEmpleado.Rol = reader.GetInt64(7);
                    pEmpleado.usuario = reader.GetString(8);
                    pEmpleado.contra = reader.GetString(9);
                    /*  pEmpleado.contra = Convert.ToString (reader.GetSqlBinary (8));*/
                    Lista.Add(pEmpleado);

                }
                conexion.Close();
                return Lista;

            }

        }



        public static Empleado ObtenerEmpleado(Int64 pId)
        {

            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                Empleado pEmpleado = new Empleado();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_empleado, nombre_empleado, apellido_empleado,direccion,telefono,fechanac_empleado,fechacontra_empleado, rol_id, usuario,  convert(varchar,password) from Empleados where codigo_empleado={0}", pId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pEmpleado.Id = reader.GetInt64(0);
                    pEmpleado.Nombre = reader.GetString(1);
                    pEmpleado.Apellido = reader.GetString(2);
                    pEmpleado.Direccion = reader.GetString(3);
                    pEmpleado.telefono = reader.GetString(4);
                    pEmpleado.Fecha_Nac = reader.GetString(5);
                    pEmpleado.fecha_contrato = reader.GetString(6);
                    pEmpleado.Rol = reader.GetInt64(7);
                    pEmpleado.usuario = reader.GetString(8);
                    pEmpleado.contra = reader.GetString(9);


                }
                conexion.Close();
                return pEmpleado;

            }


        }



        public static List<Rol> ObtenerRoles()
        {
            List<Rol> _lista = new List<Rol>();
            using (SqlConnection _conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand _comando = new SqlCommand("select Rol_id, Rol_descripcion from Roles ", _conn);
                SqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    Rol pRoles = new Rol();
                    pRoles.id = _reader.GetInt64(0);
                    pRoles.Nombre = _reader.GetString(1);
                    _lista.Add(pRoles);
                }
                return _lista;

            }



        }
        public static int rdm()
        {
            Random rdm = new Random();
            int a = rdm.Next(1000, 9000);

            return a;

        }
        public static int Modificar(Empleado pEmpleado)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Empleados set nombre_empleado='{0}', apellido_empleado='{1}', direccion='{2}', fechanac_empleado='{3}', fechacontra_empleado='{4}', rol_id ='{5}', usuario='{6}', password= Convert(varbinary, '{7}')  where codigo_empleado={8}",
                   pEmpleado.Nombre, pEmpleado.Apellido, pEmpleado.Direccion, pEmpleado.Fecha_Nac, pEmpleado.fecha_contrato, pEmpleado.Rol, pEmpleado.usuario, pEmpleado.contra, pEmpleado.Id), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }
        public static int Eliminar(Int64 pId)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Empleados where codigo_empleado={0}", pId), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }


    }
}
