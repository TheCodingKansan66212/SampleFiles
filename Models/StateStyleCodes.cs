using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateStyleCodes {

        [Key]
        [Required]
        public int StateStyleCodeId { get; set; }

        [Required]
        [Display(Name ="State Style Code Name")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string StateStyleCodeName { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="Notes")]
        [StringLength(150, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Notes { get; set; }
        public Nullable<int> MetroStyleCodeId { get; set; }

        [Required]
        public bool IsActive { get; set; }
 

    }
}
