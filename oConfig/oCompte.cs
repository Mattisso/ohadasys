

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oCompte :IEntity<Guid>
    {
            public oCompte()
        {
           
                this.oCpteReferences = new HashSet<oCpteReference>();
          
               
            }

        [Key]
        public Guid  Id {get; set;}
        [Index("IX_CompteNumber", IsUnique = true)]
        public string CompteNumber {get; set;}
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual ICollection<oCpteReference> oCpteReferences {get; set;}
        public virtual ICollection<nttBalance> nttBalances {get; set;}
        public virtual ICollection<nstBalance> nstBalances { get; set; }

    }
}