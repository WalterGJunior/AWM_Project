using Persistência.Models;
using Persistencia.Validation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistência.Base
{
    public class RepositorioFuncionario : Repositorio<tb_Colaborador>
    {
        public RepositorioFuncionario(DbContext context)
            : base(context)
        {
        }

        public List<tb_Colaborador> ObtemColabordorPorNomeCpf(string busca)
        {
            return this.Tudo()
                .Where(colaboradorID => colaboradorID.cpf.Contains(busca) || colaboradorID.nome.Contains(busca))
                .ToList();
        }

        public string Validar(tb_Colaborador colaborador)
        {
            if (!string.IsNullOrEmpty(colaborador.cpf) && !ValidaCPF.IsCpf(colaborador.cpf))
                return "CPF informado não é valido!";

            if (colaborador.dtDemissao != null && colaborador.dtDemissao < colaborador.dtAdmissao)
                return "Data de Demissão não pode ser menor que a data de Admissão!";

            if (colaborador.dtAdmissao == null)
                return "Data de Admissão deve ser informada!";

            if (string.IsNullOrEmpty(colaborador.cpf))
                return "CPF deve ser informado!";

            if (this.Tudo().FirstOrDefault(x => x.cpf == colaborador.cpf
                && x.Id_Colaborador != colaborador.Id_Colaborador) != null)
                return "CPF já cadastrado";

            return string.Empty;
        }

    }
}
