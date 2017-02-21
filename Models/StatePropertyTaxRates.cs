using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MTSModels.Models
{
    public class StatePropertyTaxRate
    {
        [Key]
        [Required]
        public int StatePropertyTaxRateId { get; set; }

        [Display(Name = "City ID")]
        public Nullable<int> CityId { get; set; }

        [Required]
        [Display(Name ="City")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string City { get; set; }

        [Display(Name ="State Rate")]
        public Nullable<double> StateRate { get; set; }

        [Display(Name ="Municipal Rate")]
        public Nullable<double> MunicipalRate { get; set; }

        [Display(Name ="County Rate")]
        public Nullable<double> CountyRate { get; set; }

        [Display(Name ="School District Rate")]
        public Nullable<double> SchoolDistrictRate { get; set; }

        [Required]
        [Display(Name ="Total Rate")]
        public double TotalRate { get; set; }

        [Display(Name ="Special Notes")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string SpecialNotes { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}
