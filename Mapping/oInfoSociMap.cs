using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities
{
    public class oInfoSociMap : EntityTypeConfiguration<oInfoSoci>
    {
        public oInfoSociMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NomSoci)
                .HasMaxLength(255);

            this.Property(t => t.Address1)
                .HasMaxLength(150);

            this.Property(t => t.Address2)
                .HasMaxLength(150);

            this.Property(t => t.NumFiscal)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.Activite1)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Activite2)
                .IsFixedLength()
                .HasMaxLength(10);
            

            // Table & Column Mappings
            this.ToTable("oInfoSoci");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NomSoci).HasColumnName("NomSoci");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.NumFiscal).HasColumnName("NumFiscal");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Activite1).HasColumnName("Activite1");
            this.Property(t => t.Activite2).HasColumnName("Activite2");
        }
    }
}
