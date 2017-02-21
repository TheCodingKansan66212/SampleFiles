using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkStationDrop
    {
        [Key]
        [Required]
        public int WorkStationDropId { get; set; }

        [Required]
        [Display(Name = "Workstation ID")]
        public int WorkStationId { get; set; }

        [Required]
        [Display(Name ="Dropout Type")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string DropOutType { get; set; }

        [Required]
        [Display(Name ="Dropout Label")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string DropOutLabel { get; set; }
    }
}
