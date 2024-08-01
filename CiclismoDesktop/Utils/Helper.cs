using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclismoDesktop.Utils
{
    public class Helper
    {
        public static SqlConnection CrearConexion()
        {
            string connectionString = "server=.\\SQLEXPRESS; database=Ciclismo; user=sa; password=123; multipleactiveresultsets=true; Encrypt=false";
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
