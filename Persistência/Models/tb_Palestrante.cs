using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_Palestrante
    {
        public tb_Palestrante()
        {
            this.tb_Treinamentos = new List<tb_Treinamentos>();
        }

        public int Id_Palestrante { get; set; }
        public Nullable<int> matricula { get; set; }
        public string nome { get; set; }
        public Nullable<int> idade { get; set; }
        public Nullable<System.DateTime> datenascimento { get; set; }
        public string formacao { get; set; }
        public string telefonefixo { get; set; }
        public string telefonecelular { get; set; }
        public virtual ICollection<tb_Treinamentos> tb_Treinamentos { get; set; }
    }
}
