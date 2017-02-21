using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class RegistrationCity
    {
        [Key]
        [Required]
        [Display(Name ="Registration City ID")]
        public int RegistrationCityId { get; set; }

        [Required]
        [Display(Name ="City Name")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CityName { get; set; }


        [Display(Name="City Abbreviation")]
        [StringLength(6, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CityAbbreviation { get; set; }

    }

}
