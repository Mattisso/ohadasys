
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oRptGroupingB : IEntity<Guid>
    {
        public oRptGroupingB()
        {
            this.oRptGroupingCs = new HashSet<oRptGroupingC>();
            this.oRptGroupings = new HashSet<oRptGrouping>();
           
        }

        [Key]
        public Guid  Id {get; set;}
        public Guid oRptGroupingAId { get; set; }
        public Guid ReferenceId { get; set; }
        public int SortOrderB { get; set; }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oRptGroupingA oRptGroupingAs { get; set; }
        public virtual ICollection<oRptGroupingC> oRptGroupingCs { get; set; }
        public virtual ICollection<oRptGrouping> oRptGroupings { get; set; }
    }
}