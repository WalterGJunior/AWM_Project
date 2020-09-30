using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_UsuarioMap : EntityTypeConfiguration<tb_Usuario>
    {
        public tb_UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Usuario);

            // Properties
            this.Property(t => t.usuario)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("tb_Usuario");
            this.Property(t => t.Id_Usuario).HasColumnName("Id_Usuario");
            this.Property(t => t.usuario).HasColumnName("usuario");
            this.Property(t => t.senha).HasColumnName("senha");
        }
    }
}
