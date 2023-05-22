using EventsWebsite.Models;
using System;

namespace EventsWebsite.Models
{
    public class Matches
    {
        public int? Id { get; set; }

        public int? UserId1 { get; set; }
        public int? UserId2 { get; set; }
        public DateTime CreatedAt { get; set; }

        public ApplicationUser User { get; set; } = null!;
    }
}
