using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oCpteReferenceMap : EntityTypeConfiguration<oCpteReference>
    {
        public oCpteReferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("oCpteReference");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oCompteId).HasColumnName("oCompteId");
            this.Property(t => t.oReferenceId).HasColumnName("oReferenceId");
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.oStableauPosteId).HasColumnName("oStableauPosteId");
            this.Property(t => t.oStblAreaId).HasColumnName("oStblAreaId");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.Taux).HasColumnName("Taux")
                .HasPrecision(18,2);
           
             //Relationships
            this.HasRequired(t => t.oComptes)
                .WithMany(t => t.oCpteReferences)
                .HasForeignKey(d => d.oCompteId)
                .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oReferences)
                .WithMany(t => t.oCpteReferences)
                .HasForeignKey(d => d.oReferenceId)
                .WillCascadeOnDelete(false);
            ;

            this.HasRequired(t => t.oTableauPostes)
              .WithMany(t => t.oCpteReferences)
              .HasForeignKey(d => d.oTableauPosteId)
              .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oStableauPostes)
               .WithMany(t => t.oCpteReferences)
               .HasForeignKey(d => d.oStableauPosteId)
               .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oStblAreas)
                .WithMany(t => t.oCpteReferences)
                .HasForeignKey(d => d.oStblAreaId)
                .WillCascadeOnDelete(false);


        }
    }
}
