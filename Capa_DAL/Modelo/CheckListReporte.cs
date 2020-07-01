using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Modelo
{
    public class CheckListReporte
    {
        public int idCheckListRepo { get; set; }
        public int estadoCheck { get; set; }
        public DateTime fechaCheckRep { get; set; }
        public string mejora { get; set; }
        public int idCheckList { get; set; }

    }
}
