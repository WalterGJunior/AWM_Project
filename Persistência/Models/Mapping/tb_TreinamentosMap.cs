using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_TreinamentosMap : EntityTypeConfiguration<tb_Treinamentos>
    {
        public tb_TreinamentosMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Treinamentos);

            // Properties
            this.Property(t => t.nomeTreinamento)
                .HasMaxLength(50);

            this.Property(t => t.descricaoTreinamento)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("tb_Treinamentos");
            this.Property(t => t.Id_Treinamentos).HasColumnName("Id_Treinamentos");
            this.Property(t => t.CodTreinamento).HasColumnName("CodTreinamento");
            this.Property(t => t.nomeTreinamento).HasColumnName("nomeTreinamento");
            this.Property(t => t.descricaoTreinamento).HasColumnName("descricaoTreinamento");
            this.Property(t => t.PalestranteID).HasColumnName("PalestranteID");

            // Relationships
            this.HasOptional(t => t.tb_Palestrante)
                .WithMany(t => t.tb_Treinamentos)
                .HasForeignKey(d => d.PalestranteID);

        }
    }
}
