
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oRptGroupingA : IEntity<Guid>
    {
        public oRptGroupingA()
        {
            this.oRptGroupingBs = new HashSet<oRptGroupingB>();
            this.oRptGroupings = new HashSet<oRptGrouping>();
           
        }

        [Key]
        public Guid  Id {get; set;}
        public Guid oReportHeaderId { get; set; }
         public Guid ReferenceId {get; set;}
        public int SortOrderA { get; set; }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual oReportHeader oReportHeaders { get; set; }
        public virtual ICollection<oRptGroupingB> oRptGroupingBs { get; set; }
        public virtual ICollection<oRptGrouping> oRptGroupings { get; set; }
    }
}