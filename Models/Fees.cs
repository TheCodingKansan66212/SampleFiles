using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Fees
    {
        [Key]
        [Required]
        public int FeeId { get; set; }

        [Required]
        [Display(Name = "Fee Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string FeeDescription { get; set; }

        [Display(Name = "Cost")]
        public float Cost { get; set; }
         
        [Display(Name = "Fee Amount")]
        public float FeeAmount { get; set; }

        [Required]
        [Display(Name = "Credit")]
        public bool Credit { get; set; }

        [Required]
        [Display(Name = "Allow Zero Cost")]
        public bool AllowZeroCost { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
