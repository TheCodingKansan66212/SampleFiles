using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class RegTypeFee
    {
        [Key]
        [Required]
        [Display(Name ="Registration Type Fee ID")]
        public int RegTypeFeeId { get; set; }

        [Required]
        [Display(Name ="Fee")]
        public decimal Fee { get; set; }

        [Display(Name ="Fee ID")]
        public Nullable<int> FeeId { get; set; }

        [Display(Name ="Special Notes")]
        [StringLength(500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string SpecialNotes { get; set; }

        [Required]
        [Display(Name ="Is Prorated")]
        public bool IsProrated { get; set; }
        
        [Required]
        public bool IsActive { get; set; }
    }
}
