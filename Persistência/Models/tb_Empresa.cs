using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_Empresa
    {
        public tb_Empresa()
        {
            this.tb_AgendaTreinamentos = new List<tb_AgendaTreinamentos>();
            this.tb_Colaborador = new List<tb_Colaborador>();
        }

        public int Id_Empresa { get; set; }
        public string cnpj { get; set; }
        public string nomefantasia { get; set; }
        public string razaosocial { get; set; }
        public string endereco { get; set; }
        public Nullable<int> cep { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pessoaContato { get; set; }
        public virtual ICollection<tb_AgendaTreinamentos> tb_AgendaTreinamentos { get; set; }
        public virtual ICollection<tb_Colaborador> tb_Colaborador { get; set; }
    }
}
