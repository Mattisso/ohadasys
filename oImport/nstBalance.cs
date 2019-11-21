
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccSyscOhoda.Entities
{
    public class nstBalance : IEntity<Guid>
    {
        private Guid oreferenceId;
        private Guid ocompteId;
        private int oexercComptaId;
        private Guid otableauPosteId;
        private string numCompte;
        private string intitulCompte;
        private Nullable<decimal> soldeDebit;
        private Nullable<decimal> soldeCredit;
        
        public nstBalance()
        {

           
        }

        [Key]
        public Guid  Id {get; set;}
         public Guid oReferenceId
        {
            get { return oreferenceId; }
            set { oreferenceId = value; }
        }
         public Guid oCompteId
        {
            get { return ocompteId; }
            set { ocompteId = value; }
        }

        public int oExercComptaId
        {
            get { return oexercComptaId; }
            set { oexercComptaId = value; }
        }
        public Guid oTableauPosteId
        {
            get { return otableauPosteId; }
            set { otableauPosteId = value; }
        }
        public string IntitulCompte
        {
            get { return intitulCompte; }
            set { intitulCompte = value; }
        }
        public string NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }
        public Nullable<decimal> SoldeDebit
        {
            get { return soldeDebit; }
            set { soldeDebit = value; }
        }
        public Nullable<decimal> SoldeCredit
        {
            get { return soldeCredit; }
            set { soldeCredit = value; }
        }
        public virtual oReference oReferences {get; set;}
        public virtual oCompte oComptes {get; set;}
        public virtual oExercCompta oExercComptas { get; set; }
        public virtual oTableauPoste oTableauPostes { get; set; }

       
    }
}