using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class OutboundReport
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Filename")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Filename { get; set; }

        [Display(Name ="Format")]
        public string Format { get; set; }
    }
}
