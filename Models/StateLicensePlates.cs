using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class StateLicensePlate
    {
        [Key]
        [Required]
        public int StateLicensePlateId { get; set; }

        [Required]
        [Display(Name ="Plate Type")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PlateType { get; set; }

        [Display(Name ="Requirement ID")]
        public Nullable<int> ReqId { get; set; }

        [Display(Name ="Requirement Value")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RequirementValue { get; set; }

        [Display(Name = "Description")]
        [StringLength(150, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="Configuration")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Configuration { get; set; }

        [Display(Name ="Note")]
        [StringLength(150, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

        [Display(Name ="Image URL")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ImageUrl { get; set; }

        [Display(Name ="Prorated")]
        public Nullable<bool> Prorated { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
