using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Departments
    {
        [Key]
        [Required]
        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DepartmentName { get; set; }

        [Display(Name = "Description")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
