using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oRptGroupingAMap : EntityTypeConfiguration<oRptGroupingA>
    {
        public oRptGroupingAMap()
        {
            //primary key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("oRptGroupingA");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oReportHeaderId).HasColumnName("oReportHeaderId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.SortOrderA).HasColumnName("SortOrderA");


            // Relationships
            this.HasRequired(t => t.oReportHeaders)
          .WithMany(t => t.oRptGroupingAs)
          .HasForeignKey(t => t.oReportHeaderId)
          .WillCascadeOnDelete(true);
           
        }
    }
}
