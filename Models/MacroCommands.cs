using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class MacroCommands
    {
        [Required]
        [Key]
        public int MacroCommand_id { get; set; }

        [Required]
        [Display(Name = "Command Text")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string command_text { get; set; }

        [Required]
        [Display(Name = "Parameter Count")]
        public int param_count { get; set; }

        [Display(Name = "Requirement Parameter Count")]
        public int req_param_count { get; set; }

        [Display(Name = "Parameter 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param1 { get; set; }

        [Display(Name = "Parameter 2")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param2 { get; set; }

        [Display(Name = "Parameter 3")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param3 { get; set; }

        [Display(Name = "Parameter 4")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param4 { get; set; }

        [Display(Name = "Parameter 5")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param5 { get; set; }

        [Display(Name = "Parameter 6")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param6 { get; set; }

        [Display(Name = "Parameter 7")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param7 { get; set; }

        [Display(Name = "Parameter 8")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param8 { get; set; }

        [Display(Name = "Parameter 9")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param9 { get; set; }

        [Display(Name = "Parameter 10")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param10 { get; set; }

        [Display(Name = "Parameter 11")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param11 { get; set; }

        [Display(Name = "Parameter 12")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string param12 { get; set; }
    }
}
