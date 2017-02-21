using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CheckCategories
    {
        [Key]
        public int CheckCategoryId { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }


        [Display(Name ="Account")]
        public Nullable<decimal> Account { get; set; }
    }
}
