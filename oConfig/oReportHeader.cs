
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AccSyscOhoda.Entities
{
    //[TrackChanges]
    public class oReportHeader : IEntity<Guid>
    {
        
        public oReportHeader()
        {
            
            this.oReportDetails = new List<oReportDetail>();
            this.oRptGroupingAs = new List<oRptGroupingA>();
           
        }
        [Key]
        public Guid  Id {get; set;}
        public Guid oTableauPosteId { get; set; }
        public Guid oReferenceId { get; set; }
        public int SortOrderH { get; set; }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual ICollection<oReportDetail> oReportDetails {get; set; }
        public virtual ICollection<oRptGroupingA> oRptGroupingAs { get; set; }
        public virtual oReference oReferences { get; set; }
        public virtual oTableauPoste oTableauPostes { get; set; }
}
}