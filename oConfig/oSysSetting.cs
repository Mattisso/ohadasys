using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations;


namespace AccSyscOhoda.Entities
{
    public class oSysSetting
    {
        [Key]
        public Guid  Id {get; set;}
        public string PathInputFile {get; set;}
        public string PathOutputHeaderFile {get; set;}
        public string PathOutputItemsFile {get; set;}
        public string UserManual {get; set;}

    }
}