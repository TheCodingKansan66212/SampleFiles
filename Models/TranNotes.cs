using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TranNotes
    {
        [Key]
        [Required]
        public int TranNoteId { get; set; }

        [Required]
        [Display(Name = "Transaction Note Description")]
        public string TranNoteDescription { get; set; }

        [Display(Name = "Created By")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string CreatedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
