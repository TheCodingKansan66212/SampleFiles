using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CheckOuts
    {
        [Key]
        [Required]
        public int CheckOutId { get; set; }

        [Required]
        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? CheckDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float? Amount { get; set; }

        [Display(Name = "Payee")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Payee { get; set; }

        [Required]
        [Display(Name = "Returned")]
        public bool Returned { get; set; }

        [Required]
        [Display(Name = "Exported")]
        public bool Exported { get; set; }

        [Display(Name = "Printed")]
        public bool Printed { get; set; }

        [Display(Name = "Locked")]
        public bool Locked { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? ReconDate { get; set; }

        [Display(Name = "Check Memo")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CheckMemo { get; set; }

        [Display(Name = "Print Message")]
        [StringLength(160, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PrintMessage { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }



    }
}
