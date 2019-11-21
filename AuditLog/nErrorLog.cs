using System;
using System.ComponentModel.DataAnnotations;

namespace AccSyscOhoda.Entities
{
    public class nErrorLog

       
    {
        [Key]
        public Guid  Id {get; set;}
        private DateTime errorTime=DateTime.Now;
        public DateTime ErrorTime
        {
            get { return errorTime; }
            set
            {
                if (value == null) errorTime = value;

            }
        }
        public string UserName { get; set; }
        public int ErrorNumber { get; set; }
        public int ErrorSeverity { get; set; }
        public int ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int ErrorLine {get; set;}
        public string ErrorMessage {get; set;}
      
        }
}