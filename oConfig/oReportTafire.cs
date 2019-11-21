using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
    public class oReportTafire : IEntity<Guid>
    {
        [Key]
        public Guid  Id { get; set; }
        public string TafireName { get; set; }
        public string tafireLongName { get; set; }
        [DefaultValue("1")]
        public CurrentFlag CurrentFlag { get; set; }
        public virtual ICollection<oReportHeader> oReportHeaders { get; set; }

    }
}
