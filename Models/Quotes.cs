using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Quote
    {
        [Key]
        [Required]
        [Display(Name ="Quote ID")]
        public int QuoteId { get; set; }

        [Display(Name ="Last Used Date")]
        public Nullable<System.DateTime> LastUsedDate { get; set; }

        [Display(Name ="Last Used Time")]
        public Nullable<System.DateTime> LastUsedTime { get; set; }

        [Required]
        [Display(Name ="Quote")]
        public string Quote1 { get; set; }
    }
}
