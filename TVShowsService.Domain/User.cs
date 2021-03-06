﻿using System.Collections.Generic;

namespace TVShowsService.Domain
{
    public class User : BaseDomain
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public bool IsBanned { get; set; }
        public bool IsActive { get; set; }
        public string ProfilePicture { get; set; }

        public Role Role { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}