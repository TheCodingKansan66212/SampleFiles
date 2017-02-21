using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class BillingMethods
    {
        [Key]
        [Required]
        public int BillingMethodId { get; set; }

        [Required]
        [Display(Name = "Billing Method Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingMethodName { get; set; }

        [Display(Name = "Billing Method Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingMethodDescription { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
