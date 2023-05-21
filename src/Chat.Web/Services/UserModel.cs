//using EventsWebsite.Entity;
//using Org.BouncyCastle.Crypto;
using System;

namespace EventsWebsite.Services
{
    public class UserModel
    {
        public string Password { get; set; }

        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mail { get; set; }
        public string City { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
    }
}