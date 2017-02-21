using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class RequirementDisplayGroup
    { 
        [Required]
        public int RequirementGroupId { get; set; }

        [Required]
        [Display(Name ="Group Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string GroupName { get; set; }

        [Display(Name ="Group Description")]
        [StringLength(150, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string GroupDescription { get; set; }

        [Display(Name ="Display Order")]
        public Nullable<int> DisplayOrder { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
