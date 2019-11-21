

using System;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
    public class ntBalanceExcept :   IEntity<Guid>
    {

        public ntBalanceExcept()
        {
           
        }
        [Key]
        public Guid  Id {get; set;}
        public string NumCompte {get; set;}
        public string NumberCompte {get; set;}
        public Guid oReferenceId {get; set;}

    }
}