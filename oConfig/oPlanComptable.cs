using System;
using System.ComponentModel.DataAnnotations;
namespace AccSyscOhoda.Entities
{
    public class oPlanComptable : IEntity<Guid>
    {
        [Key]
        public Guid  Id {get; set;}
        public string Compte {get; set;}
        public string CompteName {get; set;}
        public string ClassNumber {get; set;}

    }
}