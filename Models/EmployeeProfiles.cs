using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class EmployeeProfiles
    {
        [Key]
        [Required]
        public int EmployeeProfileId { get; set; }

        [Display(Name = "Profile Image")]
        public byte ProfileImage { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(250, ErrorMessage = "You've exceeded the character limit of {0}." )]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
