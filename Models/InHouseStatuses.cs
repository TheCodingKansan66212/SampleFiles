using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class InHouseStatuses
    {
        [Required]
        [Key]
        public int InHouseStatusId { get; set; }


    }
}
