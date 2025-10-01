using Microsoft.EntityFrameworkCore;
//using NuGet.Packaging.Rules;
using System.ComponentModel.DataAnnotations;

namespace EduConnect.Models
{
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the Title yor Course ")]
        public string CoursesName { get; set; }

    
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the Instructor")]
        public string Instructor { get; set; }

        [Required]
        public string Categories { get; set; }

        [StringLength(500, MinimumLength = 50)]
        [Required]
        public string Description { get; set; }

        

        [Display(Name = "Choose the Cover Photo of Your Course ")]
        [Required]
        public IFormFile CoverPhoto { get; set; }

        //public string Coverphotourl { get; set; }

        //public UrlAttribute CoverImageUrl { get; set; }

        [Required]
        public string Module1 { get; set; }


        [Required]
        public string Module2 { get; set; }

        [Required]
        public string Module3 { get; set; }

        [Required]
        public string Module4 { get; set; }


        [Required]
        public string Module5 { get; set; }

        [Required]
        public string Module6 { get; set; }

        [Required]
        public string UrlAttribute { get; set; }

        [Required]
        public string Url2 { get; set; }

        [Required]
        public string Url3 { get; set; }
        [Required]
        public string Url4 { get; set; }
        [Required]
        public string Url5 { get; set; }
        [Required]
        public string Url6 { get; set; }
        [Required]
        public string Url7 { get; set; }




    }
}