

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccSyscOhoda.Entities
{
    public class nttBalance : IEntity<Guid>
    {

        
        public nttBalance()
        {
           
        }
        [Key]
        public Guid  Id {get; set;}
        public Guid oReferenceId {get; set;}
        public Guid oCompteId {get; set;}
        public int oExercComptaId { get; set; }
        public Guid oTableauPosteId { get; set; }
        [Display(Name = "Intitulé Compte")]
        public string IntitulCompte { get; set; }
        public string NumCompte {get; set;}
        public decimal ? SoldeDebit {get; set;}
        public decimal ? SoldeCredit {get; set;}
        public virtual oReference oReferences {get; set;}
        public virtual oCompte oComptes {get; set;}
        public virtual oExercCompta oExercComptas { get; set; }
        public virtual oTableauPoste oTableauPostes { get; set; }
     

    }
}