using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string tipo_usuario { get; set; }
        public string estado { get; set; }

    }
}
