using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Solicitud
    {
        public int id_solicitud { get; set; }
        public string nombre_titular { get; set; }
        public string rut_empresa { get; set; }
        public string nombre_empresa { get; set; }

    }
}
