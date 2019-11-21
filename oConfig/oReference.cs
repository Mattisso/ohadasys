

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oReference :  IEntity<Guid>
    {
        public oReference()
        {
           
            this.oCpteReferences = new List<oCpteReference>();
            this.nttBalances = new List<nttBalance>();
            this.oReportDetails = new List<oReportDetail>();
            this.oReportHeaders = new List<oReportHeader>();
            this.oRptGroupings = new List<oRptGrouping>();
            this.nttCompteBalances = new List<nttCompteBalance>();
        }
        [Key]
        public Guid  Id { get; set; }
        [Index("IX_RefCode", IsUnique = true)]
        [Display(Name = "Ref. Code")]
        public string RefCode { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        //[NotMapped]
        [Display(Name = "Reference Code")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullDescription
        {
            get { return string.Format("{0} {1} {2}", this.RefCode," - ", this.Description); }  //(this.RefCode + " - " + this.Description); }
            //private set { }

            private set { var names = value.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries); this.RefCode = names[0]; this.Description = names[1]; }
        }
        [Required(AllowEmptyStrings=true)]
        [DisplayFormat(ConvertEmptyStringToNull=false)]
        public string RefDescription1 { get; set; }
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string RefDescription2 { get; set; }
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string RefDescription3 { get; set; }
        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string RefDescription4 { get; set; }
        [DefaultValue("1")]      
        public CurrentFlag CurrentFlag { get; set; }
        public virtual ICollection<oCpteReference> oCpteReferences { get; set; }
        public virtual ICollection<nttBalance> nttBalances {get; set; }
        public virtual ICollection<nstBalance> nstBalances { get; set; }
        public virtual ICollection<oReportDetail> oReportDetails { get; set; }
        public virtual ICollection<oReportHeader> oReportHeaders { get; set; }
        public virtual ICollection<oRptGrouping> oRptGroupings { get; set; }
        public virtual ICollection<nttCompteBalance> nttCompteBalances { get; set; }

    }

   //public  class oReferenceComparer : IEqualityComparer<oReference>
   // {
   //     public bool Equals(oReference x, oReference y)
   //     {
   //         if (x.Id == y.Id && x.FullDescription.ToLower() == y.FullDescription.ToLower())
   //             return true;

   //         return false;
   //     }

   //     public int GetHashCode(oReference obj)
   //     {
   //         return obj.Id.GetHashCode();
   //     }
   // }
}