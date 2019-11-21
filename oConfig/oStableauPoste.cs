using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oStableauPoste : IEntity<Guid>
    {
           public oStableauPoste()
            {
                //this.oStblAreas = new List<oStblArea>();
                this.oCpteReferences = new HashSet<oCpteReference>();
               

            }

        [Key]
        public Guid  Id {get; set;}
         public Guid oTableauPosteId {get; set;}
        public string StableauName {get; set;}
        public string StbleauLongName {get; set;}
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oTableauPoste oTableauPostes {get; set;}
        //public virtual ICollection<oStblArea> oStblAreas {get; set;}
        public virtual ICollection<oCpteReference> oCpteReferences {get; set;}
       
    }
}
