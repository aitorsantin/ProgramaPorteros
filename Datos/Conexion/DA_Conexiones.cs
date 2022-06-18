using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class DA_Conexiones
    {
        List<string> ListaConexiones { get; set; } = new List<string> { @"Data Source=DESKTOP-3OS9NBP;Initial Catalog=Dam_AitorSantin;Integrated Security=True", @""};
        string StringConexion { get; set; }
    }
}
