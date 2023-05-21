﻿using System;

namespace EventsWebsite.Entity
{
    public class Events
    {

        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Users Users { get; set; } = null!;
    }
}
