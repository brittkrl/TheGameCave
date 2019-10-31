using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Data
{
    public class TheGameCaveContext : DbContext
    {
        public TheGameCaveContext(DbContextOptions<TheGameCaveContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .ToTable("Category")
                .HasData(
                    new Category { Id = 1, Name = "Adventure" },
                    new Category { Id = 2, Name = "Dice" },
                    new Category { Id = 3, Name = "Fantasy" },
                    new Category { Id = 4, Name = "Horror" },
                    new Category { Id = 5, Name = "Movie / TV theme" },
                    new Category { Id = 6, Name = "Party games" },
                    new Category { Id = 7, Name = "Science Fiction" },
                    new Category { Id = 8, Name = "Trivia" }
                );

            modelBuilder.Entity<Publisher>()
                .ToTable("Publisher")
                .HasData(
                    new Publisher { Id = 1, Name = "Intrafin" },
                    new Publisher { Id = 2, Name = "Fantasy Flight Games" },
                    new Publisher { Id = 3, Name = "Red Raven Games" },
                    new Publisher { Id = 4, Name = "Plaid Hat Games" },
                    new Publisher { Id = 5, Name = "Portal Games" },
                    new Publisher { Id = 6, Name = "Matagot" },
                    new Publisher { Id = 7, Name = "999 Games" },
                    new Publisher { Id = 8, Name = "Queen Games" },
                    new Publisher { Id = 9, Name = "Oink Games" },
                    new Publisher { Id = 10, Name = "Greater Than Games" },
                    new Publisher { Id = 11, Name = "Days of Wonder" },
                    new Publisher { Id = 12, Name = "USAopoly" },
                    new Publisher { Id = 13, Name = "Upper Deck Entertainment" },
                    new Publisher { Id = 14, Name = "White Goblin Games" },
                    new Publisher { Id = 15, Name = "The Oatmeal" },
                    new Publisher { Id = 16, Name = "Libellud" },
                    new Publisher { Id = 17, Name = "Stonemaier Games" },
                    new Publisher { Id = 18, Name = "Space Cowboys" },
                    new Publisher { Id = 19, Name = "Tactic" }
                );

            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasData(new 
                {
                    Id = 1,
                    Name = "Mansions of Madness: Second Edition",
                    Price = 89.95M,
                    CategoryId = 4,
                    ProductType = ProductType.BoardGame,
                    Description = "Mansions of Madness: Second Edition is a fully cooperative, app-driven board game of horror and mystery for one to five players that takes place in the same universe as Eldritch Horror and Elder Sign. Let the immersive app guide you through the veiled streets of Innsmouth and the haunted corridors of Arkham's cursed mansions as you search for answers and respite. Eight brave investigators stand ready to confront four scenarios of fear and mystery, collecting weapons, tools, and information, solving complex puzzles, and fighting monsters, insanity, and death. Open the door and step inside these hair-raising Mansions of Madness: Second Edition. It will take more than just survival to conquer the evils terrorizing this town.",
                    PlayingTime = "120-180",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "mansionsofmadness2.jpg"
                });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
