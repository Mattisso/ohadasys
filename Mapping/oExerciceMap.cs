using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class oExerciceMap : EntityTypeConfiguration<oExercice>
    {
        public oExerciceMap()
        {
            // Primary Key
            this.HasKey(t => t.oExercComptaId);

            // Properties
        

            // Table & Column Mappings
            this.ToTable("oExercice");
            this.Property(t => t.oExercComptaId).HasColumnName("oExercComptaId");
            this.Property(t => t.ExercicePrev).HasColumnName("ExercicePrev");


            // Relationships
            this.HasRequired(t => t.oExercComptas)
            .WithOptional(t => t.oExercices)
            .WillCascadeOnDelete(true);
        }
    }
}
