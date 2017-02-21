using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class DeliveryDefaults
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Out Return")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OutReturn { get; set; }

        [Display(Name = "Billing Account Number")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingAccountNumber { get; set; }

        [Display(Name = "Service Type ID")]
        public int ServiceTypeId { get; set; }

        [Display(Name = "Package Type ID")]
        public int PackageTypeId { get; set; }
    }
}
