using EventsWebsite.Models;
using EventsWebsites.Models;
using System.Collections.Generic;

namespace EventsWebsites.Entity
{
    internal class AppUsers : ApplicationUser
    {
        public override string  UserName { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Matches> Matches { get; set; }
        public ICollection<Options> Options { get; set; }
    }
}