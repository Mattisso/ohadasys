using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace AccSyscOhoda.Entities.Mappings
{
    public class oTableauPosteMap : EntityTypeConfiguration<oTableauPoste>
    {
        public oTableauPosteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TableauName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tbleauLongName)
                .HasMaxLength(255);

           // this.Property(t => t.CurrentFlag).IsOptional();

           

            // Table & Column Mappings
            this.ToTable("oTableauPoste");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TableauName).HasColumnName("TableauName");
            this.Property(t => t.tbleauLongName).HasColumnName("tbleauLongName");
         //   this.Property(t => t.CurrentFlag).HasColumnName("CurrentFlag");


            // Relationships
           
        }
    }
}
