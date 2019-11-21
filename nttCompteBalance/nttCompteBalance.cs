
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;
using AccSyscOhoda.Sharedkernel;

namespace AccSyscOhoda.Entities
{
    
        // [TrackChanges]
        public class nttCompteBalance : IEntity<Guid>, IObjectState
        {
            private ICollection<nttCompteBalanceDetail> _nttCompteBalanceDetails;
            private Guid oreferenceId;
            private int oexercComptaId;
            private Guid otableauPosteId;
            private Nullable<decimal> totalSoldeDebit;
            private Nullable<decimal> totalSoldeCredit;


            public nttCompteBalance()
            {

                _nttCompteBalanceDetails = new List<nttCompteBalanceDetail>();
            }
            [Key]
            public Guid  Id { get; set; }
            [Index("IX_oReferenceIdAndoExercComptaId", 1, IsUnique = true)]
            [Display(Name = "Reference Code")]
            public Guid oReferenceId
            {
                get { return oreferenceId; }
                set { oreferenceId = value; }
            }
            [Index("IX_oReferenceIdAndoExercComptaId", 2, IsUnique = true)]
            public int oExercComptaId
            {
                get { return oexercComptaId; }
                set { oexercComptaId = value; }
            }
            public Guid oTableauPosteId
            {
                get { return otableauPosteId; }
                set { otableauPosteId = value; }
            }
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            [Display(Name = "Total Solde Debit")]

            public Nullable<decimal> TotalSoldeDebit
            {
                get
                {
                    if (nttCompteBalanceDetails == null) return 0;

                    else
                        return nttCompteBalanceDetails.Sum(e => e.SoldeDebit);

                }
                set
                {
                    totalSoldeDebit = value;
                }
            }
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            [Display(Name = "Total Solde Credit")]

            public Nullable<decimal> TotalSoldeCredit
            {
                get
                {
                    if (nttCompteBalanceDetails == null) return 0;

                    else
                        return nttCompteBalanceDetails.Sum(e => e.SoldeCredit);
                }
                set
                {
                    totalSoldeCredit = value;
                }
            }
            [NotMapped]
            public ObjectState ObjectState { get; set; }

            public virtual oReference oReferences { get; set; }
            public virtual oTableauPoste oTableauPostes { get; set; }
            public virtual oExercCompta oExercComptas { get; set; }
            public virtual ICollection<nttCompteBalanceDetail> nttCompteBalanceDetails
            {
                get { return _nttCompteBalanceDetails; }

                set { _nttCompteBalanceDetails = value; }
            }
        }
    }