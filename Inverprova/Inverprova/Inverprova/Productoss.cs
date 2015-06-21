using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Inverprova
{
    class Productoss
    {
        public static int Agregar(Producto pProducto)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Productos ( nombre_producto, descripcion_producto, codigo_proveedor, precioVenta_producto, precioCompra_producto) values ('{0}', '{1}','{2}','{3}', '{4}')",
             pProducto.Nombre_producto, pProducto.Descripcion_producto, pProducto.Codigo_proveedor, pProducto.PrecioVenta_producto, pProducto.PrecioCompra_producto), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }


        public static List<Producto> BuscarProductos(String pNombre_producto, Int64 pCodigo_producto)
        {

            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_producto, nombre_producto, descripcion_producto,codigo_proveedor,precioVenta_producto,precioCompra_producto from ProDuctos where nombre_producto = '{0}' or codigo_producto = '{1}' ", pNombre_producto, pCodigo_producto), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto pProducto = new Producto();

                    pProducto.Codigo_producto = reader.GetInt64(0);
                    pProducto.Nombre_producto = reader.GetString(1);
                    pProducto.Descripcion_producto = reader.GetString(2);
                    pProducto.Codigo_proveedor = reader.GetInt64(3);
                    pProducto.PrecioVenta_producto = reader.GetDouble(4);
                    pProducto.PrecioCompra_producto = reader.GetDouble(5);

                    Lista.Add(pProducto);

                }
                conexion.Close();
                return Lista;

            }

        }



        public static Producto ObtenerProducto(Int64 pCodigo_producto)
        {

            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                Producto pProducto = new Producto();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select codigo_producto, nombre_producto, descripcion_producto,codigo_proveedor,precioVenta_producto,precioCompra_producto from ProDuctos where codigo_producto = '{0}' ", pCodigo_producto), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pProducto.Codigo_producto = reader.GetInt64(0);
                    pProducto.Nombre_producto = reader.GetString(1);
                    pProducto.Descripcion_producto = reader.GetString(2);
                    pProducto.Codigo_proveedor = reader.GetInt64(3);
                    pProducto.PrecioVenta_producto = reader.GetDouble(4);
                    pProducto.PrecioCompra_producto = reader.GetDouble(5);
                }
                conexion.Close();
                return pProducto;

            }


        }



        public static int Modificar(Producto pProducto)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Update ProDuctos set nombre_producto='{0}', descripcion_producto='{1}', codigo_proveedor='{2}', precioVenta_producto='{3}', precioCompra_producto='{4}'  where codigo_producto='{5}'",
                  pProducto.Nombre_producto, pProducto.Descripcion_producto, pProducto.Codigo_proveedor, pProducto.PrecioVenta_producto, pProducto.PrecioCompra_producto, pProducto.Codigo_producto), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }




        public static int Eliminar(Int64 pCodigo_producto)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtnerCOnexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from Productos where codigo_producto={0}", pCodigo_producto), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }

        public static List<ListarProveedor> ObtenerProveedor()
        {
            List<ListarProveedor> _lista = new List<ListarProveedor>();
            using (SqlConnection _conn = BDComun.ObtnerCOnexion())
            {
                SqlCommand _comando = new SqlCommand("select codigo_proveedor, nombre_proveedor from Proveedor ", _conn);
                SqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    ListarProveedor pProveedor = new ListarProveedor();
                    pProveedor.codigo = _reader.GetInt64(0);
                    pProveedor.proveedor = _reader.GetString(1);
                    _lista.Add(pProveedor);
                }
                return _lista;

            }
        }



    }
}
