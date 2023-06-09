﻿using EventsWebsite.Data;
using EventsWebsite.Models;
using EventsWebsites.Entity;
using EventsWebsites.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EventsWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
            }
            using (var context = new ApplicationDbContext())
            {

                context.Database.EnsureCreated();

                //context.ApplicationUser.RemoveRange(context.ApplicationUser);
                //context.ApplicationUser.Add(new ApplicationUser { Id= 1, UserName = "1231", EmailConfirmed = true, PhoneNumberConfirmed = true, TwoFactorEnabled = true, LockoutEnabled = true, AccessFailedCount = 1 });
                
                //context.Users.Add(new Users
                //{
                //    Password = "2",
                //    Name = "Лада",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Ижевск",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "W",
                //    Id = 2,
                //    Mail = "lada@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "3",
                //    Name = "Анна",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "M",
                //    Id = 3,
                //    Mail = "anna@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "4",
                //    Name = "Ваня",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "M",
                //    Id = 4,
                //    Mail = "vanya@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "4",
                //    Name = "Аля",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "W",
                //    Id = 5,
                //    Mail = "aly@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "4",
                //    Name = "Саша",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "W",
                //    Id = 6,
                //    Mail = "sasha@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "4",
                //    Name = "Coня",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "W",
                //    Id = 7,
                //    Mail = "sonya@mail.ru",
                //    Photo = ""
                //});
                //context.Users.Add(new Users
                //{
                //    Password = "4",
                //    Name = "Регина",
                //    BirthDate = new DateTime(2000, 12, 1),
                //    City = "Хохряки",
                //    Description = "Люблю нихуя не делать",
                //    Gender = "W",
                //    Id = 8,
                //    Mail = "regina@mail.ru",
                //    Photo = ""
                //});
                context.SaveChanges();
            }
        host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
