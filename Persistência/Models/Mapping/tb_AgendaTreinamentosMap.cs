using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_AgendaTreinamentosMap : EntityTypeConfiguration<tb_AgendaTreinamentos>
    {
        public tb_AgendaTreinamentosMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_AgendaTreinamentos);

            // Properties
            this.Property(t => t.qtdeparticipantes)
                .HasMaxLength(50);

            this.Property(t => t.descricao)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_AgendaTreinamentos");
            this.Property(t => t.Id_AgendaTreinamentos).HasColumnName("Id_AgendaTreinamentos");
            this.Property(t => t.dtInicio).HasColumnName("dtInicio");
            this.Property(t => t.dtTermino).HasColumnName("dtTermino");
            this.Property(t => t.qtdeparticipantes).HasColumnName("qtdeparticipantes");
            this.Property(t => t.descricao).HasColumnName("descricao");
            this.Property(t => t.TreinamentosID).HasColumnName("TreinamentosID");
            this.Property(t => t.EmpresaID).HasColumnName("EmpresaID");

            // Relationships
            this.HasOptional(t => t.tb_Empresa)
                .WithMany(t => t.tb_AgendaTreinamentos)
                .HasForeignKey(d => d.EmpresaID);
            this.HasOptional(t => t.tb_Treinamentos)
                .WithMany(t => t.tb_AgendaTreinamentos)
                .HasForeignKey(d => d.TreinamentosID);

        }
    }
}
