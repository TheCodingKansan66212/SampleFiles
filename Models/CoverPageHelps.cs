using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CoverPageHelps
    {
         [Key]
         [Required]
        public int CoverPageHelpId { get; set; }

        [Display(Name = "Sequence")]
        public int Sequence { get; set; }

        [Required]
        [Display(Name = "Note")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

        [Display(Name = "Destination ID")]
        public int DestinationId { get; set; }

        [Display(Name = "Leasing Company ID")]
        public int LeasingCompanyId { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
