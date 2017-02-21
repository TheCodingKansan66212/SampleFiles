using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CheckHistories
    {
        [Key]
        [Required]
        public int CheckHistoryId { get; set; }

        [Display(Name ="Date")]
        public Nullable<System.DateTime> Date { get; set; }

        [Display(Name ="Amount")]
        public Nullable<decimal> Amount { get; set; }

        [Display(Name ="Serial")]
        public Nullable<int> Serial { get; set; }

        [Display(Name ="Description")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Description { get; set; }

        [Display(Name ="Trancode")]
        [StringLength(90, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Trancode { get; set; }

        [Display(Name ="Bank")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Bank { get; set; }

        [Required]
        [Display(Name ="Is GL")]
        public bool IsGL { get; set; }

        [Required]
        public int Id { get; set; }


    }
}
