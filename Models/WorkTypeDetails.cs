using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkTypeDetails
    {
        [Key]
        [Required]
        public int WorkTypeDetailId { get; set; }

        [Required]
        [Display(Name = "Record Type")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string RecordType { get; set; }

        [Display(Name = "Record ID")]
        public int RecordId { get; set; }

        [Display(Name = "Entity Type")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit {0}.")]
        public int EntityType { get; set; }

        [Display(Name ="Number of Copies")]
        public int NumCopy { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float? Cost { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float? Fee { get; set; }

        [Display(Name = "Sequence")]
        public int Seq { get; set; }

        [Display(Name ="Entity Value")]
        public int EntityValue { get; set; }

        [Display(Name ="Days To Process")]
        public int DaysToProcess { get; set; }
    }
}
