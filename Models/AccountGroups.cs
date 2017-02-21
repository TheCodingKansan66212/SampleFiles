using System.ComponentModel.DataAnnotations;

namespace MTSModels.Models
{
    public class AccountGroups
    {
        [Key]
        [Required]
        public int AccountGroupId { get; set; }

        [Required]
        [Display(Name ="Account Group Name")]
        [StringLength(20, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AccountGroupName { get; set; }

        [Required]
        [Display(Name = "Account Group Description")]
        [StringLength(50, ErrorMessage = "You've exceeded the character limit of {0}.")]
        public string AccountGroupDescription { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
