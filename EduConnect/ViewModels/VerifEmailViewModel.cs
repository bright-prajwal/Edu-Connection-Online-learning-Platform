using System.ComponentModel.DataAnnotations;

namespace EduConnect.ViewModels
{
    public class VerifEmailViewModel
    {
        [Required(ErrorMessage = "Email Is Required. ")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
