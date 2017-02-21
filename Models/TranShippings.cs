using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class TranShipping
    {

        [Key]
        [Required]
        public int TranShippingId { get; set; }

        [Display(Name = "Outgoing Ticket Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string OutgoingTicketNum { get; set; }

        [Display(Name ="Incoming Ticket Number")]
        [StringLength(25, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string IncomingTicketNum { get; set; }

        [Required]
        public int ShipperId { get; set; }
    }

  }
