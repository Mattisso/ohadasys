
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oRptGroupingD : IEntity<Guid>
    {
        public oRptGroupingD()
        {
           
        }

        [Key]
        public Guid  Id {get; set;}
         public Guid ReferenceId {get; set;}
         public Guid oRptGroupingCId{ get; set; }
        public int SortOrderD { get; set; }
        [DefaultValue("1")]
        [Display(Name = "Active")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oRptGroupingC oRptGroupingCs { get; set; }
    }
}