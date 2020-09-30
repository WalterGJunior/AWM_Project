using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_AlunoTreinamento
    {
        public tb_AlunoTreinamento(int idAgenda)
        {
            this.AgendaTreinamentoID = idAgenda;
        }
        public tb_AlunoTreinamento()
        {

        }

        public int Id_AlunoTreinamento { get; set; }
        public int AgendaTreinamentoID { get; set; }
        public int colaboradorID { get; set; }
        public int Presenca { get; set; }
        public Nullable<decimal> NotaAvaliacao { get; set; }
        public virtual tb_AgendaTreinamentos tb_AgendaTreinamentos { get; set; }
        public virtual tb_Colaborador tb_Colaborador { get; set; }
    }
}
