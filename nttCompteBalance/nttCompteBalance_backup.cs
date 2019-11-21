
////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.ComponentModel.DataAnnotations;
////using System.ComponentModel.DataAnnotations.Schema;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Collections.ObjectModel;
////using System.Collections.Specialized;
////using System.Collections;
////using AccSyscOhoda.Sharedkernel;

////namespace AccSyscOhoda.Entities
////{
////    // [TrackChanges]
////    public class nttCompteBalance : IEntity<Guid>, IObjectState
////    {
////        private ICollection<nttCompteBalanceDetail> _nttCompteBalanceDetails;
////        private int oreferenceId;
////        private int oexercComptaId;
////        private int otableauPosteId;
////        private Nullable<decimal> totalSoldeDebit;
////        private Nullable<decimal> totalSoldeCredit;


////        public nttCompteBalance()
////        {

////            _nttCompteBalanceDetails = new List<nttCompteBalanceDetail>();
////        }
////        [Key]
////        public Guid  Id { get; set; }
////        [Index("IX_oReferenceIdAndoExercComptaId", 1, IsUnique = true)]
////        [Display(Name = "Reference Code")]
////         public Guid oReferenceId
////        {
////            get { return oreferenceId; }
////            set { oreferenceId = value; }
////        }
////        [Index("IX_oReferenceIdAndoExercComptaId", 2, IsUnique = true)]
////        public int oExercComptaId
////        {
////            get { return oexercComptaId; }
////            set { oexercComptaId = value; }
////        }
////         public Guid oTableauPosteId
////        {
////            get { return otableauPosteId; }
////            set { otableauPosteId = value; }
////        }
////        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
////        [Display(Name = "Total Solde Debit")]

////        public Nullable<decimal> TotalSoldeDebit
////        {
////            get
////            {
////                if (nttCompteBalanceDetails == null) return 0;

////                else
////                    return nttCompteBalanceDetails.Sum(e => e.SoldeDebit);

////            }
////            set
////            {
////                totalSoldeDebit = value;
////            }
////        }
////        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
////        [Display(Name = "Total Solde Credit")]

////        public Nullable<decimal> TotalSoldeCredit
////        {
////            get
////            {
////                if (nttCompteBalanceDetails == null) return 0;

////                else
////                    return nttCompteBalanceDetails.Sum(e => e.SoldeCredit);
////            }
////            set
////            {
////                totalSoldeCredit = value;
////            }
////        }
////        [NotMapped]
////        public ObjectState ObjectState { get; set; }

////        public virtual oReference oReferences { get; set; }
////        public virtual oTableauPoste oTableauPostes { get; set; }
////        public virtual oExercCompta oExercComptas { get; set; }
////        public virtual ICollection<nttCompteBalanceDetail> nttCompteBalanceDetails
////        {
////            get { return _nttCompteBalanceDetails; }

////            set { _nttCompteBalanceDetails = value; }
////        }




////    }


////    public class nttCompteBalance : IEntity<Guid>, IObjectState
////    {

////        private ICollection<nttCompteBalanceDetail> _nttCompteBalanceDetails;

////        private readonly oReference _oreference;
////        private readonly oTableauPoste _otableauPoste;
////        private readonly oExercCompta _oexercCompta;


////        private Nullable<decimal> totalSoldeDebit;
////        private Nullable<decimal> totalSoldeCredit;


////        public static nttCompteBalance CreatenttCompteBalance(int oreferenceId, int otableauPosteId,
////          int oexercComptaId, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails
////       )
////        {
////            var nttcomptebalance = new nttCompteBalance(oreferenceId
////               , otableauPosteId, oexercComptaId, nttCompteBalanceDetails);
////            return nttcomptebalance;
////        }


////        private nttCompteBalance(int oreferenceId, int otableauPosteId, int oexercComptaId, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails)
////            : this()
////        {
////            Id = default(int);
////            oReferenceId = oreferenceId;
////            oTableauPosteId = otableauPosteId;
////            oExercComptaId = oexercComptaId;
////            ObjectState = ObjectState;

////            foreach (var item in nttCompteBalanceDetails)
////            {
////                CreatenttCompteBalanceDetail(item.NumCompte, item.IntitulCompte, item.SoldeDebit, item.SoldeCredit);

////            }

////        }


////        //  public static nttCompteBalance CreatenttCompteBalance(oReference oreference, oTableauPoste otableauPoste,
////        //   oExercCompta oexercCompta, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails
////        //)
////        //  {
////        //      var nttcomptebalance = new nttCompteBalance(oreference, 
////        //          otableauPoste, oexercCompta, nttCompteBalanceDetails);
////        //      return nttcomptebalance;
////        //  }




////        //  private nttCompteBalance(oReference oreference, oTableauPoste otableauPoste, oExercCompta oexercCompta, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails)
////        //      : this()
////        //  {
////        //      Id = default(int);
////        //      _oreference=oreference;
////        //      _otableauPoste = otableauPoste;
////        //      _oexercCompta = oexercCompta;
////        //      oReferenceId = oreference.Id;
////        //      oTableauPosteId = otableauPoste.Id;
////        //      oExercComptaId = oexercCompta.Id;
////        //      ObjectState = ObjectState;

////        //      foreach (var item in nttCompteBalanceDetails)
////        //      {
////        //          CreatenttCompteBalanceDetail(item.NumCompte, item.IntitulCompte, item.SoldeDebit, item.SoldeCredit);

////        //      }
////        //      _oreference = oreference;
////        //      _otableauPoste = otableauPoste;
////        //      _oexercCompta = oexercCompta;

////        //  }


////        public nttCompteBalance()
////        {

////            _nttCompteBalanceDetails = new List<nttCompteBalanceDetail>();
////        }


////        [Key]
////        public Guid  Id { get; set; }
////        [Index("IX_oReferenceIdAndoExercComptaId", 1, IsUnique = true)]
////        [Display(Name = "Reference Code")]
////         public Guid oReferenceId
////        {
////            get;
////            set;
////        }
////        [Index("IX_oReferenceIdAndoExercComptaId", 2, IsUnique = true)]
////        public int oExercComptaId
////        {
////            get;
////            set;
////        }
////         public Guid oTableauPosteId
////        {
////            get;
////            set;
////        }
////        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
////        [Display(Name = "Total Solde Debit")]

////        public Nullable<decimal> TotalSoldeDebit
////        {
////            get
////            {
////                if (nttCompteBalanceDetails == null) return 0;

////                else
////                    return nttCompteBalanceDetails.Sum(e => e.SoldeDebit);

////            }
////            set
////            {
////                totalSoldeDebit = value;
////            }
////        }
////        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
////        [Display(Name = "Total Solde Credit")]

////        public Nullable<decimal> TotalSoldeCredit
////        {
////            get
////            {
////                if (nttCompteBalanceDetails == null) return 0;

////                else
////                    return nttCompteBalanceDetails.Sum(e => e.SoldeCredit);
////            }
////            set
////            {
////                totalSoldeCredit = value;
////            }
////        }
////        [NotMapped]
////        public ObjectState ObjectState { get; set; }

////        public virtual oReference oReferences { get; set; }
////        public virtual oTableauPoste oTableauPostes { get; set; }
////        public virtual oExercCompta oExercComptas { get; set; }
////        public virtual ICollection<nttCompteBalanceDetail> nttCompteBalanceDetails
////        {
////            get { return _nttCompteBalanceDetails; }

////            set { _nttCompteBalanceDetails = value; }

////        }


////        public bool Validate()
////        {
////            if (nttCompteBalanceDetails.Any())
////            {
////                return true;
////            }
////            return false;
////        }



////        public void CreatenttCompteBalanceDetail(string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)
////        {
////            var nttcomptebalancedetails = nttCompteBalanceDetail.CreatenttCompteBalanceDetail(Id, numCompte, intitulCompte, soldeDebit, soldeCredit);
////            _nttCompteBalanceDetails.Add(nttcomptebalancedetails);
////        }





////    }



////}



///////////////////////////////////////////////////////////////////////////////////////////////

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.Collections;
//using AccSyscOhoda.Sharedkernel;

//namespace AccSyscOhoda.Entities
//{
//    // [TrackChanges]
//    public class nttCompteBalance : IEntity<Guid>, IObjectState
//    {
//        private ICollection<nttCompteBalanceDetail> _nttCompteBalanceDetails;
//        private int oreferenceId;
//        private int oexercComptaId;
//        private int otableauPosteId;
//        private Nullable<decimal> totalSoldeDebit;
//        private Nullable<decimal> totalSoldeCredit;


//        public nttCompteBalance()
//        {

//            _nttCompteBalanceDetails = new List<nttCompteBalanceDetail>();
//        }
//        [Key]
//        public Guid  Id { get; set; }
//        [Index("IX_oReferenceIdAndoExercComptaId", 1, IsUnique = true)]
//        [Display(Name = "Reference Code")]
//         public Guid oReferenceId
//        {
//            get { return oreferenceId; }
//            set { oreferenceId = value; }
//        }
//        [Index("IX_oReferenceIdAndoExercComptaId", 2, IsUnique = true)]
//        public int oExercComptaId
//        {
//            get { return oexercComptaId; }
//            set { oexercComptaId = value; }
//        }
//         public Guid oTableauPosteId
//        {
//            get { return otableauPosteId; }
//            set { otableauPosteId = value; }
//        }
//        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//        [Display(Name = "Total Solde Debit")]

//        public Nullable<decimal> TotalSoldeDebit
//        {
//            get
//            {
//                if (nttCompteBalanceDetails == null) return 0;

//                else
//                    return nttCompteBalanceDetails.Sum(e => e.SoldeDebit);

//            }
//            set
//            {
//                totalSoldeDebit = value;
//            }
//        }
//        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//        [Display(Name = "Total Solde Credit")]

//        public Nullable<decimal> TotalSoldeCredit
//        {
//            get
//            {
//                if (nttCompteBalanceDetails == null) return 0;

//                else
//                    return nttCompteBalanceDetails.Sum(e => e.SoldeCredit);
//            }
//            set
//            {
//                totalSoldeCredit = value;
//            }
//        }
//        [NotMapped]
//        public ObjectState ObjectState { get; set; }

//        public virtual oReference oReferences { get; set; }
//        public virtual oTableauPoste oTableauPostes { get; set; }
//        public virtual oExercCompta oExercComptas { get; set; }
//        public virtual ICollection<nttCompteBalanceDetail> nttCompteBalanceDetails
//        {
//            get { return _nttCompteBalanceDetails; }

//            set { _nttCompteBalanceDetails = value; }
//        }
//    }
//}






//public class nttCompteBalance : IEntity<Guid>, IObjectState
//{

//    private ICollection<nttCompteBalanceDetail> _nttCompteBalanceDetails;

//    //private readonly oReference _oreference;
//    //private readonly oTableauPoste _otableauPoste;
//    //private readonly oExercCompta _oexercCompta;


//    private Nullable<decimal> totalSoldeDebit;
//    private Nullable<decimal> totalSoldeCredit;


//    public static nttCompteBalance CreatenttCompteBalance(int oreferenceId, int otableauPosteId,
//      int oexercComptaId, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails
//   )
//    {
//        var nttcomptebalance = new nttCompteBalance(oreferenceId
//           , otableauPosteId, oexercComptaId, nttCompteBalanceDetails);
//        return nttcomptebalance;
//    }


//    private nttCompteBalance(int oreferenceId, int otableauPosteId, int oexercComptaId, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails)
//        : this()
//    {
//        Id = default(int);
//        oReferenceId = oreferenceId;
//        oTableauPosteId = otableauPosteId;
//        oExercComptaId = oexercComptaId;
//        ObjectState = ObjectState;

//        foreach (var item in nttCompteBalanceDetails)
//        {
//            CreatenttCompteBalanceDetail(item.NumCompte, item.IntitulCompte, item.SoldeDebit, item.SoldeCredit);

//        }

//    }


//    //  public static nttCompteBalance CreatenttCompteBalance(oReference oreference, oTableauPoste otableauPoste,
//    //   oExercCompta oexercCompta, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails
//    //)
//    //  {
//    //      var nttcomptebalance = new nttCompteBalance(oreference, 
//    //          otableauPoste, oexercCompta, nttCompteBalanceDetails);
//    //      return nttcomptebalance;
//    //  }




//    //  private nttCompteBalance(oReference oreference, oTableauPoste otableauPoste, oExercCompta oexercCompta, IEnumerable<nttCompteBalanceDetail> nttCompteBalanceDetails)
//    //      : this()
//    //  {
//    //      Id = default(int);
//    //      _oreference=oreference;
//    //      _otableauPoste = otableauPoste;
//    //      _oexercCompta = oexercCompta;
//    //      oReferenceId = oreference.Id;
//    //      oTableauPosteId = otableauPoste.Id;
//    //      oExercComptaId = oexercCompta.Id;
//    //      ObjectState = ObjectState;

//    //      foreach (var item in nttCompteBalanceDetails)
//    //      {
//    //          CreatenttCompteBalanceDetail(item.NumCompte, item.IntitulCompte, item.SoldeDebit, item.SoldeCredit);

//    //      }
//    //      _oreference = oreference;
//    //      _otableauPoste = otableauPoste;
//    //      _oexercCompta = oexercCompta;

//    //  }


//    public nttCompteBalance()
//    {

//        _nttCompteBalanceDetails = new List<nttCompteBalanceDetail>();
//    }


//    [Key]
//    public Guid  Id { get; set; }
//    [Index("IX_oReferenceIdAndoExercComptaId", 1, IsUnique = true)]
//    [Display(Name = "Reference Code")]
//     public Guid oReferenceId
//    {
//        get;
//        set;
//    }
//    [Index("IX_oReferenceIdAndoExercComptaId", 2, IsUnique = true)]
//    public int oExercComptaId
//    {
//        get;
//        set;
//    }
//     public Guid oTableauPosteId
//    {
//        get;
//        set;
//    }
//    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//    [Display(Name = "Total Solde Debit")]

//    public Nullable<decimal> TotalSoldeDebit
//    {
//        get
//        {
//            if (nttCompteBalanceDetails == null) return 0;

//            else
//                return nttCompteBalanceDetails.Sum(e => e.SoldeDebit);

//        }
//        set
//        {
//            totalSoldeDebit = value;
//        }
//    }
//    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//    [Display(Name = "Total Solde Credit")]

//    public Nullable<decimal> TotalSoldeCredit
//    {
//        get
//        {
//            if (nttCompteBalanceDetails == null) return 0;

//            else
//                return nttCompteBalanceDetails.Sum(e => e.SoldeCredit);
//        }
//        set
//        {
//            totalSoldeCredit = value;
//        }
//    }
//    [NotMapped]
//    public ObjectState ObjectState { get; set; }

//    public virtual oReference oReferences { get; set; }
//    public virtual oTableauPoste oTableauPostes { get; set; }
//    public virtual oExercCompta oExercComptas { get; set; }
//    public virtual ICollection<nttCompteBalanceDetail> nttCompteBalanceDetails
//    {
//        get { return _nttCompteBalanceDetails; }

//        set { _nttCompteBalanceDetails = value; }

//    }


//    public bool Validate()
//    {
//        if (nttCompteBalanceDetails.Any())
//        {
//            return true;
//        }
//        return false;
//    }



//    public void CreatenttCompteBalanceDetail(string numCompte, string intitulCompte, Nullable<decimal> soldeDebit, Nullable<decimal> soldeCredit)
//    {
//        var nttcomptebalancedetails = nttCompteBalanceDetail.CreatenttCompteBalanceDetail(Id, numCompte, intitulCompte, soldeDebit, soldeCredit);
//        _nttCompteBalanceDetails.Add(nttcomptebalancedetails);
//    }





//}
