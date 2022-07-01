using System.Data.SqlClient;

namespace Datos.Conexion
{
    public class DA_Conexion
    {
        public SqlConnection DA_Conectar(string StringConexion)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3OS9NBP;Initial Catalog=Asier;Integrated Security=True");
            return cn;
        }
    }
}
