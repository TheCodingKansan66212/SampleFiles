using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkStationInventory
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name ="WorkStation ID")]
        public Nullable<int> WorkStationId { get; set; }

        [Required]
        [Display(Name ="Manufacturer")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name ="Model")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Model { get; set; }

        [Required]
        [Display(Name ="Serial")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string Serial { get; set; }

        [Required]
        [Display(Name ="Date Purchased")]
        public Nullable<System.DateTime> DatePurchased { get; set; }

        [Display(Name ="Purchase Price")]
        public Nullable<decimal> PurchasePrice { get; set; }

        [Display(Name ="Purchase From")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string PurchaseFrom { get; set; }

        [Display(Name ="Date Disposed")]
        public Nullable<System.DateTime> DateDisposed { get; set; }

        [Display(Name ="Sale Price")]
        public Nullable<decimal> SalePrice { get; set; }

        [Display(Name ="Sold To")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit {0}.")]
        public string SoldTo { get; set; }

    }
}
