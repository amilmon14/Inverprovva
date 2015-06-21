using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Inverprova
{
    class BDComun
    {

        public static SqlConnection ObtnerCOnexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=AXEL-LANDA\\SQLEXPRESS;Initial Catalog=Inverprova2;Integrated Security=True");
            Conn.Open();

            return Conn;

        }
    }
}
 