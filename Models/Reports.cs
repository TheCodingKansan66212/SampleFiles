using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class Report
    {
        [Key]
        [Required]
        [Display(Name ="Report ID")]
        public int ReportId { get; set; }

        [Required]
        [Display(Name ="Screen ID")]
        public int Screen_Id { get; set; }

        [Required]
        [Display(Name ="Filename")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Filename { get; set; }

        [Display(Name ="Default Destination")]
        [StringLength(1, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Default_Dest { get; set; }

        [Display(Name ="Default Printer")]
        [StringLength(30, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Default_Printer { get; set; }

        [Required]
        [Display(Name="Show Start Date")]
        public bool Show_Start_Date { get; set; }

        [Required]
        [Display(Name ="Show End Date")]
        public bool Show_End_Date { get; set; }

        [Required]
        [Display(Name ="Show List 1")]
        public bool Show_List1 { get; set; }

        [Display(Name ="List 1 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string List1_Caption { get; set; }

        [Display(Name ="List 1")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string List1 { get; set; }

        [Required]
        [Display(Name ="Show List 2")]
        public bool Show_List2 { get; set; }

        [Display(Name ="List 2 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string List2_Caption { get; set; }

        [Display(Name ="List 2")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string List2 { get; set; }

        [Required]
        [Display(Name ="Show Lookup 1")]
        public bool Show_Lookup1 { get; set; }

        [Display(Name ="Lookup 1 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Lookup1_Caption { get; set; }

        [Display(Name ="Lookup 1 SQL")]
        [StringLength(250, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Lookup1_SQL { get; set; }

        [Required ]
        [Display(Name ="Show Lookup 2")]
        public bool Show_Lookup2 { get; set; }

        [Display(Name ="Lookup 2 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Lookup2_Caption { get; set; }

        [Display(Name ="Lookup 2 SQL")]
        [StringLength(250, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Lookup2_SQL { get; set; }

        [Required]
        [Display(Name ="Show Lookup 3")]
        public bool Show_Lookup3 { get; set; }

        [Display(Name ="Lookup 3 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]

        public string Lookup3_Caption { get; set; }

        [Display(Name ="Lookup 3 SQL")]
        [StringLength(250, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Lookup3_SQL { get; set; }

        [Required]
        [Display(Name ="Show Sort 1")]
        public bool Show_Sort1 { get; set; }

        [Display(Name ="Sort 1 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort1_Caption { get; set; }

        [Display(Name ="Sort 1 Section")]
        [StringLength(4, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort1_Section { get; set; }

        [Required]
        [Display(Name = "Show Sort 2")]
        public bool Show_Sort2 { get; set; }

        [Display(Name ="Sort 2 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort2_Caption { get; set; }

        [Display(Name ="Sort 2 Section")]
        [StringLength(4, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort2_Section { get; set; }

        [Required]
        [Display(Name ="Show Sort 3")]
        public bool Show_Sort3 { get; set; }

        [Display(Name ="Sort 3 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort3_Caption { get; set; }

        [Display(Name ="Sort 3 Section")]
        [StringLength(4, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort3_Section { get; set; }

        [Required]
        [Display(Name="Show Sort 4")]
        public bool Show_Sort4 { get; set; }

        [Display(Name ="Sort 4 Caption")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort4_Caption { get; set; }

        [Display(Name ="Sort 4 Section")]
        [StringLength(4, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Sort4_Section { get; set; }

    }
}
