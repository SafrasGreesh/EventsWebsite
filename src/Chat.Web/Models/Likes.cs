using EventsWebsites.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebsites.Models
{
    public class Likes : IdentityUser
    {
        public int? Id { get; set; }

        public int? UserId { get; set; }
        public int? LikeUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Boolean Like { get; set; }
    }
}
