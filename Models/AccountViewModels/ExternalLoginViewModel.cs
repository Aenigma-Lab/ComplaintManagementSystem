using System.ComponentModel.DataAnnotations;

namespace ComplaintMngSys.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
