using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
   public class TranForms
    {
        [Key]
        [Required]
        public int TranFormId { get; set; }

        [Display(Name = "Work Type ID")]
        public int WorkTypeId { get; set; }

        [Required]
        [Display(Name = "Printed"]
        public bool Printed { get; set; }

        [Display(Name = "Number of Copies")]
        public int NumCopy { get; set; }

        [Display(Name = "Sequence")]
        public int Seq { get; set; }

        [Required]
        [Display(Name = "To Print")]
        public bool ToPrint { get; set; }


    }
}
