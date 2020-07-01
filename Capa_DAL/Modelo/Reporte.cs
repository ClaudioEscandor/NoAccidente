using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Reporte
    {
        public int idReporte { get; set; }
        public int Visitas { get; set; }
        public int capacitacion { get; set; }
        public int accidente { get; set; }
        public int multas { get; set; }
        public int idUsuAdmin { get; set; }
        public int idCliente { get; set; }

    }
}
