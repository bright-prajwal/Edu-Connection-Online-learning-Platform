using System.ComponentModel.DataAnnotations;

namespace EduConnect.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required. ")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required. ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " is required. ")]
        [Display(Name = "Remember me ?")]
        public bool RememberMe { get; set; }
    }
}
