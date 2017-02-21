using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class MetroStyleCode
    {
        [Key]
        [Required]
        public int MetroStyleCodeId { get; set; }

        [Required]
        [Display(Name = "Metro Style Code Name")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string MetroStyleCodeName { get; set; }

        [Display(Name = "Description")]
        [StringLength(150, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
