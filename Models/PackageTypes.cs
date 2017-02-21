using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class PackageType
    {
        [Key]
        [Required]
        [Display(Name = "Package Type ID")]
        public int PackageTypeId { get; set; }

        [Required]
        [Display(Name ="Package Type Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PackageTypeName { get; set; }

        [Display(Name = "Package Description")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PackageDescription { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
