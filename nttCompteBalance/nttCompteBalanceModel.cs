using AccSyscOhoda.Sharedkernel;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccSyscOhoda.Entities
{
    //// [TrackChanges]
    public class nttCompteBalanceModel : IObjectState 
    {

        public Guid Id { get; set; }
        public int oExercComptaId { get; set; }
        public Guid oTableauPosteId { get; set; }
        public Guid oReferenceId { get; set; }
        public Nullable<decimal> TotalSoldeDebit { get; set; }
        public Nullable<decimal> TotalSoldeCredit { get; set; }
      //  public Guid nttCompteBalanceId { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }


    }
}