using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_Colaborador
    {
        public tb_Colaborador()
        {
            this.tb_AlunoTreinamento = new List<tb_AlunoTreinamento>();
        }

        public int Id_Colaborador { get; set; }
        public Nullable<int> matricula { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefoneFixo { get; set; }
        public string telefoneCelular { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> dtAdmissao { get; set; }
        public Nullable<System.DateTime> dtDemissao { get; set; }
        public string cargo { get; set; }
        public Nullable<int> EmpresaID { get; set; }
        public virtual ICollection<tb_AlunoTreinamento> tb_AlunoTreinamento { get; set; }
        public virtual tb_Empresa tb_Empresa { get; set; }
    }
}
