using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oReferenceMap : EntityTypeConfiguration<oReference>
    {
        public oReferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RefCode)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_RefCode") { IsUnique = true }));
            this.Property(t => t.Description)
             .IsRequired()
             .HasMaxLength(255);
            this.Property(t => t.FullDescription)
          .HasMaxLength(400);

            this.Property(t => t.RefDescription1)
          .HasMaxLength(255)
          .IsOptional();

            this.Property(t => t.RefDescription2)
          .HasMaxLength(255)
          .IsOptional();

            this.Property(t => t.RefDescription3)
             .HasMaxLength(255)
                         .IsOptional();
            
            this.Property(t => t.RefDescription4) 
            .HasMaxLength(255)
            .IsOptional();

            // Table & Column Mappings
            this.ToTable("oReference");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RefCode).HasColumnName("RefCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FullDescription).HasColumnName("FullDescription");
            this.Property(t => t.RefDescription1).HasColumnName("RefDescription1");
            this.Property(t => t.RefDescription2).HasColumnName("RefDescription2");
            this.Property(t => t.RefDescription3).HasColumnName("RefDescription3");
            this.Property(t => t.RefDescription4).HasColumnName("RefDescription4");
           
        }
    }
}
