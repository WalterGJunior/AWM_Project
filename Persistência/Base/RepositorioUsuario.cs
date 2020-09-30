using Persistência.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class RepositorioUsuario : Repositorio<tb_Usuario>
    {
        public RepositorioUsuario (DbContext context)
            : base(context)
        {
        }

        public bool UsuarioEstaLogado(string usuario, string senha)
        {
            return this.Tudo()
                .Where(x => x.usuario == usuario && x.senha == senha)                       
                .Any();
        }

    }
}
