using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkType
    {
        [Key]
        [Required]
        public int WorkTypeId { get; set; }

        [Display(Name ="Note")]
        [StringLength(250, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Note { get; set; }

        [Display(Name ="Help Text")]
        public string HelpText { get; set; }

        [Display(Name ="Needs County")]
        public Nullable<bool> NeedsCounty { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
