using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class EmployeeNotes
    {
        [Key]
        [Required]
        public System.Guid EmployeeNoteId { get; set; }

        [Required]
        [Display(Name = "Note")]
        [StringLength(2500, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Note { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? CreatedDate { get; set; }

        [Required]
        [Display(Name = "Created By")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ModifiedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? ModifiedDate { get; set; }



    }
}
