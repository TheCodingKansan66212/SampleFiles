using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateTax
    {
        [Key]
        [Required]
        public int StateTaxId { get; set; }

        [Required]
        [Display(Name ="Requirement ID")]
        public int RequirementId { get; set; }

        [Required]
        [Display(Name ="Requirement Value")]
        public decimal RequirementValue { get; set; }

        [Display(Name ="Special Notes")]
        [StringLength(500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string SpecialNotes { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
