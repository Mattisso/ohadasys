using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities
{
    public class CompteBalanceIndexData
    {
        public IEnumerable<nttCompteBalance> nttCompteBalances { get; set; }
        public IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails { get; set; }
        public IEnumerable<oTableauPoste> oTableauPostes { get; set; }
        public int DetailCount { get; set; } 
        //public IEnumerable<oReference> oReferences { get; set; }
        //public IEnumerable<oExercCompta> oExercComptas { get; set; }
        //public IEnumerable<oExercice> oExercices { get; set; }

    }
}
