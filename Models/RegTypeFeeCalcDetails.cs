using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class RegTypeFeeCalculationDetail
    {
        [Key]
        [Required]
        [Display(Name ="Registration Type Fee Calculation Detail ID")]
        public int RegTypeFeeCalculationDetailId { get; set; }

        [Display(Name ="Value")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Value { get; set; }

        [Display(Name ="Special Notes")]
        [StringLength(500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string SpecialNotes { get; set; }

        [Display(Name ="Base Fee")]
        public Nullable<decimal> BaseFee { get; set; }

        [Display(Name ="Interval")]
        public Nullable<int> Interval { get; set; }

        [Display(Name ="Interval Cost")]
        public Nullable<decimal> IntervalCost { get; set; }

        [Display(Name ="Percentage")]
        public Nullable<double> Percentage { get; set; }

        [Display(Name ="Minimum Value")]
        public Nullable<double> MinValue { get; set; }

        [Display(Name ="Maximum Value")]
        public Nullable<double> MaxValue { get; set; }

    }
}
