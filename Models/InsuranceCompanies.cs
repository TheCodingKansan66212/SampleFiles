using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class InsuranceCompanies
    {
        [Required]
        [Key]
        public int InsuranceCompanyId { get; set; }

        [Display(Name = "FLEET")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string FLEET { get; set; }

        [Display(Name = "INSURER")]
        [StringLength(99, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string INSURER { get; set; }

        [Display(Name = "POLICY")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string POLICY { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? EFFDATE { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? EXPDATE { get; set; }

        [Display(Name = "STATE")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string STATE { get; set; }
    }
}
