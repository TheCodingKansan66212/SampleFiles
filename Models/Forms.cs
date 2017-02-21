using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Forms
    {
        [Key]
        [Required]
        public int FormId { get; set; }

        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name = "Filename")]
        public int Filename { get; set; }

        [Display(Name = "Printer Name")]
        [StringLength(60, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PrinterName { get; set; }

        [Required]
        [Display(Name = "Warn Prior")]
        public bool WarnPrior { get; set; }

        [Display(Name = "Default Destination")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DefaultDestination { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
