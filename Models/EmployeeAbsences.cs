using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class EmployeeAbsences
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Reason Code")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ReasonCode { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? DateAbsent { get; set; }

        [Display(Name = "Hours")]
        public int Hours { get; set; }

        [Display(Name = "Note")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

    }
}
