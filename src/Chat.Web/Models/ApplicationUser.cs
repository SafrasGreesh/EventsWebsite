using EventsWebsite.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public string? Password { get; set; }

        //public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Mail { get; set; }
        public string? City { get; set; }
        public string? Photo { get; set; }
        public string? Gender { get; set; }
        public string? Token { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Matches> Matches { get; set; }
        public ICollection<Options> Options { get; set; }
    }
}
