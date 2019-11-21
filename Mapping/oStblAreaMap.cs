using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oStblAreaMap : EntityTypeConfiguration<oStblArea>
    {
        public oStblAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AreaShortName)
                .HasMaxLength(50);

            this.Property(t => t.AreaLongName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("oStblArea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AreaShortName).HasColumnName("AreaShortName");
            this.Property(t => t.AreaLongName).HasColumnName("AreaLongName");

            // Relationships
           
        }
    }
}
