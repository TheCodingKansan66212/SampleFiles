using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CustTypes
    {
        [Key]
        [Required]
        public int CustomerTypeId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
