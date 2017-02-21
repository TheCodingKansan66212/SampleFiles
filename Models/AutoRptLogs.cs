using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class AutoRptLogs
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }

        [Display(Name= "Entry")]
        public string Entry { get; set; }
    }
}
