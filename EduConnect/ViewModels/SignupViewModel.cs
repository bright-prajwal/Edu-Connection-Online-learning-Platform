using System.ComponentModel.DataAnnotations;

namespace EduConnect.ViewModels
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Name is required. ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required. ")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required. ")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and max {1} Character")]
        [DataType(DataType.Password)]
        //[Display(Name ="New Password")]
        [Compare("ConfirmPassword", ErrorMessage = "PassWord Does not Mach")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm password is required. ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        //[Compare("Password", ErrorMessage = "PassWord Does not Mach")]
        public string ConfirmPassword { get; set; }
    }
}
