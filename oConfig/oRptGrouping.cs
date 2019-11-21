
using System;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
    public class oRptGrouping :  IEntity<Guid>
    {
         public oRptGrouping()
        {
           
        }

        [Key]
        public Guid  Id {get; set;}
         public Guid oTableauPosteId { get; set; }
         public Guid oReferenceId {get; set;}
         public Guid oRptGroupingAId { get; set; }
         public Guid oRptGroupingBId { get; set; }
         public Guid oRptGroupingCId { get; set; }
        public virtual oTableauPoste oTableauPostes { get; set; }
        public virtual oReference oReferences { get; set; }
        public virtual oRptGroupingA oRptGroupingAs { get; set; }
        public virtual oRptGroupingB oRptGroupingBs { get; set; }
        public virtual oRptGroupingC oRptGroupingCs { get; set; }
    }
}