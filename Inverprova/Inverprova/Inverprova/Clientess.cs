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
    class Clientess
    {

        public static int Agregar(Cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Clientes (nombre_cliente, apellido_cliente,telefono_cliente, direccion_cliente,email_cliente) values ('{0}','{1}','{2}', '{3}' ,'{4}')",
               pCliente.Nombre, pCliente.Apellido, pCliente.telefono, pCliente.Direccion, pCliente.email), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }


        public static List<Cliente> BuscarClientes(String pNombre_cliente, Int64 pCodigo_cliente)
        {

            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_cliente, nombre_cliente, apellido_cliente,telefono_cliente,direccion_cliente, email_cliente from Clientes where nombre_cliente = '{0}' or codigo_cliente = '{1}' ", pNombre_cliente, pCodigo_cliente), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente pCliente = new Cliente();
                    pCliente.Id = reader.GetInt64(0);
                    pCliente.Nombre = reader.GetString(1);
                    pCliente.Apellido = reader.GetString(2);
                    pCliente.telefono = reader.GetInt64(3);
                    pCliente.Direccion = reader.GetString(4);
                    pCliente.email = reader.GetString(5);

                    Lista.Add(pCliente);

                }
                conexion.Close();
                return Lista;

            }

        }




        public static Cliente ObtenerCliente(Int64 pId)
        {

            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                Cliente pEmpleado = new Cliente();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_cliente, nombre_cliente, apellido_cliente,telefono_cliente, direccion_cliente, email_cliente  from Clientes where codigo_cliente={0}", pId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pEmpleado.Id = reader.GetInt64(0);
                    pEmpleado.Nombre = reader.GetString(1);
                    pEmpleado.Apellido = reader.GetString(2);

                    pEmpleado.telefono = reader.GetInt64(3);
                    pEmpleado.Direccion = reader.GetString(4);

                    pEmpleado.email = reader.GetString(5);


                }
                conexion.Close();
                return pEmpleado;

            }


        }
        public static int Modificar(Cliente pEmpleado)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Clientes set nombre_cliente='{0}', apellido_cliente='{1}', telefono_cliente='{2}' , direccion_cliente='{3}', email_cliente='{4}'  where codigo_cliente={5}",
                   pEmpleado.Nombre, pEmpleado.Apellido, pEmpleado.telefono, pEmpleado.Direccion, pEmpleado.email, pEmpleado.Id), conexion);

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

                SqlCommand comando = new SqlCommand(string.Format("Delete from Clientes where codigo_cliente={0}", pId), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

    }
}
