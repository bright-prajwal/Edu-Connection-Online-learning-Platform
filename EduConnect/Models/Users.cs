using Microsoft.AspNetCore.Identity;

namespace EduConnect.Models
{
    public class Users : IdentityUser
    {
        //public int ID { get; set; }
        public string FullName { get; set; }
        

        

    }
}
