using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class WorkStation
    {
        [Key]
        [Required]
        public int WorkStationId { get; set; }

        [Display(Name="Name")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Name { get; set; }

        [Display(Name="Scanner")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Scanner { get; set; }


        [Display(Name="DirDial")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DirDial { get; set; }

        [Display(Name="Dropout A")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DropOutA { get; set; }

        [Display(Name="Dropout B")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DropOutB { get; set; }

        [Display(Name="Dropout C")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string DropOutC { get; set; }

        [Display(Name="Printer")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Printer { get; set; }

        [Display(Name="Fedex")]
        [StringLength(255, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string Fedex { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> UPSDate { get; set; }

      
    }
}
