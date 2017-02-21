using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class RegTypeFeeCalculation
    {
        [Key]
        [Required]
        [Display(Name ="Registration Type Fee Calculation ID")]
        public int RegTypeFeeCalculationId { get; set; }

        [Display(Name ="Description")]
        [StringLength(500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }
        
        [Required]
        public bool IsActive { get; set; }

    }
}
