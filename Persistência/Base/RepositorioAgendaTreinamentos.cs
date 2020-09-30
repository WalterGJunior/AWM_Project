using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistência.Models;
using Persistência.DTO;

namespace Persistência.Base
{
    public class RepositorioAgendaTreinamentos : Repositorio<tb_AgendaTreinamentos>
    {
        public RepositorioAgendaTreinamentos(DbContext context)
            : base(context)
        {
        }

        public List<tb_AgendaTreinamentos> VerificaAgendaPorData(DateTime busca)
        {
            return this.Tudo()
                
                .Where(agendaTreinamento => 
                    agendaTreinamento.dtInicio <= busca.Date &&
                    agendaTreinamento.dtTermino >= busca.Date)
                .ToList();
        }

        public IEnumerable<AgendaDTO> RetornaDTOAgenda()
        {
            return this.Tudo()
                .ToList()
                .Select(x => new AgendaDTO
                {
                    Id_AgendaTreinamentos = x.Id_AgendaTreinamentos,
                    DataInicio = x.dtInicio,
                    DataTermino = x.dtTermino,
                    Treinamento = x.tb_Treinamentos.nomeTreinamento,
                    Empresa = x.tb_Empresa.razaosocial,
                    Descricao = x.descricao
                });
        }

        public string Validar(tb_Empresa empresa)
        {
            return string.Empty;
        }
    }
}
