using System.Data.SqlClient;

namespace Datos.Conexion
{
    public class DA_Conexion
    {
        public SqlConnection DA_Conectar(string StringConexion)
        {
            SqlConnection cn = new SqlConnection(StringConexion);
            return cn;
        }
    }
}
