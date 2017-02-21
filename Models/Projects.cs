using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Project
    {
        [Key]
        [Required]
        [Display(Name ="Project ID")]
         public int ProjectId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(100, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Description { get; set; }

        [Display(Name ="WRT State")]
        [StringLength(2, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Wrt_state { get; set; }

        [Display(Name ="WRT Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Wrt_descr { get; set; }

        [Display(Name ="Note")]
        public string Note { get; set; }

        [Display(Name ="Date Complete")]
        public Nullable<System.DateTime> Date_complete { get; set; }

        [Display(Name ="Expiration Date")]
         public Nullable<System.DateTime> Exp_date { get; set; }

        [Display(Name ="Duplicate VIN Source Check")]
        public Nullable<int> Dup_VIN_Source_Check { get; set; }

        [Display(Name ="Duplicate VIN Database Check")]
        public Nullable<int> Dup_VIN_DB_Check { get; set; }

        [Display(Name ="Valid Insurance")]
        public Nullable<int> Valid_Insure { get; set; }

        [Display(Name ="Note")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Filename { get; set; }

        [Display(Name ="Contact ID")]
        public Nullable<int> Contact_id { get; set; }

        [Display(Name ="Metro Fee")]
        public Nullable<decimal> Metro_Fee { get; set; }

        [Display(Name ="WRT ID")]
        public Nullable<int> Wrt_id { get; set; }

        [Display(Name="Date Added")]
        public Nullable<System.DateTime> DateAdded { get; set; }

        [Display(Name ="Rows In File")]
        public Nullable<int> RowsInFile { get; set; }

        [Display(Name ="Rows Imported")]
        public Nullable<int> RowsImported { get; set; }

        [Display(Name ="Rows Imported")]
        public Nullable<System.DateTime> Target_date { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
