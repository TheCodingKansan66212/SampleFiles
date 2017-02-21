using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Logs
    {
        [Required]
        [Key]
        public int LogEntryID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? Date { get; set; }

        [Required]
        [Display(Name = "Application")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Application { get; set; }

        [Required]
        [Display(Name = "LogLevel")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string LogLevel { get; set; }

        [Display(Name = "Scope")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Scope { get; set; }

        [Required]
        [Display(Name = "Thread ID")]
        public int ThreadId { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }

        [Display(Name = "Message")]
        public string Exception { get; set; }

        [Required]
        [Display(Name = "Process Owner")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ProcessOwner { get; set; }







    }
}
