using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_PalestranteMap : EntityTypeConfiguration<tb_Palestrante>
    {
        public tb_PalestranteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Palestrante);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(50);

            this.Property(t => t.formacao)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("tb_Palestrante");
            this.Property(t => t.Id_Palestrante).HasColumnName("Id_Palestrante");
            this.Property(t => t.matricula).HasColumnName("matricula");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.idade).HasColumnName("idade");
            this.Property(t => t.datenascimento).HasColumnName("datenascimento");
            this.Property(t => t.formacao).HasColumnName("formacao");
            this.Property(t => t.telefonefixo).HasColumnName("telefonefixo");
            this.Property(t => t.telefonecelular).HasColumnName("telefonecelular");
        }
    }
}
