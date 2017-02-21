using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TypeElements
    {
        [Key]
        [Required]
        public int TypeElementId { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
