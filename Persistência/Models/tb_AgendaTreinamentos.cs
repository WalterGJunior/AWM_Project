using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_AgendaTreinamentos
    {
        public tb_AgendaTreinamentos()
        {
            this.tb_AlunoTreinamento = new List<tb_AlunoTreinamento>();
        }

        public int Id_AgendaTreinamentos { get; set; }
        public System.DateTime dtInicio { get; set; }
        public System.DateTime dtTermino { get; set; }
        public string qtdeparticipantes { get; set; }
        public string descricao { get; set; }
        public Nullable<int> TreinamentosID { get; set; }
        public Nullable<int> EmpresaID { get; set; }
        public virtual tb_Empresa tb_Empresa { get; set; }
        public virtual tb_Treinamentos tb_Treinamentos { get; set; }
        public virtual ICollection<tb_AlunoTreinamento> tb_AlunoTreinamento { get; set; }
    }
}
