using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Accidente
    {
        
        public int idCliente { get; set; }
        public string nombreTitular { get; set; }
        public string rutEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public int cantAccidente { get; set; }

    }
}
