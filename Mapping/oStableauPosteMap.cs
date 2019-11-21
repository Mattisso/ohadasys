using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings

{
    public class oStableauPosteMap : EntityTypeConfiguration<oStableauPoste>
    {
        public oStableauPosteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StableauName)
                .HasMaxLength(50);

            this.Property(t => t.StbleauLongName)
                .HasMaxLength(255);
    
       

            // Table & Column Mappings
            this.ToTable("oStableauPoste");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.StableauName).HasColumnName("StableauName");
            this.Property(t => t.StbleauLongName).HasColumnName("StbleauLongName");


            //Relationship
            this.HasRequired(t => t.oTableauPostes)
              .WithMany(t => t.oStableauPostes)
             .HasForeignKey(d => d.oTableauPosteId)
             .WillCascadeOnDelete(false);
        }
    }
}
