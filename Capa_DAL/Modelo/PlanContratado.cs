using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class PlanContratado
    {
        public int idPlanContra { get; set; }
        public string nombreProfesional { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaPlanContra { get; set; }
        public string estado { get; set; }

    }
}
