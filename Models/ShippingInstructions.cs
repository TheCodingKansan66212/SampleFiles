using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class ShippingInstruction
    {
        [Key]
        [Required]
        public int ShippingInstructionId { get; set; }

        [Display(Name ="FedEx ID")]
        public Nullable<int> FedExId { get; set; }

        [Display(Name ="Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
