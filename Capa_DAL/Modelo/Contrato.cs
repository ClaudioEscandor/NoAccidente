using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Contrato
    {
        public int id_contrato { get; set; }
        public int id_cliente { get; set; }
        public string rut_empresa { get; set; }
        public string nombre_titular { get; set; }
        public string nombre_empresa { get; set; }
        public string tipo_contrato { get; set; }
        public int telefono { get; set; }
    }
}
