using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateHelpScan
    {
        [Key]
        [Required]
        public int StateHelpScanId { get; set; }

        [Display(Name ="Work Type ID")]
        public Nullable<int> WorkTypeId { get; set; }

        [Required]
        [Display(Name ="Filename")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Filename { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
