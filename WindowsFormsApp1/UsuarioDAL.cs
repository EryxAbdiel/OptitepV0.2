using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class UsuarioDAL
    {
       /* public static int Autentificar(String uNombre, String uPass)
        {
            int resultado = -1;

            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "SELECT * FROM usuarios WHERE uNombre = '{0}' AND PwdCompare('{1}',Contrasenia) = 1", uNombre, uPass), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;
        }*/
    }
}
