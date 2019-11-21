

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oCpteReference : IEntity<Guid>
    {
        
        public oCpteReference()
        {
           
        }
        [Key]
        public Guid  Id {get; set;}
        public Guid oCompteId {get; set;}
        public Guid oReferenceId {get; set;}
        public Guid oTableauPosteId {get; set;}
        public Guid oStableauPosteId { get; set; }
        public Guid oStblAreaId { get; set; }
        [DefaultValue("false")]
        public Boolean Exception {get; set;}
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:P0}")]
        [RegularExpression(@"[0-9]+(\.[0-9][0-9]?)?$", ErrorMessage = "Invalid rate")]
        [Range (0.00, 100.00, ErrorMessage="Value must be a % between 0 and 100")]
        private decimal taux = 1;
        public decimal Taux
        {
            get { return taux; }
            set
            {
                taux = value;
                           }
        }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oReference oReferences {get; set;}
        public virtual oStblArea oStblAreas {get; set;}
        public virtual oCompte oComptes {get; set;}
        public virtual oTableauPoste oTableauPostes {get; set;}
        public virtual oStableauPoste oStableauPostes {get; set;} 
  

    }
}