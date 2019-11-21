using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oReportDetailMap : EntityTypeConfiguration<oReportDetail>
    {
        public oReportDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties





            // Table & Column Mappings
            this.ToTable("oReportDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oReportHeaderId).HasColumnName("oReportHeaderId");
            this.Property(t => t.oReferenceId).HasColumnName("oReferenceId");
            this.Property(t => t.nLevels).HasColumnName("nLevels");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");




            // Relationships
            this.HasRequired(t => t.oReportHeaders)
          .WithMany(t => t.oReportDetails)
          .HasForeignKey(t => t.oReportHeaderId)
          .WillCascadeOnDelete(true);

            this.HasRequired(t => t.oReferences)
        .WithMany(t => t.oReportDetails)
        .HasForeignKey(t => t.oReferenceId)
        .WillCascadeOnDelete(false);
        }
    }
}
