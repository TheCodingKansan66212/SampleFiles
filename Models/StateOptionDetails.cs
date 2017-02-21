using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateOptionDetail
    {

        [Key]
        [Required]
        public int StateOptionDetailId { get; set; }

        [Display(Name ="Value")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Value { get; set; }

        [Display(Name ="Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="Note")]
        [StringLength(1000, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

    }
}
