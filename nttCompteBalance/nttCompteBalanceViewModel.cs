using AccSyscOhoda.Entities;
using AccSyscOhoda.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities
{
    public class nttCompteBalanceViewModel : IEntity<Guid>,  IObjectState 
    {
        public nttCompteBalanceViewModel()
        {
            nttCompteBalanceDetails = new List<nttCompteBalanceDetailViewModel>();
            CompteBalanceDetailsDetelete = new List<int>();
            }
      //  private ICollection<nttCompteBalanceDetailViewModel> _nttCompteBalanceDetails;

        public Guid  Id { get; set; }
        public Guid oReferenceId { get; set; }
        public int oExercComptaId { get; set; }
        public Guid oTableauPosteId { get; set; }
        public int DetailCount { get; set; }      
        public List<int> CompteBalanceDetailsDetelete {get; set;}
        public string MessageToClient { get; set; }
        public List<nttCompteBalanceDetailViewModel> nttCompteBalanceDetails {get; set;}
        [NotMapped]
        public ObjectState ObjectState { get; set; }






    }
}
