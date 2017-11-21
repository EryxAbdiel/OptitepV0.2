using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class BDCon
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source=Frank-Pc; Initial Catalog=Escuela; User Id=sa; Password=3322"); ////ATENCION: Verificar credenciales
            Conn.Open();

            return Conn;
        }
    }
}
