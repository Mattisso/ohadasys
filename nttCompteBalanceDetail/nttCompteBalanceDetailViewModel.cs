using AccSyscOhoda.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities
{
    public class nttCompteBalanceDetailViewModel : IEntity<Guid>, IObjectState
    {


        public Guid  Id { get; set; }
        public Guid nttCompteBalanceId { get; set; }
       [StringLength(10, ErrorMessage = "Server: Numero Compte must be 10 characters or shorter.")]
        public string NumCompte { get; set; }
       [StringLength(155, ErrorMessage = "Server: IntitulCompte must be 155 characters or shorter.")]
        public string IntitulCompte { get; set; }
        public Nullable<decimal> SoldeDebit { get; set; }
        public Nullable<decimal> SoldeCredit { get; set; }
        //public bool Assigned { get; set; }
        [NotMapped]
        public ObjectState ObjectState { get; set; }


    }
}
