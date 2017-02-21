using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class ServiceType
    {
        [Key]
        [Required]
        public int ServiceTypeId { get; set; }

        [Required]
        [Display(Name ="Service Type Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ServiceTypeName { get; set; }

        [Display(Name ="Service Type Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ServiceTypeDescription { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
