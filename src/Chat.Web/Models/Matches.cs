using EventsWebsite.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace EventsWebsites.Models
{
    public class Matches : IdentityUser
    {
        public int? Id { get; set; }

        public int? UserId1 { get; set; }
        public int? UserId2 { get; set; }
        public DateTime CreatedAt { get; set; }

        public ApplicationUser User { get; set; } = null!;
    }
}
