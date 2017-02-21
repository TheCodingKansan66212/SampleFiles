using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public partial class Requirement
    {
        [Key]
        [Required]
        public int RequirementId { get; set; }

        [Required]
        [Display(Name ="Requirement Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RequirementName { get; set; }

        [Display(Name ="Requirement Description")]
        [StringLength(500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RequirementDescription { get; set; }

        [Display(Name ="Field Length")]
        public Nullable<int> FieldLength { get; set; }

        [Display(Name ="Corporate")]
        public bool Corporate { get; set; }

        [Display(Name ="Display Order")]
        public Nullable<int> DisplayOrder { get; set; }

        [Display(Name ="Is Document")]
        public Nullable<bool> IsDocument { get; set; }

        [Display(Name ="Has Lookup Value")]
        public Nullable<bool> HasLookupValue { get; set; }

        [Required]
        [Display(Name ="Dealer Portal Only")]
        public bool DealerPortalOnly { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }

}
