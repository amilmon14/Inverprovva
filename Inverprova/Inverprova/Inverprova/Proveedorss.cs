using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Inverprova
{
    class Proveedorss
    {

        public static int Agregar(Proveedor pProveedor)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Proveedor (nombre_proveedor, telefono_proveedor, direccion) values ('{0}', '{1}','{2}')",
              pProveedor.Nombre_Proveedor, pProveedor.Telefono_Proveedor, pProveedor.Direccion_Proveedor), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }


        public static List<Proveedor> BuscarProveedor(String pNombre_Proveedor, Int64 pCodigo_Proveedor)
        {

            List<Proveedor> Lista = new List<Proveedor>();
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_proveedor, nombre_proveedor, telefono_proveedor,direccion from Proveedor where nombre_proveedor = '{0}' or codigo_proveedor = '{1}' ", pNombre_Proveedor, pCodigo_Proveedor), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Proveedor pProveedor = new Proveedor();
                    pProveedor.Codigo_Proveedor = reader.GetInt64(0);
                    pProveedor.Nombre_Proveedor = reader.GetString(1);
                    pProveedor.Telefono_Proveedor = reader.GetInt64(2);
                    pProveedor.Direccion_Proveedor = reader.GetString(3);
                    Lista.Add(pProveedor);

                }
                conexion.Close();
                return Lista;

            }

        }



        public static Proveedor ObtenerProveedor(Int64 pCodigo_Proveedor)
        {

            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                Proveedor pProveedor = new Proveedor();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_proveedor, nombre_proveedor, telefono_proveedor,direccion from Proveedor where codigo_proveedor= '{0}' ", pCodigo_Proveedor), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pProveedor.Codigo_Proveedor = reader.GetInt64(0);
                    pProveedor.Nombre_Proveedor = reader.GetString(1);
                    pProveedor.Telefono_Proveedor = reader.GetInt64(2);
                    pProveedor.Direccion_Proveedor = reader.GetString(3);
                }
                conexion.Close();
                return pProveedor;

            }


        }



        public static int Modificar(Proveedor pProveedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Proveedor set nombre_proveedor='{0}', telefono_proveedor='{1}', direccion='{2}'   where codigo_proveedor={3}",
                   pProveedor.Nombre_Proveedor, pProveedor.Telefono_Proveedor, pProveedor.Direccion_Proveedor, pProveedor.Codigo_Proveedor), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }




        public static int Eliminar(Int64 pCodigo_Proveedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Proveedor where codigo_poveedor={0}", pCodigo_Proveedor), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

        public static int rdm()
        {
            Random rdm = new Random();
            int a = rdm.Next(1000, 9000);

            return a;

        }




    }
}
