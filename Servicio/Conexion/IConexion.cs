using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Conexion
{
    public interface IConexion
    {
        List<string> ObtenerConexionesDisponibles();
    }
}
