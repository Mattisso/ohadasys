using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oStblArea : IEntity<Guid>
    {

        public oStblArea()
            {
                this.oCpteReferences = new HashSet<oCpteReference>();
               

            }

        [Key]
        public Guid  Id {get; set;}
        public string AreaShortName {get; set;}
       public string AreaLongName {get; set;}
       [DefaultValue("1")]  
       public CurrentFlag CurrentFlag { get; set; }
       public virtual ICollection<oCpteReference> oCpteReferences {get; set;}

    }
}