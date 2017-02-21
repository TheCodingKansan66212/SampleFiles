using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class EmployeeSecurities
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Read Access")]
        public bool ReadAccess { get; set; }

        [Required]
        [Display(Name = "Write Access")]
        public bool WriteAccess { get; set; }

        [Required]
        [Display(Name = "Change Access")]
        public bool ChangeAccess { get; set;  }

        [Required]
        [Display(Name = "Delete Access")]
        public bool DeleteAccess { get; set; ]

    }
}
