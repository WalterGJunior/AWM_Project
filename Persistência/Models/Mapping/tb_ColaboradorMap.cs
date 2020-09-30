using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Persistência.Models.Mapping
{
    public class tb_ColaboradorMap : EntityTypeConfiguration<tb_Colaborador>
    {
        public tb_ColaboradorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Colaborador);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(20);

            this.Property(t => t.rg)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.cpf)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.endereco)
                .HasMaxLength(50);

            this.Property(t => t.cidade)
                .HasMaxLength(20);

            this.Property(t => t.estado)
                .HasMaxLength(15);

            this.Property(t => t.email)
                .HasMaxLength(20);

            this.Property(t => t.cargo)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("tb_Colaborador");
            this.Property(t => t.Id_Colaborador).HasColumnName("Id_Colaborador");
            this.Property(t => t.matricula).HasColumnName("matricula");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.rg).HasColumnName("rg");
            this.Property(t => t.cpf).HasColumnName("cpf");
            this.Property(t => t.endereco).HasColumnName("endereco");
            this.Property(t => t.cep).HasColumnName("cep");
            this.Property(t => t.cidade).HasColumnName("cidade");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.telefoneFixo).HasColumnName("telefoneFixo");
            this.Property(t => t.telefoneCelular).HasColumnName("telefoneCelular");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.dtAdmissao).HasColumnName("dtAdmissao");
            this.Property(t => t.dtDemissao).HasColumnName("dtDemissao");
            this.Property(t => t.cargo).HasColumnName("cargo");
            this.Property(t => t.EmpresaID).HasColumnName("EmpresaID");

            // Relationships
            this.HasOptional(t => t.tb_Empresa)
                .WithMany(t => t.tb_Colaborador)
                .HasForeignKey(d => d.EmpresaID);

        }
    }
}
