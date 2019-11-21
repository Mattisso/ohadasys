
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oRptGroupingC : IEntity<Guid>
    {
        public oRptGroupingC()

        {
            this.oRptGroupings = new HashSet<oRptGrouping>();
           
        }

        [Key]
        public Guid  Id {get; set;}
         public Guid oRptGroupingBId { get; set; }
         public Guid ReferenceId {get; set;}
        public int SortOrderC { get; set; }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oRptGroupingB oRptGroupingBs { get; set; }
        public virtual ICollection<oRptGrouping> oRptGroupings { get; set; }
    }
}