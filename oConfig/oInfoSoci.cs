

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AccSyscOhoda.Entities
{
   // [TrackChanges]
    public class oInfoSoci :  IEntity<Guid>
    {
        public oInfoSoci()
            {
              
               

            }
        
        [Key]
        public Guid  Id {get; set;}

        [Required(ErrorMessage = "Please enter a name")]
        public string NomSoci { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Address1 {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Address2 {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Activite1 { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Activite2 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string State {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Phone {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Fax {get; set;}

        [Required(AllowEmptyStrings = true)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string NumFiscal {get; set;}

        //public byte[] ImageData { get; set; }
        //public string ImageMimeType { get; set; }

       public virtual ICollection<File> Files { get; set; }
       public virtual ICollection<oFilePath> oFilePaths { get; set; }
            }
}