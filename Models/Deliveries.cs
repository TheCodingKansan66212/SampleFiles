using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Deliveries
    {
        [Required]
        [Key]
        public int ID { get; set; }

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
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
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
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DestinationZip { get; set; }

        [Display(Name = "Destination Phone")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
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

        [Display(Name = "Reference ID")]
        public int ReferenceId { get; set; }

        [Display(Name = "Reference Type")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ReferenceType { get; set; }

        [Display(Name = "Flag 1")]
        public int Flag1 { get; set; }

        [Display(Name = "Flag 2")]
        public int Flag2 { get; set; }

        [Display(Name = "Fuel Charges")]
        public decimal Fuel_Charges { get; set; }

        [Display(Name = "Other Charges")]
        public decimal Other_Charges { get; set; }

        [Display(Name = "Total Shipping Charges")]
        public decimal Total_Shipping_Charges { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? Shipping_Date { get; set; }

        [Display(Name = "Weight")]
        public float Weight { get; set; }

        [Display(Name = "Username")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string UserName { get; set; }

        [Display(Name = "Base Charge")]
        public float Base_Charge { get; set; }

        [Display(Name = "TransactionRequirementId")]
        public int Tran_Req_Id { get; set; }

        [Display(Name = "Check Number")]
        public int Check_Num { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? Last_Updated { get; set; }

        [Required]
        [Display(Name = "Deleted AWB")]
        public bool DeletedAWB { get; set; }

        [Display(Name ="From From")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string From_From { get; set; }







    }
}
