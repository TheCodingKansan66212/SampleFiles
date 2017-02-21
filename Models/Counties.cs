using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Counties
    {
        [Key]
        [Required]
        public int CountyId { get; set; }

        [Required]
        [Display(Name = "County Name")]
        [StringLength(60, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CountyName { get; set; }
    }
}
