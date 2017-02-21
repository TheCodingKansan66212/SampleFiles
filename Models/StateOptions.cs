using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateOption
    {

        [Key]
        [Required]
        public int StateOptionId { get; set; }

        [Required]
        [Display(Name ="State Option Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string StateOptionName { get; set; }

        [Display(Name ="Description")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="Sequence")]
        public Nullable<int> Sequence { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }`
}
