using System.Collections.Generic;

namespace TVShowsService.Domain
{
    public class Show : BaseDomain
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string About { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}