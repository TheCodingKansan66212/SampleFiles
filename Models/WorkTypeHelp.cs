using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkTypeHelp
    {
        [Key]
        [Required]
        public int WorkTypeHelpId { get; set; }

        [Display(Name ="Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Value")]
        public string Value { get; set; }

    }
}
