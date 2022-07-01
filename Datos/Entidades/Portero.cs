using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Portero
    {
        public int IdPortero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoAp { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Lugar { get; set; }
        public string Pais { get; set; }
        public string Pasaporte { get; set; }
        public string Nacionalidad { get; set; }
    }
}
