using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Pagos
    {
        public int  id_pago { get; set; }
        public string estado_pago { get; set; }
        public string nombre_titular { get; set; }
        public string rut_empresa { get; set; }
    }
}
