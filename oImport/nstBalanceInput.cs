using System;
using System.ComponentModel.DataAnnotations;
using AccSyscOhoda.Sharedkernel;

namespace AccSyscOhoda.Entities
{
    public class nstBalanceInput : IEntity<Guid>, IObjectState
    {
        public nstBalanceInput()
        {
           
        }
        [Key]
        public Guid  Id {get; set;}
        public string NumCompte {get; set;}
        public string IntitulCompte {get; set;}
        public decimal ? SoldeDebit {get; set;}
        public decimal ? SoldeCredit {get; set;}
        public ObjectState ObjectState  { get; set; }

          }
}