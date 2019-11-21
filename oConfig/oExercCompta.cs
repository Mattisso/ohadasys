

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;

namespace AccSyscOhoda.Entities
{
    //[TrackChanges]
    public class oExercCompta :IEntity<int>
    {
  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Display(Name = "Exercice Encour")]
        [RegularExpression(@"\d{4}", ErrorMessage = "Invalid Year")]
        [Index("IX_oExercComptaId", IsUnique = true)]
        [Range(1900, 3000)]
       [Column("oExercComptaId")]
        public int  Id {get;set;}

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        private DateTime dateDebut;
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set
            {
                if (value != null) dateDebut = value;
                else dateDebut = DateTime.Now;
            
            }}
         [DataType(DataType.DateTime)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        private DateTime dateFin;
        public DateTime Datefin
            {
            get { return dateFin; }
            set
            {
                if (value != null) dateFin = value;

                else dateFin = DateTime.Now;
            
            }}

        [DefaultValue("1")]
        public bool Cloture { get; set; }


        //public string GetDate()
        //{
        //    string start = DateTime.Parse(DateDebut).ToString("h:mm");
        //    string end = DateTime.Parse(Datefin).ToString("h:mm tt");
        //    string date = DateTime.Parse(DateDebut).ToShortDateString();
        //    return string.Format("{0} {1} - {2}", date, start, end);
        //}
        public virtual oExercice oExercices { get; set; }
        public virtual ICollection<nttCompteBalance> nttCompteBalances { get; set; }
        public virtual ICollection<nstBalance> nstBalances { get; set; }
        public virtual ICollection<nttBalance> nttBalances { get; set; }

    }
}