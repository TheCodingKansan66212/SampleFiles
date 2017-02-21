using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class MacroHeaders
    {
        [Required]
        [Key]
        public int MacroHeaderId { get; set; }

        [Display(Name = "Work Requirement State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string WorkReq_State { get; set; }

        [Display(Name = "Type Element ID")]
        public int TypeElementId { get; set; }

        [Display(Name = "Work Requirement ID")]
        public int WorkReq_ID { get; set; }

        [Display(Name = "County")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string County { get; set; }

        [Display(Name = "Name 1")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name1 { get; set; }

        [Display(Name = "Name 2")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name2 { get; set; }

        [Display(Name = "Address 1")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Addr1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Addr2 { get; set; }

        [Display(Name = "Zip")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Zip { get; set; }

        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string City { get; set; }

        [Display(Name = "State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string State { get; set; }

        [Display(Name = "Macro Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string MacroName { get; set; }

    }
