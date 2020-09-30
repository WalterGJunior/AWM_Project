using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_EmpresaMap : EntityTypeConfiguration<tb_Empresa>
    {
        public tb_EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Empresa);

            // Properties
            this.Property(t => t.cnpj)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nomefantasia)
                .HasMaxLength(50);

            this.Property(t => t.razaosocial)
                .HasMaxLength(50);

            this.Property(t => t.endereco)
                .HasMaxLength(50);

            this.Property(t => t.cidade)
                .HasMaxLength(20);

            this.Property(t => t.estado)
                .HasMaxLength(15);

            this.Property(t => t.pessoaContato)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_Empresa");
            this.Property(t => t.Id_Empresa).HasColumnName("Id_Empresa");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.nomefantasia).HasColumnName("nomefantasia");
            this.Property(t => t.razaosocial).HasColumnName("razaosocial");
            this.Property(t => t.endereco).HasColumnName("endereco");
            this.Property(t => t.cep).HasColumnName("cep");
            this.Property(t => t.telefone).HasColumnName("telefone");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.pessoaContato).HasColumnName("pessoaContato");
        }
    }
}
