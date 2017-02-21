using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Employees
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name { get; set; }

        [Display(Name = "Log-In Name")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Login_Name { get; set; }

        [Display(Name = "User Password")]
        [StringLength(8, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string User_Password { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? Hire_Date { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? Terminate_Date { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? BirthDate { get; set; }

        [Display(Name = "Gender")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Gender { get; set; }

        [Display(Name = "Social Security Number")]
        [StringLength(11, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string SSN { get; set; }

        [Display(Name = "National ID Number")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string NationalIDNumber { get; set; }

        [Display(Name = "Medical Contact")]
        [StringLength(40, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Med_Contact { get; set; }

        [Display(Name = "Medical Contact Phone Number")]
        [StringLength(14, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Med_Phone { get; set; }

        [Display(Name = "Gets Status Reports")]
        public bool Gets_Status_Rpt { get; set; }

        [Display(Name = "Show Quote")]
        public bool Show_Quote { get; set; }


        [Display(Name = "Address Line 1")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Addr1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Addr2 { get; set; }

        [Display(Name = "City and State")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string City_State { get; set; }

        [Display(Name = "Home Phone Number")]
        [StringLength(14, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Home_Phone { get; set; }

        [Display(Name = "Work Phone Number")]
        [StringLength(14, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Work_Phone { get; set; }

        [Display(Name = "Work Phone Extension")]
        [StringLength(3, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Work_Phone_Extension { get; set; }

        [Display(Name = "Alternate Phone Number")]
        [StringLength(14, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Alt_Phone { get; set; }

        [Display(Name = "E-mail Address")]
        [StringLength(60, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string EMail { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Display(Name = "Vacation Hours")]
        public int Vacation_hours { get; set; }

        [Display(Name = "Sick Hours")]
        public int Sick_hours { get; set; }

        [Display(Name= "Hourly")]
        public bool Hourly { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? ModifiedDate { get; set; }

    }
}
