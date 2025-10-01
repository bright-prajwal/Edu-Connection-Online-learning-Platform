using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using NuGet.Packaging.Rules;
using System.ComponentModel.DataAnnotations;
namespace EduConnect.Models
{
    public class MycourseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string coursename { get; set; }
    }
}
