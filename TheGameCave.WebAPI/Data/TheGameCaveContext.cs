using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;

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
                },
                new
                {
                    Id = 2,
                    Name = "Arkham Horror: The Card Game",
                    Price = 39.95M,
                    CategoryId = 4,
                    ProductType = ProductType.CardGame,
                    Description = "Something evil stirs in Arkham, and only you can stop it. Blurring the traditional lines between roleplaying and card game experiences, Arkham Horror: The Card Game is a Living Card Game of Lovecraftian mystery, monsters, and madness!",
                    PlayingTime = "60-120",
                    NumberOfPlayers = "1-2",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "arkhamhorrorcardgame.jpg"
                },
                new 
                {
                    Id = 3,
                    Name = "Eldritch Horror",
                    Price = 59.95M,
                    CategoryId = 4,
                    ProductType = ProductType.BoardGame,
                    Description = "Eldritch Horror is a cooperative game of terror and adventure in which one to eight players take the roles of globetrotting investigators working to solve mysteries, gather clues, and protect the world from an Ancient One – that is, an elder being intent on destroying our world. Each Ancient One comes with its own unique decks of Mystery and Research cards, which draw you deeper into the lore surrounding each loathsome creature. Discover the true name of Azathoth or battle Cthulhu on the high seas.",
                    PlayingTime = "120-240",
                    NumberOfPlayers = "1-8",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "eldritchhorror.jpg"
                },
                new
                {
                    Id = 4,
                    Name = "Above and Below",
                    Price = 39.95M,
                    CategoryId = 1,
                    ProductType = ProductType.BoardGame,
                    Description = "Your last village was ransacked by barbarians. You barely had time to pick up the baby and your favorite fishing pole before they started the burning and pillaging. You wandered over a cruel desert, braved frozen peaks, and even paddled a log across a rough sea, kicking at the sharks whenever they got too close, the baby strapped tightly to your back.",
                    PlayingTime = "90",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 13,
                    Language = Language.English,
                    PublisherId = 3,
                    PhotoUrl = "aboveandbelow.jpg"
                },
                new
                {
                    Id = 5,
                    Name = "Stuffed Fables",
                    Price = 55.95M,
                    CategoryId = 1,
                    ProductType = ProductType.BoardGame,
                    Description = "Stuffed Fables is an unusual adventure game in which players take on the roles of brave stuffies seeking to save the child they love from a scheming, evil mastermind. Make daring melee attacks, leap across conveyor belts, or even steer a racing wagon down a peril-filled hill. The game delivers a thrilling narrative driven by player choices. Players explore a world of wonder and danger, unlocking curious discoveries. The chapters of Stuffed Fables explore the many milestones of a child's life, creating a memorable tale ideal for families, as well as groups of adults who haven't forgotten their childlike sense of wonder.",
                    PlayingTime = "60-90",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 4,
                    PhotoUrl = "stuffedfables.jpg"
                },
                new
                {
                    Id = 6,
                    Name = "Robinson Crusoe: Adventures on the Cursed Island",
                    Price = 36.95M,
                    CategoryId = 1,
                    ProductType = ProductType.BoardGame,
                    Description = "Robinson Crusoe: Adventures on the Cursed Island is an epic game from Portal. You will build a shelter, palisade, weapons, you will create tools like axes, knives, sacks, you will do everything you can to… to survive. You will have to find food, fight wild beasts, protect yourself from weather changes…",
                    PlayingTime = "60-120",
                    NumberOfPlayers = "1-4",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 5,
                    PhotoUrl = "robinsoncrusoe.jpg"
                },
                new
                {
                    Id = 7,
                    Name = "Sagrada",
                    Price = 29.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "Draft dice and use the tools-of-the-trade in Sagrada to carefully construct your stained glass window masterpiece.<br><br> In more detail, each player builds a stained glass window by building up a grid of dice on their player board. Each board has some restrictions on which color or shade (value) of die can be placed there. Dice of the same shade or color may never be placed next to each other. Dice are drafted in player order, with the start player rotating each round, snaking back around after the last player drafts two dice. Scoring is variable per game based on achieving various patterns and varieties of placement...as well as bonus points for dark shades of a particular hidden goal color.",
                    PlayingTime = "30-45",
                    NumberOfPlayers = "1-4",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 6,
                    PhotoUrl = "sagrada.jpg"
                },
                new
                {
                    Id = 8,
                    Name = "Clever",
                    Price = 13.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "Choose your dice well in Clever to enter them into the matching colored area, put together tricky chain-scoring opportunities, and rack up the points. The dice you don't use are as important as what you do because every die that's smaller than the chosen one can be used by the other players, keeping everyone in the game at all times.",
                    PlayingTime = "30",
                    NumberOfPlayers = "1-4",
                    MinimumAge = 8,
                    Language = Language.Dutch,
                    PublisherId = 7,
                    PhotoUrl = "mansionsofmadness2.jpg"
                },
                new
                {
                    Id = 9,
                    Name = "Escape: The Curse of the Temple",
                    Price = 43.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "Escape: The Curse of the Temple is a cooperative game in which players must escape (yes...) from a temple (yes...) which is cursed (yes...) before the temple collapses and kills one or more explorers, thereby causing everyone to lose.",
                    PlayingTime = "10",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 8,
                    PhotoUrl = "escapethecurseofthetemple.jpg"
                },
                new
                {
                    Id = 10,
                    Name = "Deep Sea Adventure",
                    Price = 9.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "A group of poor explorers hoping to get rich quickly heads out to recover treasures from some undersea ruins. They're all rivals, but their budgets force them all to share a single rented submarine. In the rented submarine, they all have to share a single tank of air, as well. If they don't get back to the sub before they run out of air, they'll drop all their treasure. Now it's time to see who can bring home the greatest riches.",
                    PlayingTime = "30",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 9,
                    PhotoUrl = "deepseaadventure.jpg"
                },
                new
                {
                    Id = 11,
                    Name = "Spirit Island",
                    Price = 79.95M,
                    CategoryId = 3,
                    ProductType = ProductType.BoardGame,
                    Description = "Spirit Island is a complex and thematic cooperative game about defending your island home from colonizing Invaders. Players are different spirits of the land, each with its own unique elemental powers. Every turn, players simultaneously choose which of their power cards to play, paying energy to do so. Using combinations of power cards that match a spirit's elemental affinities can grant free bonus effects. Faster powers take effect immediately, before the Invaders spread and ravage, but other magics are slower, requiring forethought and planning to use effectively. In the Spirit phase, spirits gain energy, and choose how / whether to Grow: to reclaim used power cards, to seek for new power, or to spread presence into new areas of the island.",
                    PlayingTime = "90-120",
                    NumberOfPlayers = "1-4",
                    MinimumAge = 13,
                    Language = Language.English,
                    PublisherId = 10,
                    PhotoUrl = "spiritisland.jpg"
                },
                new
                {
                    Id = 12,
                    Name = "Five Tribes",
                    Price = 44.95M,
                    CategoryId = 3,
                    ProductType = ProductType.BoardGame,
                    Description = "Crossing into the Land of 1001 Nights, your caravan arrives at the fabled Sultanate of Naqala. The old sultan just died and control of Naqala is up for grabs! The oracles foretold of strangers who would maneuver the Five Tribes to gain influence over the legendary city-state. Will you fulfill the prophecy? Invoke the old Djinns and move the Tribes into position at the right time, and the Sultanate may become yours!",
                    PlayingTime = "40-80",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 13,
                    Language = Language.English,
                    PublisherId = 11,
                    PhotoUrl = "fivetribes.jpg"
                },
                new
                {
                    Id = 13,
                    Name = "A Game of Thrones: The Board Game (Second Edition)",
                    Price = 64.95M,
                    CategoryId = 3,
                    ProductType = ProductType.BoardGame,
                    Description = "In the second edition of A Game of Thrones: The Board Game, three to six players take on the roles of the great Houses of the Seven Kingdoms of Westeros, as they vie for control of the Iron Throne through the use of diplomacy and warfare. Based on the best-selling A Song of Ice and Fire series of fantasy novels by George R.R. Martin, A Game of Thrones is an epic board game in which it will take more than military might to win. Will you take power through force, use honeyed words to coerce your way onto the throne, or rally the townsfolk to your side? Through strategic planning, masterful diplomacy, and clever card play, spread your influence over Westeros!",
                    PlayingTime = "120-240",
                    NumberOfPlayers = "3-6",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "gameofthronesboardgame.jpg"
                },
                new
                {
                    Id = 14,
                    Name = "The Lord of the Rings: The Card Game",
                    Price = 42.95M,
                    CategoryId = 3,
                    ProductType = ProductType.CardGame,
                    Description = "The Lord of the Rings: The Card Game is a cooperative adventure game in which the players attempt to complete a scenario, each with three heroes of their choice and a deck of allies, events and attachments to support them. Each round, players send their heroes and allies to quest or to fight with enemies that engage them. However, as the heroes and allies exhaust after questing, defending, or attacking, the players' options are typically insufficient to deal with everything at once. Therefore, players need to determine whether it is more urgent to quest and make progress in the scenario while the enemy forces gain power, or to take down enemies while making no progress, not knowing what will come next.",
                    PlayingTime = "30-60",
                    NumberOfPlayers = "1-2",
                    MinimumAge = 13,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "lordoftheringscardgame.jpg"
                },
                new
                {
                    Id = 15,
                    Name = "Star Wars: Rebellion",
                    Price = 99.95M,
                    CategoryId = 5,
                    ProductType = ProductType.BoardGame,
                    Description = "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players.<br><br>Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance. You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent.",
                    PlayingTime = "180-240",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "starwarsrebellion.jpg"
                },
                new
                {
                    Id = 16,
                    Name = "Battlestar Galactica: The Board Game",
                    Price = 49.95M,
                    CategoryId = 5,
                    ProductType = ProductType.BoardGame,
                    Description = "Battlestar Galactica: The Board Game is an exciting game of mistrust, intrigue, and the struggle for survival. Based on the epic and widely-acclaimed Sci Fi Channel series, Battlestar Galactica: The Board Game puts players in the role of one of ten of their favorite characters from the show. Each playable character has their own abilities and weaknesses, and must all work together in order for humanity to have any hope of survival. However, one or more players in every game secretly side with the Cylons. Players must attempt to expose the traitor while fuel shortages, food contaminations, and political unrest threatens to tear the fleet apart.",
                    PlayingTime = "120-180",
                    NumberOfPlayers = "3-6",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "battlestargalacticaboardgame.jpg"
                },
                new
                {
                    Id = 17,
                    Name = "Harry Potter: Hogwarts Battle",
                    Price = 49.95M,
                    CategoryId = 5,
                    ProductType = ProductType.CardGame,
                    Description = "The forces of evil are threatening to overrun Hogwarts castle in Harry Potter: Hogwarts Battle, a cooperative deck-building game, and it's up to four students to ensure the safety of the school by defeating villains and consolidating their defenses. In the game, players take on the role of a Hogwarts student: Harry, Ron, Hermione or Neville, each with their own personal deck of cards that's used to acquire resources.",
                    PlayingTime = "30-60",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 11,
                    Language = Language.English,
                    PublisherId = 12,
                    PhotoUrl = "harrypotterhogwartsbattle.jpg"
                },
                new
                {
                    Id = 18,
                    Name = "Legendary Encounters: An Alien Deck Building Game",
                    Price = 59.95M,
                    CategoryId = 5,
                    ProductType = ProductType.CardGame,
                    Description = "Legendary Encounters: An Alien Deck Building Game, based on the four movies of the Alien series, is a fully cooperative game with original art. While based on the Marvel superheroes version of Legendary, the two games will be compatible but cannot be fully integrated.<br><br>Legendary Encounters is a deck-building game in the same family as Legendary: A Marvel Deck Building Game, but now players must cooperate in order to survive against hordes of aliens. Taking on the role of protagonists such as Ripley, Dallas, Bishop and Corporal Hicks, players take turns recruiting cards for their deck from a central selection in order to improve their deck and defeat Xenomorph cards that are added to the central game board.",
                    PlayingTime = "30-60",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 17,
                    Language = Language.English,
                    PublisherId = 13,
                    PhotoUrl = "legendaryencounters-alien.jpg"
                },
                new
                {
                    Id = 19,
                    Name = "Codenames",
                    Price = 17.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "In Codenames, two teams compete to see who can make contact with all of their agents first. Spymasters give one-word clues that can point to multiple words on the board. Their teammates try to guess words of the right color while avoiding those that belong to the opposing team. And everyone wants to avoid the assassin.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-8",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 14,
                    PhotoUrl = "codenames.jpg"
                },
                new
                {
                    Id = 20,
                    Name = "Sushi Go Party!",
                    Price = 22.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Sushi Go Party!, an expanded version of the best-selling card game Sushi Go!, is a party platter of mega maki, super sashimi, and endless edamame. You still earn points by picking winning sushi combos, but now you can customize each game by choosing à la carte from a menu of more than twenty delectable dishes. What's more, up to eight players can join in on the sushi-feast. Let the good times roll!",
                    PlayingTime = "20",
                    NumberOfPlayers = "2-8",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 14,
                    PhotoUrl = "sushigoparty.jpg"
                },
                new
                {
                    Id = 21,
                    Name = "Exploding Kittens: Party Pack",
                    Price = 34.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-10",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "explodingkittenspartypack.jpg"
                },
                new
                {
                    Id = 22,
                    Name = "Dixit: Odyssey",
                    Price = 26.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Game play in Dixit Odyssey matches that of Dixit: Each turn one player is the storyteller. This player secretly chooses one card in his hand, then gives a word or sentence to describe this card—but not too obviously. Each other player chooses a card in hand that matches this word/sentence and gives it to the storyteller. The storyteller then lays out the cards, and all other players vote on which card belongs to the storyteller. If no one or everyone guesses the storyteller's card, the storyteller receives no points and all players receive two; otherwise the storyteller and the correct guesser(s) each receive three points. Players score one point for each vote their image receives. Players refill their hands, and the next player becomes the storyteller. When the deck runs out, the player with the most points wins.",
                    PlayingTime = "30",
                    NumberOfPlayers = "3-12",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 16,
                    PhotoUrl = "dixitodyssey.jpg"
                },
                new
                {
                    Id = 23,
                    Name = "Terraforming Mars",
                    Price = 69.95M,
                    CategoryId = 7,
                    ProductType = ProductType.BoardGame,
                    Description = "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.",
                    PlayingTime = "120",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 12,
                    Language = Language.English,
                    PublisherId = 1,
                    PhotoUrl = "terraformingmars.jpg"
                },
                new
                {
                    Id = 24,
                    Name = "Scythe",
                    Price = 79.95M,
                    CategoryId = 7,
                    ProductType = ProductType.BoardGame,
                    Description = "Scythe is an engine-building game set in an alternate-history 1920s period. It is a time of farming and war, broken hearts and rusted gears, innovation and valor. In Scythe, each player represents a character from one of five factions of Eastern Europe who are attempting to earn their fortune and claim their faction's stake in the land around the mysterious Factory. Players conquer territory, enlist new recruits, reap resources, gain villagers, build structures, and activate monstrous mechs.",
                    PlayingTime = "90-115",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 17,
                    PhotoUrl = "scythe.jpg"
                },
                new
                {
                    Id = 25,
                    Name = "T.I.M.E Stories",
                    Price = 37.95M,
                    CategoryId = 7,
                    ProductType = ProductType.BoardGame,
                    Description = "The T.I.M.E Agency protects humanity by preventing temporal faults and paradoxes from threatening the fabric of our universe. As temporal agents, you and your team will be sent into the bodies of beings from different worlds or realities to successfully complete the missions given to you. Failure is impossible, as you will be able to go back in time as many times as required.",
                    PlayingTime = "90",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 12,
                    Language = Language.English,
                    PublisherId = 18,
                    PhotoUrl = "timestories.jpg"
                },
                new
                {
                    Id = 26,
                    Name = "Game of Thrones: The Trivia Game",
                    Price = 42.95M,
                    CategoryId = 8,
                    ProductType = ProductType.CardGame,
                    Description = "Game of Thrones: The Trivia Game lets you use your knowledge to compete for the Iron Throne. You and your friends answer questions about the first four seasons of the hit HBO series in order to conquer key locations in Westeros. Whoever controls the most locations in the Seven Kingdoms wins! Choose more difficult questions to immediately gain more control over a location, accumulate resources to earn the favor of iconic characters, and cunningly make and break alliances with other players. Questions are organized by season to ensure that your game is free from spoilers. With over 1,200 questions included, you are certain to find fresh challenges and learn new details about Westeros with every game.",
                    PlayingTime = "30-60",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 18,
                    Language = Language.English,
                    PublisherId = 2,
                    PhotoUrl = "gameofthronestrivia.jpg"
                },
                new
                {
                    Id = 27,
                    Name = "iKNOW",
                    Price = 29.95M,
                    CategoryId = 8,
                    ProductType = ProductType.CardGame,
                    Description = "In the trivia game iKNOW, you get to test what other players know while trying to score for yourself. The game includes 1,600 questions in four categories, and each question comes with three hints at three levels of difficulty that reveal the answer piece by piece. Do you think you'll know the answer first – or should you let other players give the question a try?",
                    PlayingTime = "60",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 14,
                    Language = Language.Dutch,
                    PublisherId = 19,
                    PhotoUrl = "iknow.jpg"
                });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
