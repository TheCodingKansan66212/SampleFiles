using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class DeliveryBillingOptions
    {
        [Required]
        [Key]
        public int BillingOptionId { get; set; }

        [Required]
        [Display(Name = "Billing Option Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingOptionName { get; set; }

        [Display(Name = "Billing Option Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingOptionDescription { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
