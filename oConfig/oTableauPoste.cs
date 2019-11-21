using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oTableauPoste : IEntity<Guid>
    {
        public oTableauPoste()
            {
                this.oStableauPostes = new HashSet<oStableauPoste>();
                this.oCpteReferences = new HashSet<oCpteReference>();
                this.oReportHeaders = new HashSet<oReportHeader>();
                this.oRptGroupings = new HashSet<oRptGrouping>();
                this.nttCompteBalances = new HashSet<nttCompteBalance>();
               

            }

        [Key]
        public Guid  Id {get; set;}
        public string TableauName {get; set;}
        public string tbleauLongName {get; set;}
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual ICollection<oStableauPoste> oStableauPostes {get; set;}
        public virtual ICollection<oCpteReference> oCpteReferences {get; set;}
        public virtual ICollection<oReportHeader> oReportHeaders { get; set; }
        public virtual ICollection<oRptGrouping> oRptGroupings {get; set; }
        public virtual ICollection<nttCompteBalance> nttCompteBalances { get; set; }
        public virtual ICollection<nstBalance> nstBalances { get; set; }
        public virtual ICollection<nttBalance> nttBalances { get; set; }

    }
}