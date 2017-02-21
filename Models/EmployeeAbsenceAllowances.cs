using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class EmployeeAbsenceAllowances
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Reason Code")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ReasonCode { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Allowance")]
        public int Allowance { get; set; }
    }
}
