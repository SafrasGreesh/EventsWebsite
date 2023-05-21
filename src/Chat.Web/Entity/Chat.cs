﻿using System;

namespace EventsWebsite.Entity
{
    public class Chat
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public Users Users { get; set; } = null!;
    }
}
