using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TransactionRequirement
    {
        [Key]
        [Required]
        public int TransactionRequirementId { get; set; }

        [Display(Name = "Date Recieved")]
        public Nullable<System.DateTime> DateReceived { get; set; }

        [Display(Name ="Order Sequence")]
        public Nullable<int> OrderSequence { get; set; }

        [Display(Name ="Data")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Data { get; set; }

        [Display(Name ="Attention")]
        [StringLength(80, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Attention { get; set; }

        [Display(Name ="Phone")]
        [StringLength(26, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Phone { get; set; }

        [Display(Name ="Street Address")]
        [StringLength(80, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string StreetAddress { get; set; }

        [Display(Name ="Address Line 2")]
        [StringLength(80, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AddressLine2 { get; set; }

        [Display(Name ="City ID")]
        public Nullable<int> CityId { get; set; }

        [Display(Name ="City")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string City { get; set; }

        [Display(Name ="Zip Code")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ZipCode { get; set; }
        public Nullable<int> ShipViaId { get; set;}

        [Display(Name ="Account")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Account { get; set; }

        [Display(Name ="Service Type ID")]
        public Nullable<int> ServiceTypeId { get; set; }

    }
}
