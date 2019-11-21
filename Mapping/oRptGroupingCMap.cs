using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oRptGroupingCMap : EntityTypeConfiguration<oRptGroupingC>
    {
        public oRptGroupingCMap()
        {
            //primary key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("oRptGroupingC");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oRptGroupingBId).HasColumnName("oRptGroupingBId");
            this.Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            this.Property(t => t.SortOrderC).HasColumnName("SortOrderC");


            // Relationships
            this.HasRequired(t => t.oRptGroupingBs)
          .WithMany(t => t.oRptGroupingCs)
          .HasForeignKey(t => t.oRptGroupingBId)
          .WillCascadeOnDelete(true);
        }
    }
}
