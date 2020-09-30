using Persistência.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class RepositorioAlunoTreinamento : Repositorio<tb_AlunoTreinamento>
    {
        public RepositorioAlunoTreinamento(DbContext contexto)
            : base(contexto)
        {
        }

        public bool Add(tb_AlunoTreinamento item)
        {
            if (this.EstaCadastrado(item))
                return false;
            else
                base.Adicionar(item);

            return true;
        }

        public bool Edit(tb_AlunoTreinamento item)
        {
            if (this.EstaCadastrado(item))
                return false;
            else
                base.Editar(item);

            return true;
        }

        private bool EstaCadastrado(tb_AlunoTreinamento item)
        {
            var aluno = this.Tudo().Where(x =>
                x.colaboradorID == item.colaboradorID &&
                x.AgendaTreinamentoID == item.AgendaTreinamentoID &&
                x.Id_AlunoTreinamento != item.Id_AlunoTreinamento).FirstOrDefault();

            return aluno != null;
        }
    }
}
