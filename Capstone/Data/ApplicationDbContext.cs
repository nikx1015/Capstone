using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Capstone.Models.Game> Game { get; set; }
        public DbSet<Capstone.Models.Tag> Tag { get; set; }
        public DbSet<Capstone.Models.UserList> UserList{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
        // Create a new user for Identity Framework
        ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create two games
            modelBuilder.Entity<Game>().HasData(
                new Game()
                {
                    GameId = 1,
                    Title = "The Legend of Zelda: Ocarina of Time",
                    Genre = "action-adventure",
                    Description = "The player plays as a character named Link in the land of Hyrule. The player is on a quest to stop Ganondorf from obtaining the triforce, a sacred relic. Link travels through time and completes dungeons to awaken the sages who can seal away the evil.",
                    EsrbRating = "E",
                    Platform = "Nintendo",
                    NumberOfPlayers = "Single player",
                    //ReleaseDate = 1123-19-90
                    HavePlayed = false,
                    UserId = user.Id


                },
                new Game()
                {
                    GameId = 2,
                    Title = "Final Fantasy X",
                    Genre = "RPG",
                    Description = "The player plays as Tidus who ends up in a place called Spira after his home is destroyed by a monster known as Sin. There are 7 possible characters in your group that you may switch between, all with different skills and purposes.",
                    EsrbRating = "T",
                    Platform = "Playstation, Xbox",
                    NumberOfPlayers = "Single Player",
                    //ReleaseDate = ,
                    HavePlayed = false,
                    UserId = user.Id
                }
            );

            // Create two tags
            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    TagId = 1,
                    UserId = user.Id,
                    Title = "RPG"
                },
                new Tag()
                {
                    TagId = 2,
                    UserId = user.Id,
                    Title = "Adventure"
                }
            );
        }
    }
}
