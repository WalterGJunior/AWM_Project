using Persistência.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class RepositorioTreinador : Repositorio<tb_Palestrante>
    {
        public RepositorioTreinador(DbContext context)
            : base(context)
        {
        }

        public List<tb_Palestrante> ObtemTreinadorPorNome(string busca)
        {
            return this.Tudo()
                .Where(treinador => treinador.nome.Contains(busca))
                .ToList();
        }

        public string Validar(tb_Palestrante empresa)
        {
            return string.Empty;
        }
    }
}
