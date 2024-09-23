using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace Blog.Models
{
    public class AplicationUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //relacionado ao Post
        public List<Post> Posts { get; set; }
    }  
}
