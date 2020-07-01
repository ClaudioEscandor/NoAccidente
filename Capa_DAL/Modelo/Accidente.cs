using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Accidente
    {
        public string rutCliente { get; set; }
        public string nombreCliente { get; set; }
        public string rutProfesional { get; set; }
        public string nombreProfesional { get; set; }
        public int cantAccidente { get; set; }

    }
}
