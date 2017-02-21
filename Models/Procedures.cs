using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class Procedure
    {
        [Key]
        [Required]
        [Display(Name ="Procedure ID")]
        public int ProcedureId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(40, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Tag Result")]
        public bool TagResult { get; set; }

        [Required]
        [Display(Name ="Title Result")]
        public bool TitleResult { get; set; }

        [Required]
        public bool IsActive { get; set; }


    }
}
