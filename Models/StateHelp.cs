using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateHelp
    {
        [Key]
        [Required]
        public int StateHelpId { get; set; }

        [Required]
        [Display(Name ="State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string State { get; set; }

        [Display(Name ="Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="Help Text")]
        public string HelpText { get; set; }

    }
}
