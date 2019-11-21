
using System.ComponentModel.DataAnnotations;
namespace AccSyscOhoda.Entities
{
    public enum nLevel: byte
    {
        [Display(Name = "Grand Total Reference Level 1")]
        A=1,
        [Display(Name = "Grand Total Reference Level 2")]
        B=2,
        [Display(Name = "Grand Total Reference Level 3")]
        C=3,
        [Display(Name = "Grand Total Reference Level 4")]
        R=4,
        [Display(Name = "Grand Total Gestion Level 5")]
        G=5,
        [Display(Name = "Grand Total Resultat Level 6")]
        T=6
    }
}
