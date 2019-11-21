namespace AccSyscOhoda.Entities
{

    
    using System;
    using System.ComponentModel.DataAnnotations;
    public class oFilePath 
    {
        [Key]
        public int FilePathId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public Guid oInfoSociId { get; set; }
        public virtual oInfoSoci oInfoSoci { get; set; }
    }
}