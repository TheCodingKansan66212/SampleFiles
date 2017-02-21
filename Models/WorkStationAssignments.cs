using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public  class WorkStationAssignment
    {
        [Key]
        [Required]
        public int WorkStationAssignmentId { get; set; }

        [Required]
        [Display(Name ="Workstation ID")]
        public int WorkStationInvoiceId { get; set; }

      
    }
}
