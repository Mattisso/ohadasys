using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oReportHeaderMap : EntityTypeConfiguration<oReportHeader>
    {
        public oReportHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
           
            // Table & Column Mappings
            this.ToTable("oReportHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.oReferenceId).HasColumnName("oReferenceId");
            this.Property(t => t.SortOrderH).HasColumnName("SortOrderH");

            // Relationships
            this.HasRequired(t => t.oTableauPostes)
          .WithMany(t => t.oReportHeaders)
          .HasForeignKey(t => t.oTableauPosteId)
          .WillCascadeOnDelete(true);

            this.HasRequired(t => t.oReferences)
        .WithMany(t => t.oReportHeaders)
        .HasForeignKey(t => t.oReferenceId)
        .WillCascadeOnDelete(false);
        }
    }
}
