using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_AlunoTreinamentoMap : EntityTypeConfiguration<tb_AlunoTreinamento>
    {
        public tb_AlunoTreinamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_AlunoTreinamento);

            // Properties
            // Table & Column Mappings
            this.ToTable("tb_AlunoTreinamento");
            this.Property(t => t.Id_AlunoTreinamento).HasColumnName("Id_AlunoTreinamento");
            this.Property(t => t.AgendaTreinamentoID).HasColumnName("AgendaTreinamentoID");
            this.Property(t => t.colaboradorID).HasColumnName("colaboradorID");
            this.Property(t => t.Presenca).HasColumnName("Presenca");
            this.Property(t => t.NotaAvaliacao).HasColumnName("NotaAvaliacao");

            // Relationships
            this.HasRequired(t => t.tb_AgendaTreinamentos)
                .WithMany(t => t.tb_AlunoTreinamento)
                .HasForeignKey(d => d.AgendaTreinamentoID);
            this.HasRequired(t => t.tb_Colaborador)
                .WithMany(t => t.tb_AlunoTreinamento)
                .HasForeignKey(d => d.colaboradorID);

        }
    }
}
