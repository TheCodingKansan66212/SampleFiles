using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Imports
    {
        [Key]
        [Required]
        public int ImportId { get; set; }
       
        
        [Display(Name = "Invoice Number")]
        public int InvoiceNumber { get; set; }

        [Display(Name = "Check Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CheckNumber { get; set; }

        [Display(Name = "Amount")]
        public float Amount { get; set; }


        [Display(Name = "Client Unit")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ClientUnit { get; set; }






    }
}
