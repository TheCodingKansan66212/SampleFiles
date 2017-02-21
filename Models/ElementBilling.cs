using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class ElementBilling
    {
        [Display(Name = "SupplierId")]
        public int SupplierId { get; set; }

        [Display(Name = "Work Order ID")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string WorkOrderId { get; set; }

        [Display(Name = "Supplier Reference Number")]
        public int SupplierReferenceNumber { get; set; }

        [Display(Name = "Billing Code")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string BillingCode { get; set; }

        [Display(Name = "Multiple Billing Codes")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string MultipleBillingCodes { get; set; }

        [Display(Name = "WRT ID")]
        public int WRT_ID { get; set; }

        [Display(Name = "DAN")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DAN { get; set; }

        [Display(Name = "CliNo")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string CliNo { get; set; }

        [Display(Name = "UnitNo")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string UnitNo { get; set; }

        [Display(Name = "VIN")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string VIN { get; set; }

        [Display(Name = "Tag Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string TagNumber { get; set; }

        [Display(Name = "Tag State")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string TagState { get; set; }

        [Display(Name = "Registration Expires")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RegExpires { get; set; }

        [Display(Name = "Tag Mail Date")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string TagMailDate { get; set; }

        [Display(Name = "Tag Mail Service")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string TagMailService { get; set; }

        [Display(Name = "Tag Mail Tracking Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string TagMailTrackingNumber { get; set; }

        [Display(Name = "REG")]
        public float REG { get; set; }

        [Display(Name = "STTL")]
        public float STTL { get; set; }

        [Display(Name = "TLRN")]
        public float TLRN { get; set; }

        [Display(Name = "TXOT")]
        public float TXOT { get; set; }

        [Display(Name = "TLRR")]
        public float TLRR { get; set; }

        [Display(Name = "REGD")]
        public float REGD { get; set; }

        [Display(Name = "TEMT")]
        public float TEMT { get; set; }

        [Display(Name = "OWNC")]
        public float OWNC { get; set; }

        [Display(Name = "DTTC")]
        public float DTTC { get; set; }

        [Display(Name = "TTLC")]
        public float TTLC { get; set; }

        [Display(Name = "RPLT")]
        public float RPLT { get; set; }

        [Display(Name = "REGC")]
        public float REGC { get; set; }

        [Display(Name = "READ")]
        public float READ { get; set; }

        [Display(Name = "NMCH")]
        public float NMCH { get; set; }

        [Display(Name = "TLRB")]
        public float TLRB { get; set; }

        [Display(Name = "ATRG")]
        public float ATRG { get; set; }

        [Display(Name = "PLSH")]
        public float PLSH { get; set; }

        [Display(Name = "NORG")]
        public float NORG { get; set; }

        [Display(Name = "TTLR")]
        public float TTLR { get; set; }

        [Display(Name = "REDU")]
        public float REDU { get; set; }

        [Display(Name = "TTLB")]
        public float TTLB { get; set; }

        [Display(Name = "EXPM")]
        public float EXPLM { get; set; }

        [Display(Name = "TLRG")]
        public float TLRG { get; set; }

        [Display(Name = "TTRR")]
        public float TTRR { get; set; ]

         [Display(Name = "REGT")]
         public float REGT { get; set; }

        [Display(Name = "TTLN")]
        public float TTLN { get; set; }

        [Display(Name = "MSOT")]
        public float MSOT { get; set; }






    }
}
