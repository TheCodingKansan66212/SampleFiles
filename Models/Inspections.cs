using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Inspections
    {
        [Required]
        [Key]
        public int InspectionId { get; set; }

        [Display(Name = "Cycle")]
        public byte Cycle { get; set; }

        [Display(Name = "Cycle 2")]
        public byte Cycle2 { get; set; }

        [Display(Name = "MSO Exempt Age")]
        public byte MSOExemptAge { get; set; }

        [Display(Name = "MSO Exempt Age 2")]
        public byte MSOExemptAge2 { get; set; }
    }
}
