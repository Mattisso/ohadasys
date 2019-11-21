using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oRptGroupingBMap : EntityTypeConfiguration<oRptGroupingB>
    {
        public oRptGroupingBMap()
        {
            //primary key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("oRptGroupingB");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oRptGroupingAId).HasColumnName("oRptGroupingAId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.SortOrderB).HasColumnName("SortOrderB");

            // Relationships
            this.HasRequired(t => t.oRptGroupingAs)
          .WithMany(t => t.oRptGroupingBs)
          .HasForeignKey(t => t.oRptGroupingAId)
          .WillCascadeOnDelete(true);
        }
    }
}
