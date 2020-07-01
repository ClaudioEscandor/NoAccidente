using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Visita
    {
        public int idVisita { get; set; }
        public DateTime fecha { get; set; }
        public string idEstado { get; set; }
        public string rutCliente { get; set; }
        public string rutProfesional { get; set; }
        public string nombreCliente { get; set; }
        public string nombreProfecional { get; set; }

    }
}
