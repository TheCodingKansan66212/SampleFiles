using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class ScanList
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name="Field 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Field1 { get; set; }

        [Display(Name="Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name { get; set; }

    }
}
