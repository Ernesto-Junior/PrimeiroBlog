using System.Globalization;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }  
        //relacionado ao AplicationUser
        public string? AplicationUserId { get; set; }
        public AplicationUser? AplicationUser { get; set; }
        public DateTime? PostCreat { get; set; } = DateTime.Now;

        public string? Description { get; set; }    
        public string? Slug { get; set; }  
    }
}
