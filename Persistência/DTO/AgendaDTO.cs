using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.DTO
{
    public class AgendaDTO
    {
        public int Id_AgendaTreinamentos { get; set; }
        public string Treinamento { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
    }
}
