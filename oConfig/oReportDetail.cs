using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel;


namespace AccSyscOhoda.Entities
{
    //[TrackChanges]
    public class oReportDetail :   IEntity<Guid>
    {
       public oReportDetail()
       {
          
       }
       [Key]
       public Guid  Id {get; set;}
       public Guid oReportHeaderId {get; set;}
       public Guid oReferenceId {get; set;}
       public nLevel nLevels { get; set; }
       public int SortOrder {get; set;}
       [DefaultValue("1")]
       public CurrentFlag CurrentFlag { get; set; }
       public virtual oReference oReferences {get; set;}
       public virtual oReportHeader oReportHeaders {get; set;}
    }
}