using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TagAgencyState
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name ="State")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string State { get; set; }

    }
}
