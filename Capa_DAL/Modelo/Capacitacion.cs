using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Capacitacion
    {
        public int id_capacitacion { get; set; }
        public DateTime fecha_capacitacion { get; set; }
        public int id_planificacion { get; set; }

    }
}
