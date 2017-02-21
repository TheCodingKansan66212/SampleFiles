using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TransactionFee
    {
        [Key]
        [Required]
        public int TransactionFeeId { get; set; }

        [Display(Name ="Work Type ID")]
        public Nullable<int> WorkTypeId { get; set; }


        [Display(Name ="Order Sequence")]
        public Nullable<int> OrderSequence { get; set; }

        [Display(Name ="Fee")]
        public Nullable<decimal> Fee { get; set; }

        [Display(Name ="Estimated Fee")]
        public Nullable<decimal> EstimatedFee { get; set; }

        [Display(Name ="Cost")]
        public Nullable<decimal> Cost { get; set; }

    }
}
