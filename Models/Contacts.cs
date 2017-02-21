using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Contacts
    {
        [Key]
        [Required]
        public int ContactId { get; set; }


        [Required]
        [Display(Name = "Name")]
        [StringLength(40, ErrorMessage = "You've exceeded the character limit of {0}.")]
       public string Name { get; set; }

        [Display(Name = "Phone")]
        [StringLength(26, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Phone { get; set; }

        [Display(Name = "Extension")]
        [StringLength(16, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Ext { get; set; }

        [Display(Name = "Fax")]
        [StringLength(26, ErrorMessage = "You've exceeded the character limit of {0}.")]      
        public string Fax { get; set; }
        
        [Display(Name ="Title")]   
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Title { get; set; }

        [Display(Name = "Email")]
        [StringLength(60, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? BirthDate { get; set; }

        [Required]
        [Display(Name = "Is Web Admin")]
        public bool IsWebAdmin { get; set; }

        [Required]
        [Display(Name = "Default Contact")]
        public bool DefaultContact { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool IsActive { get; set; }


      




    }
}
