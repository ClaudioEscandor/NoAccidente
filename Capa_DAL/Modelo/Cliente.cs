using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombre_titular { get; set; }
        public string rut_empresa{ get; set; }
        public string nombre_empresa { get; set; }
        public string giro { get; set; }
        public string direccion { get; set; }
        public int telefono{ get; set; }
        public string pagina_web { get; set; }
        public int id_usuario { get; set; }
    }
}
