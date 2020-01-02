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
                    new Category { Id = 8, Name = "Trivia" },
                    new Category { Id = 9, Name = "Family" },
                    new Category { Id = 10, Name = "Mystery" }
                );

            modelBuilder.Entity<Publisher>()
                .ToTable("Publisher")
                .HasData(
                    new Publisher { Id = 1, Name = "FryxGames" },
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
                    new Publisher { Id = 15, Name = "Asmodee" },
                    new Publisher { Id = 16, Name = "Libellud" },
                    new Publisher { Id = 17, Name = "Stonemaier Games" },
                    new Publisher { Id = 18, Name = "Space Cowboys" },
                    new Publisher { Id = 19, Name = "Tactic" },
                    new Publisher { Id = 20, Name = "Helvetiq" },
                    new Publisher { Id = 21, Name = "Plan B Games" },
                    new Publisher { Id = 22, Name = "Ankama" },
                    new Publisher { Id = 23, Name = "IELLO" },
                    new Publisher { Id = 24, Name = "Roxley" },
                    new Publisher { Id = 25, Name = "Unstable Games" },
                    new Publisher { Id = 26, Name = "Blue Cocker Games" }
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
                    PhotoUrl = "mansionsofmadness2.jpg",
                    OnSale = true
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
                    PhotoUrl = "arkhamhorrorcardgame.jpg",
                    OnSale = false
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
                    PhotoUrl = "eldritchhorror.jpg",
                    OnSale = false
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
                    PhotoUrl = "aboveandbelow.jpg",
                    OnSale = false
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
                    PhotoUrl = "stuffedfables.jpg",
                    OnSale = false
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
                    PhotoUrl = "robinsoncrusoe.jpg",
                    OnSale = false
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
                    PhotoUrl = "sagrada.jpg",
                    OnSale = false
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
                    PhotoUrl = "clever.jpg",
                    OnSale = false
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
                    PhotoUrl = "escapethecurseofthetemple.jpg",
                    OnSale = false
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
                    PhotoUrl = "deepseaadventure.jpg",
                    OnSale = false
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
                    PhotoUrl = "spiritisland.jpg",
                    OnSale = true
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
                    PhotoUrl = "fivetribes.jpg",
                    OnSale = false
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
                    PhotoUrl = "gameofthronesboardgame.jpg",
                    OnSale = false
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
                    PhotoUrl = "lordoftheringscardgame.jpg",
                    OnSale = false
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
                    PhotoUrl = "starwarsrebellion.jpg",
                    OnSale = true
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
                    PhotoUrl = "battlestargalacticaboardgame.jpg",
                    OnSale = false
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
                    PhotoUrl = "harrypotterhogwartsbattle.jpg",
                    OnSale = false
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
                    PhotoUrl = "legendaryencounters-alien.jpg",
                    OnSale = true
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
                    PhotoUrl = "codenames.jpg",
                    OnSale = false
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
                    PhotoUrl = "sushigoparty.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 21,
                    Name = "Exploding Kittens",
                    Price = 24.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck. The game gets more and more intense with each card you draw because fewer cards left in the deck means a greater chance of drawing the kitten and exploding in a fiery ball of feline hyperbole.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-5",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "explodingkittens.jpg",
                    OnSale = false
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
                    PhotoUrl = "dixitodyssey.jpg",
                    OnSale = false
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
                    PhotoUrl = "terraformingmars.jpg",
                    OnSale = true
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
                    PhotoUrl = "scythe.jpg",
                    OnSale = false
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
                    PhotoUrl = "timestories.jpg",
                    OnSale = false
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
                    PhotoUrl = "gameofthronestrivia.jpg",
                    OnSale = true
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
                    PhotoUrl = "iknow.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 28,
                    Name = "Bandido",
                    Price = 10.95M,
                    CategoryId = 8,
                    ProductType = ProductType.CardGame,
                    Description = "A light-security prisoner is trying to escape through tunnels starting underneath his cell. Will you be able to join forces and cards to stop him? Bandido is a cooperative game of strategy and observation for the entire family.",
                    PlayingTime = "60",
                    NumberOfPlayers = "1-4",
                    MinimumAge = 6,
                    Language = Language.English,
                    PublisherId = 20,
                    PhotoUrl = "bandido.jpg",
                    OnSale = false
                }, new
                {
                    Id = 29,
                    Name = "Bears vs. Babies",
                    Price = 29.95M,
                    CategoryId = 8,
                    ProductType = ProductType.CardGame,
                    Description = "Bears vs Babies is a card game in which you build handsome, incredible monsters who go to war with horrible, awful babies. The shared deck of cards consists of bear parts (and other monster parts) and baby cards. When you draw a part, you use it to build a monster for yourself; when you draw a baby, it goes in the center of the table. When babies are provoked, they attack, and anyone who has fewer monster parts than the number of attacking babies loses their monster; everyone with more parts than babies defeats this infantile army and scores.",
                    PlayingTime = "15-20",
                    NumberOfPlayers = "2-5",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "bearsvsbabies.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 30,
                    Name = "Betrayal at House on the Hill",
                    Price = 34.95M,
                    CategoryId = 4,
                    ProductType = ProductType.BoardGame,
                    Description = "Betrayal at House on the Hill quickly builds suspense and excitement as players explore a haunted mansion of their own design, encountering spirits and frightening omens that foretell their fate. With an estimated one hour playing time, Betrayal at House on the Hill is ideal for parties, family gatherings or casual fun with friends. Betrayal at House on the Hill is a tile game that allows players to build their own haunted house room by room, tile by tile, creating a new thrilling game board every time. The game is designed for three to six people, each of whom plays one of six possible characters. Secretly, one of the characters betrays the rest of the party, and the innocent members of the party must defeat the traitor in their midst before it’s too late! Betrayal at House on the Hill will appeal to any game player who enjoys a fun, suspenseful, and strategic game. Betrayal at House on the Hill includes detailed game pieces, including character cards, pre-painted plastic figures, and special tokens, all of which help create a spooky atmosphere and streamline game play.",
                    PlayingTime = "60",
                    NumberOfPlayers = "3-6",
                    MinimumAge = 12,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "betrayalatthehouseonthehill.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 31,
                    Name = "Century: Golem Edition",
                    Price = 29.95M,
                    CategoryId = 3,
                    ProductType = ProductType.CardGame,
                    Description = "Century: Golem Edition is a re-themed version of Century: Spice Road set in the world of Caravania. In Century: Golem Edition, players are caravan leaders who travel the famed golem road to deliver crystals to the far reaches of the world.",
                    PlayingTime = "30-45",
                    NumberOfPlayers = "2-5",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 21,
                    PhotoUrl = "centurygolemedition.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 32,
                    Name = "Draftosaurus",
                    Price = 17.95M,
                    CategoryId = 2,
                    ProductType = ProductType.CardGame,
                    Description = "Your goal in Draftosaurus is to have the dino park most likely to attract visitors. To do so, you have to draft dino meeples and place them in pens that have some placement restrictions. Each turn, one of the players roll a die and this adds a constraint to which pens any other player can add their dinosaur. Draftosaurus is a quick and light drafting game in which you don't have a hand of cards that you pass around (after selecting one), but a bunch of dino meeples in the palm of your hand.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-5",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 22,
                    PhotoUrl = "draftosaurus.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 33,
                    Name = "Exploding Kittens: NSFW Edition",
                    Price = 26.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Originally an expansion for Exploding Kittens, the most successful Kickstarter project ever, that contained cards that were too horrific and/or incredible to be included in a kid safe version. As a stretch goal this was turned into a stand alone game that can be combined with the standard Exploding Kittens deck. If you combine the two decks, you can go up to 9 players. Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-5",
                    MinimumAge = 18,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "explodingkittens-nsfw.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 34,
                    Name = "Fireball Island: The Curse of Vul-Kar",
                    Price = 84.95M,
                    CategoryId = 1,
                    ProductType = ProductType.BoardGame,
                    Description = "Welcome to Fireball Island! You may have heard stories. You may have visited when you were younger. Perhaps you even saw a fireball engulf a fellow traveler in a hellscape of horror that makes you afraid to close your eyes at night. Whatever the case, welcome back! Turns out that Vul-Kar didn't like having his gem stolen way back when, so there has been some volcanic upheaval, an explosion in our snake population, feral tigers, new types of trees bent on ending human life, and swarms of bees everywhere. But don't worry — we have top people working on it. Start your day of adventure at the helipad. Be sure to sign the waiver, which legally obligates you to take snapshots across the island. You'll race down the many paths, avoiding hazards all the while. On the plus side, you get to keep all the treasure you find. Fireball Island: The Curse of Vul-Kar is a restoration of the classic 1986 game Fireball Island that features a unique 3D island and a host of marble mayhem. This new version boasts an island that is even bigger than the original (and yet fits in a smaller box) and more marbles. It is a family-weight game for 2-4 players (5 with an expansion) that plays in 30-45 minutes. Simple card play replaces the random roll-and-move of the original, and the set collection for the treasures offers some interesting choices for players. Remember, you don't have to outrun the fireball — just the other players.",
                    PlayingTime = "45-60",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "fireballislandlegendofvulkar.jpg",
                    OnSale = true
                },
                new
                {
                    Id = 35,
                    Name = "King of Tokyo",
                    Price = 29.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "In King of Tokyo, you play mutant monsters, gigantic robots, and strange aliens—all of whom are destroying Tokyo and whacking each other in order to become the one and only King of Tokyo. At the start of each turn, you roll six dice, which show the following six symbols: 1, 2, or 3 Victory Points, Energy, Heal, and Attack. Over three successive throws, choose whether to keep or discard each die in order to win victory points, gain energy, restore health, or attack other players into understanding that Tokyo is YOUR territory. The fiercest player will occupy Tokyo, and earn extra victory points, but that player can't heal and must face all the other monsters alone! Top this off with special cards purchased with energy that have a permanent or temporary effect, such as the growing of a second head which grants you an additional die, body armor, nova death ray, and more.... and it's one of the most explosive games of the year! In order to win the game, one must either destroy Tokyo by accumulating 20 victory points, or be the only surviving monster once the fighting has ended.",
                    PlayingTime = "30",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 23,
                    PhotoUrl = "kingoftokyo.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 36,
                    Name = "Imhotep",
                    Price = 34.95M,
                    CategoryId = 8,
                    ProductType = ProductType.BoardGame,
                    Description = "In Imhotep, the players become builders in Egypt who want to emulate the first and best-known architect there, namely Imhotep. Over six rounds, they move wooden stones by boat to create five seminal monuments, and on a turn, a player chooses one of four actions: Procure new stones, load stones on a boat, bring a boat to a monument, or play an action card. While this sounds easy, naturally the other players constantly thwart your building plans by carrying out plans of their own. Only those with the best timing — and the stones to back up their plans — will prove to be Egypt's best builder.",
                    PlayingTime = "40",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 10,
                    Language = Language.English,
                    PublisherId = 14,
                    PhotoUrl = "imhotep.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 37,
                    Name = "Imploding Kittens",
                    Price = 17.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Imploding Kittens is the first Expansion of Exploding Kittens, the award-winning card game that made Kickstarter history as the most-backed project, ever. This Expansion deck includes 20 new cards featuring 6 new types of actions and an Imploding Kitten which increases the game from 5 to 6 players.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "implodingkittens.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 38,
                    Name = "Lanterns: The Harvest Festival",
                    Price = 19.95M,
                    CategoryId = 9,
                    ProductType = ProductType.BoardGame,
                    Description = "The harvest is in, and the artisans are hard at work preparing for the upcoming festival. Decorate the palace lake with floating lanterns and compete to become the most honored artisan when the festival begins. In Lanterns: The Harvest Festival, players have a hand of tiles depicting various color arrangements of floating lanterns, as well as an inventory of individual lantern cards of specific colors. When you place a tile, all players (you and your opponents) receive a lantern card corresponding to the color on the side of the tile facing them. Place carefully to earn cards and other bonuses for yourself, while also looking to deny your opponents. Players gain honor by dedicating sets of lantern cards — three pairs, for example, or all seven colors — and the player with the most honor at the end of the game wins.",
                    PlayingTime = "30",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 14,
                    PhotoUrl = "lanternstheharvestfestival.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 39,
                    Name = "Letters from Whitechapel",
                    Price = 38.95M,
                    CategoryId = 10,
                    ProductType = ProductType.BoardGame,
                    Description = "Get ready to enter the poor and dreary Whitechapel district in London 1888 – the scene of the mysterious Jack the Ripper murders – with its crowded and smelly alleys, hawkers, shouting merchants, dirty children covered in rags who run through the crowd and beg for money, and prostitutes – called 'the wretched' – on every street corner. The board game Letters from Whitechapel, which plays in 90-150 minutes, takes the players right there. One player plays Jack the Ripper, and his goal is to take five victims before being caught. The other players are police detectives who must cooperate to catch Jack the Ripper before the end of the game. The game board represents the Whitechapel area at the time of Jack the Ripper and is marked with 199 numbered circles linked together by dotted lines. During play, Jack the Ripper, the Policemen, and the Wretched are moved along the dotted lines that represent Whitechapel's streets. Jack the Ripper moves stealthily between numbered circles, while policemen move on their patrols between crossings, and the Wretched wander alone between the numbered circles.",
                    PlayingTime = "60",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 7,
                    PhotoUrl = "lettersfromwhitechapel.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 40,
                    Name = "Railroad Ink: Blazing Red Edition",
                    Price = 14.95M,
                    CategoryId = 2,
                    ProductType = ProductType.BoardGame,
                    Description = "In the multiplayer puzzle game Railroad Ink, your goal is to connect as many exits on your board as possible. Each round, a set of dice are rolled in the middle of the table, determining which kind of road and railway routes are available to all players. You have to draw these routes on your erasable boards to create transport lines and connect your exits, trying to optimize the available symbols better than your opponents. The more exits you connect, the more points you score at the end of the game, but you lose points for each incomplete route, so plan carefully! Will you press your luck and try to stretch your transportation network to the next exit, or will you play it safe and start a new, simpler to manage route? Railroad Ink comes in two versions, each one including two expansions with additional dice sets that add special rules to your games. The Blazing Red Edition includes the Lava and Meteor expansions. Try to confine the lava coming from the erupting volcano before it destroys your routes, or deal with the havoc brought by the meteor strikes and mine the craters for precious ore. These special rules can spice up things and make each game play and feel different.",
                    PlayingTime = "20-30",
                    NumberOfPlayers = "1-6",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 14,
                    PhotoUrl = "railroadink-red.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 41,
                    Name = "Santorini",
                    Price = 30.95M,
                    CategoryId = 9,
                    ProductType = ProductType.BoardGame,
                    Description = "Santorini is an accessible strategy game, simple enough for an elementary school classroom while aiming to provide gameplay depth and content for hardcore gamers to explore, The rules are simple. Each turn consists of 2 steps: 1. Move - move one of your builders into a neighboring space. You may move your Builder Pawn on the same level, step-up one level, or step down any number of levels. 2. Build - Then construct a building level adjacent to the builder you moved. When building on top of the third level, place a dome instead, removing that space from play. Winning the game - If either of your builders reaches the third level, you win. Variable player powers - Santorini features variable player powers layered over an otherwise abstract game, with 40 thematic god and hero powers that fundamentally change the way the game is played.",
                    PlayingTime = "20",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 24,
                    PhotoUrl = "santorini.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 42,
                    Name = "Takenoko",
                    Price = 36.95M,
                    CategoryId = 9,
                    ProductType = ProductType.BoardGame,
                    Description = "A long time ago at the Japanese Imperial court, the Chinese Emperor offered a giant panda bear as a symbol of peace to the Japanese Emperor. Since then, the Japanese Emperor has entrusted his court members (the players) with the difficult task of caring for the animal by tending to his bamboo garden. In Takenoko, the players will cultivate land plots, irrigate them, and grow one of the three species of bamboo (Green, Yellow, and Pink) with the help of the Imperial gardener to maintain this bamboo garden. They will have to bear with the immoderate hunger of this sacred animal for the juicy and tender bamboo. The player who manages his land plots best, growing the most bamboo while feeding the delicate appetite of the panda, will win the game.",
                    PlayingTime = "45",
                    NumberOfPlayers = "2-4",
                    MinimumAge = 8,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "takenoko.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 43,
                    Name = "Terraforming Mars: Colonies",
                    Price = 26.95M,
                    CategoryId = 7,
                    ProductType = ProductType.BoardGame,
                    Description = "Our world has widened before us. Corporations expand their operations to all corners of the solar system in pursuit of minerals and resources. Most places are not suited for terraforming, but building colonies may greatly improve your income and your possibilities in achieving that higher goal — the terraforming of Mars. Send your trade fleet to distant moons! Colonize the clouds of Jupiter! And let your Earth assets propel you to success! Terraforming Mars: Colonies, an expansion for Terraforming Mars that can be played with only the base game or with any combination of expansions, lets you visit the outer solar system. It features colony tiles where you can build colonies and send your trade fleet. It also includes new cards and corporations. ",
                    PlayingTime = "120",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 12,
                    Language = Language.English,
                    PublisherId = 1,
                    PhotoUrl = "terraformingmarscolonies.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 44,
                    Name = "Terraforming Mars: Prelude",
                    Price = 18.95M,
                    CategoryId = 7,
                    ProductType = ProductType.BoardGame,
                    Description = "As the mega corporations are getting ready to start the terraforming process, you now have the chance to make those early choices that will come to define your corporation and set the course for the future history of Mars - this is the prelude to your greatest endeavors! In Terraforming Mars: Prelude, you choose from Prelude cards that jumpstart the terraforming process or boost your corporation's engine. There are also 5 new corporations and 7 project cards that thematically fit the early stages of terraforming a new planet. Prelude is an expansion to Terraforming Mars, and can be combined with any other Terraforming Mars expansion or variant.",
                    PlayingTime = "90-120",
                    NumberOfPlayers = "1-5",
                    MinimumAge = 12,
                    Language = Language.English,
                    PublisherId = 1,
                    PhotoUrl = "terraformingmarsprelude.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 45,
                    Name = "Throw Throw Burrito",
                    Price = 34.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "The world's first dodgeball card game. Collect cards. Play your hand. Throw things at your friends. Throw Throw Burrito is what you get when you cross a card game with dodgeball. Try to collect matching sets of cards faster than your opponents while simultaneously ducking, dodging, and throwing squishy airborne burritos. The cards you collect earn points, but getting hit by flying burritos loses them. So clear some space and put away the antiques, because you’ve never played a card game quite like this before. How it works: Place a pair of burritos on a table and draw cards. Keep your cards a secret. Rack up points by finding sets of three in the deck. Find matches before anyone else does. If someone plays Burrito Cards, a Battle ensues. Steal points from your opponents by hitting them with squishy toy burritos. Declare war on your friends. Some battles only involve a handful of players. Others force the entire table to engage in a Burrito War. Duel to determine the winner. During a Burrito Duel, two players must stand back to back, walk three paces, and FIRE.",
                    PlayingTime = "15",
                    NumberOfPlayers = "2-6",
                    MinimumAge = 7,
                    Language = Language.English,
                    PublisherId = 15,
                    PhotoUrl = "throwthrowburrito.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 46,
                    Name = "Unstable Unicorns",
                    Price = 24.95M,
                    CategoryId = 6,
                    ProductType = ProductType.CardGame,
                    Description = "Learn how unstable your friendships really are. You start with a Baby Unicorn in your Stable. SO CUTE! But don't get too attached, because even Baby Unicorns aren't safe in this game! There are over 20 Magical Unicorns to collect, and each has a special power. Build your Unicorn Army as fast as you can, or be destroyed by one of your so-called friends! Seek revenge or protect your stable using your Magic! Sound easy? Not so fast. Someone could have a Neigh Card (Get it? Neigh?) and send the game into MADNESS! The first person to complete their Unicorn Army shall hereafter be known as The Righteous Ruler of All Things Magical... at least until the next game. Good luck.",
                    PlayingTime = "30-45",
                    NumberOfPlayers = "2-8",
                    MinimumAge = 14,
                    Language = Language.English,
                    PublisherId = 25,
                    PhotoUrl = "unstableunicorns.jpg",
                    OnSale = false
                },
                new
                {
                    Id = 47,
                    Name = "Welcome To...",
                    Price = 19.95M,
                    CategoryId = 9,
                    ProductType = ProductType.BoardGame,
                    Description = "As an architect in Welcome To..., you want to build the best new town in the United States of the 1950s by adding resources to a pool, hiring employees, and more. Welcome To... plays like a roll-and-write dice game in which you mark results on a score-sheet...but without dice. Instead you flip cards from three piles to make three different action sets with both a house number and a corresponding action from which everyone chooses one. You use the number to fill in a house on your street in numerical order. Then you take the action to increase the point value of estates you build or score points at the end for building parks and pools. Players also have the option of taking actions to alter or duplicate their house numbers. And everyone is racing to be the first to complete public goals. There's lots to do and many paths to becoming the best suburban architect in Welcome To...! Because of the communal actions, game play is simultaneous and thus supports large groups of players. With many varying strategies and completely randomized action sets, no two games will feel the same!",
                    PlayingTime = "25",
                    NumberOfPlayers = "1-12",
                    MinimumAge = 10,
                    Language = Language.English,
                    PublisherId = 26,
                    PhotoUrl = "welcometo.jpg",
                    OnSale = false
                });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
