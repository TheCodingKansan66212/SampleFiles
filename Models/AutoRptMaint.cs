using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class AutoRptMaint
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Display(Name = "Schedule")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Schedule { get; set; }

        [Display(Name = "Report")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Report { get; set; }

        [Display(Name = "Parameter 1 Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param1_Name { get; set; }

        [Display(Name = "Parameter 2 Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param2_Name { get; set; }

        [Display(Name = "Parameter 3 Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param3_Name { get; set; }

        [Display(Name = "Parameter 4 Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param4_Name { get; set; }

        [Display(Name = "Parameter 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param1 { get; set; }

        [Display(Name = "Parameter 2")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param2 { get; set; }

        [Display(Name = "Parameter 3")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param3 { get; set; }

        [Display(Name = "Parameter 4")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Param4 { get; set; }




    }
}
