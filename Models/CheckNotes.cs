
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CheckNotes
    {
        [Key]
        [Required]
        public int CheckNoteId { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name = "Created By")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CreatedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
