using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class OutboundLog
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Nullable<int> TransactionId { get; set; }

        [Display(Name ="TranProcId")]
        public Nullable<int> TranProcId { get; set; }


        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Timestamp { get; set; }

        [Display(Name ="Checkout ID")]
        public Nullable<int> CheckOutId { get; set; }

        [Required]
        [Display(Name = "Airbill Out")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AirbillOut { get; set; }

        [Display(Name = "Airbill In")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AirbillIn { get; set; }

    }
}
