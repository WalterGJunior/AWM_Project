using System;
using System.Collections.Generic;

namespace Persistência.Models
{
    public partial class tb_Usuario
    {
        public int Id_Usuario { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}
