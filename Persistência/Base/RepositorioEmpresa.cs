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
    public class RepositorioEmpresa : Repositorio<tb_Empresa>
    {
        public RepositorioEmpresa(DbContext contexto)
            :base(contexto)
        {
        }

        public List<tb_Empresa> ObtemEmpresaPorNomeCnpj(string busca)
        {
            return
                // Retornar todos os registros e filtra por nome contendo string busca
                base
                .Tudo()
                .Where(empresa => 
                    empresa.cnpj.Contains(busca) || empresa.razaosocial.Contains(busca))
                .ToList();
        }

        public string Validar(tb_Empresa empresa)
        {
            if (!string.IsNullOrWhiteSpace(empresa.cnpj) && !ValidaCNPJ.IsCnpj(empresa.cnpj))
                return "CNPJ Informado é inválido!.";

            if (this.Tudo().FirstOrDefault(x => x.cnpj == empresa.cnpj &&
                // teste para desconsiderar a pesquisa pro próprio registro
                // ou seja, ele só dá mensagem por que acha o próprio cnpj da própria empresa que tá sendo editada...
                    empresa.Id_Empresa != x.Id_Empresa
                ) != null)
                return "CNPJ já cadastrado!";

            if (string.IsNullOrWhiteSpace(empresa.nomefantasia))
                return "Nome Fantasia não informado!";

            if (string.IsNullOrWhiteSpace(empresa.razaosocial))
                return "Razao social não informado!";

            if (string.IsNullOrWhiteSpace(empresa.cnpj))
                return "CNPJ não informado!";

            if (string.IsNullOrWhiteSpace(empresa.endereco))
                return "Endereço não informado!";

            if (String.IsNullOrWhiteSpace(empresa.cidade))
                return "Cidade não informado!";

            if (string.IsNullOrWhiteSpace(empresa.estado))
                return "Estado nao informado!";

            return string.Empty;
        }


        public void Remover(tb_Colaborador tbFuncionario)
        {
            throw new NotImplementedException();
        }

        public void Editar(tb_Colaborador tbFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
