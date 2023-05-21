using EventsWebsites.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebsite.Models
{
    public class Options : IdentityUser
    {
        public int? Id { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}
