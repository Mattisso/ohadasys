using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oRptGroupingMap : EntityTypeConfiguration<oRptGrouping>
    {
        public oRptGroupingMap()
        {
            //primary key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("oRptGrouping");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.oReferenceId).HasColumnName("oReferenceId");
            this.Property(t => t.oRptGroupingAId).HasColumnName("oRptGroupingAId");
            this.Property(t => t.oRptGroupingBId).HasColumnName("oRptGroupingBId");
            this.Property(t => t.oRptGroupingCId).HasColumnName("oRptGroupingCId");



            // Relationships
            this.HasRequired(t => t.oTableauPostes)
          .WithMany(t => t.oRptGroupings)
          .HasForeignKey(t => t.oTableauPosteId)
          .WillCascadeOnDelete(true);

            this.HasRequired(t => t.oReferences)
        .WithMany(t => t.oRptGroupings)
        .HasForeignKey(t => t.oReferenceId)
        .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oRptGroupingAs)
    .WithMany(t => t.oRptGroupings)
    .HasForeignKey(t => t.oRptGroupingAId)
    .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oRptGroupingBs)
    .WithMany(t => t.oRptGroupings)
    .HasForeignKey(t => t.oRptGroupingBId)
    .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oRptGroupingCs)
.WithMany(t => t.oRptGroupings)
.HasForeignKey(t => t.oRptGroupingCId)
.WillCascadeOnDelete(false);
           
        }
    }
}
