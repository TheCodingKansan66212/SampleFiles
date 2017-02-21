using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CustomerExemptions
    {
        [Required]
        [Key]
        public int CustomerExemptionId { get; set; }

        [Display(Name = "City")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Exemption Number")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ExemptionNumber { get; set; }


    }
}
