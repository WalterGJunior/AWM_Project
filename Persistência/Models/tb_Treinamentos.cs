using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_Treinamentos
    {
        public tb_Treinamentos()
        {
            this.tb_AgendaTreinamentos = new List<tb_AgendaTreinamentos>();
        }

        public int Id_Treinamentos { get; set; }
        public Nullable<int> CodTreinamento { get; set; }
        public string nomeTreinamento { get; set; }
        public string descricaoTreinamento { get; set; }
        public Nullable<int> PalestranteID { get; set; }
        public virtual ICollection<tb_AgendaTreinamentos> tb_AgendaTreinamentos { get; set; }
        public virtual tb_Palestrante tb_Palestrante { get; set; }
    }
}
