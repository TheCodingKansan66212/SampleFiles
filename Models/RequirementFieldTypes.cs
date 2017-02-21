using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class RequirementFieldType
    {
        [Key]
        [Required]
        [Display(Name ="Requirement Field Type ID")]
        public int RequirementFieldTypeId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

       
    }
}
