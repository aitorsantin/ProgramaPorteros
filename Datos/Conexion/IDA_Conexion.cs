using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public interface IDA_Conexion
    {
        SqlConnection DA_Conectar();
    }
}
