using Persistência.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class RepositorioTreinamentos : Repositorio<tb_Treinamentos>
    {
        public RepositorioTreinamentos(DbContext context)
            : base(context)
        {
        }

        public List<tb_Treinamentos> ObtemTreinamentosPorNome(string busca)
        {
            return this.Tudo()
                .Where(treinamentos => treinamentos.nomeTreinamento.Contains(busca))
                .ToList();
        }

        public string Validar(tb_Treinamentos treinamentos)
        {
            return string.Empty;
        }

    }
}
