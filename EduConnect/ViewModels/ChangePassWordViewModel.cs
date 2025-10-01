using System.ComponentModel.DataAnnotations;

namespace EduConnect.ViewModels
{
        public class ChangePassWordViewModel
        {
            [Required(ErrorMessage = "Email Is Required. ")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password Is Required. ")]
            [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and max {1} Character")]
            [DataType(DataType.Password)]
            [Display(Name = "New PassWord")]
            [Compare("ConfirmNewPassword", ErrorMessage = "PassWord Does not Mach")]
            public string NewPassword { get; set; }


            [Required(ErrorMessage = "Confirm Password Is Required. ")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm New PassWord")]
            public string ConfirmNewPassword { get; set; }


        }
}
