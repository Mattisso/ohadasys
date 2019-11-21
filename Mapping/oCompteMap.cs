using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{

    public class oCompteMap : EntityTypeConfiguration<oCompte>
    {
        public oCompteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CompteNumber)
                .IsRequired()
                .HasMaxLength(13);

                          
            // Table & Column Mappings
            this.ToTable("oCompte");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompteNumber).HasColumnName("CompteNumber")
            .IsRequired()
            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CompteNumber") { IsUnique = true }));
            ;
           

        }
    }
}
