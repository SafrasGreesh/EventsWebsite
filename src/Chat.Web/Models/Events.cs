﻿using Microsoft.AspNetCore.Identity;
using System;

namespace EventsWebsites.Models
{
    public class Events : IdentityUser
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}
