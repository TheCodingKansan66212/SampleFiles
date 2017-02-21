using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class AutoRptFormats
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Format Code")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string FormatCode { get; set; }

        [Display(Name = "Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }
    }
}
