using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Persistência.Models.Mapping;

namespace Persistência.Models
{
    public partial class BANCO_AWMContext : DbContext
    {
        static BANCO_AWMContext()
        {
            Database.SetInitializer<BANCO_AWMContext>(null);
        }

        public BANCO_AWMContext()
            : base("Name=BANCO_AWMContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tb_AgendaTreinamentos> tb_AgendaTreinamentos { get; set; }
        public DbSet<tb_AlunoTreinamento> tb_AlunoTreinamento { get; set; }
        public DbSet<tb_Colaborador> tb_Colaborador { get; set; }
        public DbSet<tb_Empresa> tb_Empresa { get; set; }
        public DbSet<tb_Palestrante> tb_Palestrante { get; set; }
        public DbSet<tb_Treinamentos> tb_Treinamentos { get; set; }
        public DbSet<tb_Usuario> tb_Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tb_AgendaTreinamentosMap());
            modelBuilder.Configurations.Add(new tb_AlunoTreinamentoMap());
            modelBuilder.Configurations.Add(new tb_ColaboradorMap());
            modelBuilder.Configurations.Add(new tb_EmpresaMap());
            modelBuilder.Configurations.Add(new tb_PalestranteMap());
            modelBuilder.Configurations.Add(new tb_TreinamentosMap());
            modelBuilder.Configurations.Add(new tb_UsuarioMap());
        }
    }
}
