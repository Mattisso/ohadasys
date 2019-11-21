
using System;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities

{
    public class FileDetail
    {
        public int  Id { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
         public int SupportId { get; set; }
        public virtual Support Support { get; set; }

    }
}
