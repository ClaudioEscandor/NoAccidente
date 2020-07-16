using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class PDFpago
    {
        public string nombre_titutal { get; set; }
        public string rut_empresa { get; set; }
        public string giro { get; set; }
        public int telefono { get; set; }
        public string servicios { get; set; }
        public DateTime fecha_realizacion { get; set; }
        public DateTime fecha_expiracion { get; set; }
        public int impuesto { get; set; }
        public int monto { get; set; }
        public int monto_total { get; set; }
        public string estado_pago { get; set; }

    }
}
