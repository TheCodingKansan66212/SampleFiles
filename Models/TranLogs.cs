using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TranLogs
    {
        [Key]
        [Required]
        public int TranLogId { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> AlteredDate { get; set; }

        [Display(Name = "Note")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

    }
}
