using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Screen
    {
        [Key]
        [Required]
        public int ScreenId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(35, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Key]
        [Display(Name ="Sequence")]
        public int Seq { get; set; }

        [Display(Name ="Report ID")]
        public Nullable<int> ReportID { get; set; }

        [Display(Name ="Menu Caption")]
        [StringLength(35, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string MenuCaption { get; set; }


    }
}
