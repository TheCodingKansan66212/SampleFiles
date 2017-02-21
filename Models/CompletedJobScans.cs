using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CompletedJobScans
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Filepath")]
        [StringLength(300, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Filepath { get; set; }

        [Required]
        [Display(Name = "Is Published")]
        public bool IsPublished { get; set; }

        [Display(Name = "Is Complete")]
        public bool IsComplete { get; set; }

        [Display(Name = "Transaction Procedure ID")]
        public int TranProdId { get; set; }

        [Required]
        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }
    }
}
