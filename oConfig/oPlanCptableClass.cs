using System;
using System.ComponentModel.DataAnnotations;
namespace AccSyscOhoda.Entities
{
    public class oPlanCptableClass : IEntity<Guid>
    {
        [Key]
        public Guid  Id {get; set;}
        public string ClassName {get; set;}
        public string ClassNumber {get; set;}

    }
}