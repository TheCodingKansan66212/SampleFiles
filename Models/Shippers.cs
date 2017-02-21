using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Shipper
    {
        [Key]
        [Required]
        public int ShipperId { get; set; }

        [Required]
        [Display(Name ="Shipper Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ShipperName { get; set; }

        [Required]
        [Display(Name ="Shipper Account Number")]
        public decimal ShipperAccountNumber { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
