using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class MacroDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sequence")]
        public int Seq { get; set; }

        [Required]
        [Display(Name ="Command Text")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CommandText { get; set; }

        [Display(Name ="Argument 1")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument1 { get; set; }

        [Display(Name = "Argument 2")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument2 { get; set; }

        [Display(Name = "Argument 3")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument3 { get; set; }

        [Display(Name = "Argument 4")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument4 { get; set; }

        [Display(Name = "Argument 5")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument5 { get; set; }

        [Display(Name = "Argument 6")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument6 { get; set; }

        [Display(Name = "Argument 7")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument7 { get; set; }

        [Display(Name = "Argument 8")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument8 { get; set; }

        [Display(Name = "Argument 9")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument9 { get; set; }

        [Display(Name = "Argument 10")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument10 { get; set; }

        [Display(Name = "Argument 11")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument11 { get; set; }

        [Display(Name = "Argument 12")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Argument12 { get; set; }


    }
}

}
