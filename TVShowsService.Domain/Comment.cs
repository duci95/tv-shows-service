using System;
using System.Collections.Generic;
using System.Text;

namespace TVShowsService.Domain
{
    public class Comment : BaseDomain
    {
        public string CommentText  { get; set; }
        public User User { get; set; }
        public Show Show { get; set; }
    }
}