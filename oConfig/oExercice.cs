using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AccSyscOhoda.Entities
{
    public class oExercice 
    {
        [Key]
        [ForeignKey("oExercComptas")]
        [Display(Name = "Exercice Encour")]
       public int oExercComptaId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]  
        public int ExercicePrev
        {
            get { return oExercComptaId - 1; }
            private set { }
        }

        public virtual oExercCompta oExercComptas { get; set; }

    }
}