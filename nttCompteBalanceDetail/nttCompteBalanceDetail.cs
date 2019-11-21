

using AccSyscOhoda.Sharedkernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities
{
    //// [TrackChanges]
    public class nttCompteBalanceDetail : IEntity<Guid>, IObjectState
    {
        public static nttCompteBalanceDetail CreatenttCompteBalanceDetail(Guid nttcompteBalanceId, string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)
        {
            return new nttCompteBalanceDetail(nttcompteBalanceId, numCompte, intitulCompte, soldeDebit, soldeCredit);
        }

        //private nttCompteBalanceDetail(int nttcompteBalanceId, string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)
        //{
        //    Id = default(int);
        //    nttCompteBalanceId = nttcompteBalanceId;
        //    NumCompte = numCompte;
        //    IntitulCompte = intitulCompte;
        //    SoldeDebit = soldeDebit;
        //    SoldeCredit = soldeCredit;
        //    //  ObjectState = ObjectState.Added;
        //}

        public nttCompteBalanceDetail(Guid nttcompteBalanceId, string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)
        {  //(int nttcompteBalanceId, string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)

            Id =   new Guid();
            nttCompteBalanceId = nttcompteBalanceId;
            NumCompte = numCompte;
            IntitulCompte = intitulCompte;
            SoldeDebit = soldeDebit;
            SoldeCredit = soldeCredit;
            ObjectState = ObjectState.Added;

        }

        public nttCompteBalanceDetail()
        {
        }

        private string numCompte;
        private string intitulCompte;
        private Nullable<decimal> soldeDebit;
        private Nullable<decimal> soldeCredit;

        //public nttCompteBalanceDetail()
        //{

        //}

        [Key]
        public Guid  Id { get; set; }
        private Guid _nttCompteBalanceId;
        [Index("IX_nttCompteBalanceIdAndNumCompte", 1, IsUnique = true)]
        public Guid nttCompteBalanceId // { get; set; }
        {
            get
            {
                return _nttCompteBalanceId;
            }
            set
            {
                if (_nttCompteBalanceId != value)
                {
                    if (nttCompteBalances != null && nttCompteBalances.Id != value)
                    {
                        nttCompteBalances = null;

                    }
                    _nttCompteBalanceId = value;
                }
            }
        }


        // public int oCompteId { get; set; }
        [Index("IX_nttCompteBalanceIdAndNumCompte", 2, IsUnique = true)]
        [Display(Name = "Num.  Compte")]
        public string NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }
        [Display(Name = "Intitulé Compte")]
        public string IntitulCompte
        {
            get { return intitulCompte; }
            set { intitulCompte = value; }
        }

        [Display(Name = "Solde Debit")]
        [DefaultValue("0.00")]
        public Nullable<decimal> SoldeDebit
        {
            get { return soldeDebit; }
            set { soldeDebit = value; }
        }
        [DefaultValue("0.00")]
        [Display(Name = "Solde Credit")]
        public Nullable<decimal> SoldeCredit
        {
            get { return soldeCredit; }
            set { soldeCredit = value; }
        }
        [NotMapped]
        public ObjectState ObjectState { get; set; }
        public virtual nttCompteBalance nttCompteBalances { get; set; }






        // [Key]
        // public Guid  Id {get; set;}
        // [Index("IX_nttCompteBalanceIdAndNumCompte", 1,IsUnique=true)]
        // public int nttCompteBalanceId { get; set; }
        //// public int oCompteId { get; set; }
        // [Index("IX_nttCompteBalanceIdAndNumCompte", 2,IsUnique=true)]
        // [Display(Name = "Num.  Compte")]
        // public string NumCompte { get; set; }   
        // [Display(Name = "Intitulé Compte")]
        // public string IntitulCompte { get; set; }
        // [Display(Name = "Solde Debit")]
        // [DefaultValue("0.00")]
        // public Nullable<decimal> SoldeDebit { get;  set; }     
        // [DefaultValue("0.00")]
        // [Display(Name = "Solde Credit")]
        // public Nullable<decimal> SoldeCredit { get; set; }   
        // [NotMapped]
        // public ObjectState ObjectState { get; set; }
        // public virtual nttCompteBalance nttCompteBalances {get;set;}
    }
}
