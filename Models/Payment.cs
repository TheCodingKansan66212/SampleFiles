using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Payment
    {
        [Key]
        [Required]
        public int PaymentId { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime? CheckDate { get; set; }

        [Display(Name ="Check Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CheckNumber { get; set; }

        [Required]
        [Display(Name = "Check Amount")]
        public decimal CheckAmount { get; set; }

        [Display(Name = "Bank Deposit Number")]
        public int? BankDepositNumber { get; set; }

        [Required]
        public bool IsAdjustment { get; set; }
    }
}
