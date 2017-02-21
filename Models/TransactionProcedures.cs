using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TransactionProcedure
    {
        [Key]
        [Required]
        public int TransactionProcedureId { get; set; }

        [Display(Name ="Work Type ID")]
        public Nullable<int> WorkTypeId { get; set; }

        public Nullable<int> StateId { get; set; }
        public Nullable<int> CheckOutId { get; set; }
        public Nullable<int> DestinationId { get; set; }

        [Display(Name ="Sequence")]
        public int Seq { get; set; }

        [Display(Name ="Date In")]
        public Nullable<System.DateTime> DateIn { get; set; }

        [Display(Name ="Date Out")]
        public Nullable<System.DateTime> DateOut { get; set; }

        [Display(Name ="In Via ID")]
        public Nullable<int> InViaId { get; set; }

        [Display(Name ="Out Via ID")]
        public Nullable<int> OutViaId { get; set; }

        [Display(Name ="ETA")]
        public Nullable<System.DateTime> ETA { get; set; }

        [Display(Name ="Result")]
        [StringLength(40, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Result { get; set; }

        [Display(Name ="Result Date")]
        public Nullable<System.DateTime> ResultDate { get; set; }

        [Display(Name ="Rejected By")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RejectedBy { get; set; }

        [Display(Name ="Reject Reason")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RejectReason { get; set; }
        
        [Display(Name = "Set By Macro")]
        public Nullable<bool> SetByMacro { get; set; }

        [Required]
        public bool IsCurrent { get; set; }

    }
}
