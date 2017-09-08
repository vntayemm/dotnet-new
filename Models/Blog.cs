
namespace gorillaspace.Models
{
    using System.Collections.Generic;
    public class Blog : TenantModel
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }

}