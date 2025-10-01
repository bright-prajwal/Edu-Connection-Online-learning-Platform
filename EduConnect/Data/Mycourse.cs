using System.ComponentModel.DataAnnotations;
namespace EduConnect.Data
{
    public class Mycourse
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }


        public string Email { get; set; }


        public string coursename { get; set; }


    }
}
