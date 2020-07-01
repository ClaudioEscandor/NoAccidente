using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    class Planificacion_Capacitacion
    {
        public int id_planificacion_capacitacion { get; set; }

        public DateTime fecha_registro { get; set; }

        public string material { get; set; }

        public int cantidad_asistentes { get; set; }
    }
}
