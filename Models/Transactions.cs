using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Transactions
    {
            [Key]
            [Required]
            public int TransactionId { get; set; }

            [Required]
            public int InvoiceNumber { get; set; }
            
        [Required]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime DateIn { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateComplete { get; set; }

        [Display(Name ="Balance")]
        public Nullable<decimal> Balance { get; set; }


            [Display(Name ="Client Unit")]
            [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string ClientUnit { get; set; }

            [Display(Name ="VIN")]
            [StringLength(17, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string VIN { get; set; }

            public string VINLast6 { get; set; }

            [Display(Name ="Vehicle Year")]
            [StringLength(6, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string VehicleYear { get; set; }

            [Display(Name ="Make")]
            [StringLength(20, ErrorMessage = "You've exceeded the character limit {0}.")]
            public string Make { get; set; }

            [Display(Name ="Model")]
            [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string Model { get; set; }

            [Display(Name ="Name 1")]
            [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string Name1 { get; set; }

            [Display(Name ="Name 2")]
            [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string Name2 { get; set; }

            [Display(Name ="Address")]
            [StringLength(80, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string Address { get; set; }

            [Display(Name ="Address 2")]
            [StringLength(80, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string AddressLine2 { get; set; }

            [Display(Name ="PO Number")]
            [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string PONumber { get; set; }

            [Display(Name ="City Name")]
            [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string CityName { get; set; }

            [Display(Name = "Zip Code")]
            [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
            public string ZipCode { get; set; }

            [Display(Name = "Emailed")]
            public Nullable<bool> Emailed { get; set; }
        }
}
