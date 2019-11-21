using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
   public class oExercComptaMap : EntityTypeConfiguration<oExercCompta>
    {
       public oExercComptaMap()
       {
           // Primary Key
           this.HasKey(t => t.Id);


           // Properties



           // Table & Column Mappings
           this.ToTable("oExercCompta");
           this.Property(t => t.Id).HasColumnName("Id")
           .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_oExercComptaId") { IsUnique = true }));
           this.Property(t => t.DateDebut).HasColumnName("DateDebut");
           this.Property(t => t.Datefin).HasColumnName("Datefin");
           this.Property(t => t.Cloture).HasColumnName("Cloture");
         

       }
    }
}
