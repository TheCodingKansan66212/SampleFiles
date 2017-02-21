using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class CourierDeliveries
    {
        [Key]
        [Required]
       public int CourierDeliveryId { get; set; }

        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }

        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Display(Name = "Exported")]
        public int Exported { get; set; }

        [Display(Name = "Origin Attn")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginAttn { get; set; }

        [Display(Name = "Origin Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginName { get; set; }

        [Display(Name = "Origin Address 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginAddress1 { get; set; }

        [Display(Name = "Origin Address 2")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginAddress2 { get; set; }

        [Display(Name = "Origin City")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginCity { get; set; }

        [Display(Name = "Origin State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginState { get; set; }

        [Display(Name = "Origin Zip")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginZip { get; set; }

        [Display(Name = "Origin Phone Number")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OriginPhone { get; set; }

        [Display(Name = "Destination Attn")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationAttn { get; set; }

        [Display(Name = "Destination Name")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationName { get; set; }

        [Display(Name = "Destination Address 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationAddress1 { get; set; }

        [Display(Name = "Destination Address 2")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationAddress2 { get; set; }

        [Display(Name = "Destination City")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationCity { get; set; }

        [Display(Name = "Destination State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationState { get; set; }

        [Display(Name = "Destination Zip Code")]
        [StringLength(26, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationZip { get; set; }

        [Display(Name = "Destination Phone")]
        [StringLength(26, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationPhone { get; set; }

        [Display(Name = "Carrier")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Carrier { get; set; }

        [Display(Name = "Billing")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Billing { get; set; }

        [Display(Name = "Billing Account Number")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingAccountNumber { get; set; }

        [Display(Name = "Service Type")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ServiceType { get; set; }

        [Display(Name = "Package Type")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string PackageType { get; set; }

        [Display(Name = "Airway Bill Number")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AirwayBillNumber { get; set; }

        [Display(Name ="Reference ID")]
        public int ReferenceId { get; set; }

        [Display(Name = "Reference Type")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ReferenceType { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ShippingDate { get; set; }

        [Display(Name = "Weight")]
        public float Weight { get; set; }

        [Display(Name = "Username")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string UserName { get; set; }

        [Display(Name = "TransactionRequirementId")]
        public int TransactionRequirementId { get; set; }

        [Display(Name = "Checkout ID")]
        public int CheckoutId { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? LastUpdated { get; set; }

        [Required]
        [Display(Name = "Deleted AWB")]
        public bool DeletedAWB { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? DeletedOn { get; set; }

        [Display(Name = "FromFrom")]
        public string FromFrom { get; set; }

      
    }
}
