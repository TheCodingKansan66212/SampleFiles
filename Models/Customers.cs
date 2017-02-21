using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels
{
    public class Customers
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name="Record Type")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string RecordType { get; set; }

        [Required]
        [Display(Name="Name")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name { get; set; }

        [Display(Name = "PO Box Address 1")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string POAddr1 { get; set; }

        [Display(Name = "PO Box Address Line 2")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string POAddr2 { get; set; }

        [Display(Name = "PO City")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string POCity { get; set; }

        [Display(Name = "PO State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}."]
        public string POState { get; set; }

        [Display(Name = "PO Zip")]
        [StringLength(5, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string POZip { get; set; }

        [Display(Name = "Shipping Address Line 1")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ShipAddr1 { get; set; }

        [Display(Name = "Shipping Address Line 2")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string ShipAddr2 { get; set; }

        [Display(Name = "Shipping City")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string ShipCity { get; set; }

        [Display(Name = "Shipping State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string ShipState { get; set; }

        [Display(Name = "Shipping Zip Code")]
        [StringLength(5, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string ShipZip {get; set;}

         [Display(Name = "Term ID")]
         public int TermId { get; set; }

        [Display(Name ="Account Number")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit {0}." )]
       public string AccountNumber { get; set; }

        [Display(Name = "Dealer Number ")]
        [StringLength(10, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string DealerNumber { get; set; }

        [Display(Name = "Client Unit")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit {0}. ")]
        public string ClientUnit { get; set; }

        [Display(Name = "FEIN")]
        [StringLength(15, ErrorMessage = "You've exceeded the character limit {0}. ")]
        public string FEIN { get; set; }

        [Display(Name = "Fax Schedule")]
        [StringLength(7, ErrorMessage = "You've exceeded the character limit {0}. ")]
        public string FaxSchedule { get; set; }

        [Display(Name ="Co-Lien Holder")]
        public bool COLeinHolder { get; set; }

        [Required]
        [Display(Name = "Rush Preference")]
        public bool RushPref { get; set; }

        [Required]
        [Display(Name = "On Hold")]
        public bool OnHold { get; set; }

        [Required]
        [Display(Name = "Scanned POA")]
        public bool Scanned_POA { get; set; }

        [Display(Name = "Lease")]
        public bool Lease { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Unit Requirement")]
        public bool Unit_Req { get; set; }

        [Display(Name = "Check Name")]
        [StringLength(35, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string CheckName { get; set; }

        [Display(Name = "Lease Name")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseName { get; set; }

        [Display(Name = "Lease Address Line 1")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseAddr1 { get; set; }

        [Display(Name = "Lease Address Line 2")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseAddr2 { get; set; }

        [Display(Name = "Lease City")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseCity { get; set; }

        [Display(Name = "Lease State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseState { get; set; }

        [Display(Name = "Lease Zip Code")]
        [StringLength(5, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string LeaseZip { get; set; }

        [Display(Name = "Shipping County")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string ShipCounty { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? AddDate { get; set; }

        [Display(Name = "DMV Check ID")]
        public int DMVCheckId { get; set; }

        [Display(Name = "No Blank Checks")]
        public bool NoBlankChecks { get; set; }

        [Display(Name = "One Check Per Invoice")]
        public bool OneCheckPerInvoice { get; set; }

        [Required]
        [Display(Name = "Needs Money Order")]
        public bool NeedsMoneyOrder { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public System.DateTime? SalesRepDate { get; set; }

        [Required]
        [Display(Name = "Send Tag to Requested By: ")]
        public bool SendTagToReqBy { get; set; }

        [Required]
        [Display(Name = "Separate Shipping By Contact")]
        public bool SeparateShippingByContact { get; set; }

        [Display(Name = "Shipping Notes")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string ShippingNotes { get; set; }

        [Required]
        [Display(Name = "Email Billing")]
        public bool Email_Billing { get; set; }

        [Display(Name ="Suppress Document Print")]
        public bool Suppress_Document_Print { get; set; }

        [Required]
        [Display(Name= "Maximum Invoices Per Check")]
        public int MaxInvoicesPerCheck { get; set; }

        [Display(Name = "Billing Email")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string BillingEmail { get; set; }

        [Display(Name ="Parent ID")]
        public int ParentId { get; set; }

        [Display(Name = "No Overnight For Projects")]
        public bool NoOvernightForProjects { get; set; }

        [Required]
        public bool IsActive { get; set; }
























    }

}
