using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class RequirementLookup
    {
        [Key]
        [Required]
        [Display(Name ="Requirement Lookup ID")]
        public int RequirementLookupId { get; set; }

        [Required]
        [Display(Name ="Value")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Value { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
