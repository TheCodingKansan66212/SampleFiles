using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Deposits
    {
        [Key]
        [Required]
        public int DepositId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? DepositDate { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public float Amount { get; set; }


        [Display(Name = "Number Item")]
        public int NumberItem { get; set; }
    }
}
