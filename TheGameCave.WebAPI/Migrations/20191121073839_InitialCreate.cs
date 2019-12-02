using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheGameCave.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PhotoUrl = table.Column<string>(maxLength: 250, nullable: true),
                    ProductType = table.Column<int>(nullable: false),
                    PlayingTime = table.Column<string>(nullable: true),
                    NumberOfPlayers = table.Column<string>(nullable: true),
                    MinimumAge = table.Column<int>(nullable: false),
                    Language = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adventure" },
                    { 2, "Dice" },
                    { 3, "Fantasy" },
                    { 4, "Horror" },
                    { 5, "Movie / TV theme" },
                    { 6, "Party games" },
                    { 7, "Science Fiction" },
                    { 8, "Trivia" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 17, "Stonemaier Games" },
                    { 16, "Libellud" },
                    { 15, "The Oatmeal" },
                    { 14, "White Goblin Games" },
                    { 13, "Upper Deck Entertainment" },
                    { 12, "USAopoly" },
                    { 11, "Days of Wonder" },
                    { 10, "Greater Than Games" },
                    { 6, "Matagot" },
                    { 8, "Queen Games" },
                    { 7, "999 Games" },
                    { 18, "Space Cowboys" },
                    { 5, "Portal Games" },
                    { 4, "Plaid Hat Games" },
                    { 3, "Red Raven Games" },
                    { 2, "Fantasy Flight Games" },
                    { 1, "Intrafin" },
                    { 9, "Oink Games" },
                    { 19, "Tactic" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Language", "MinimumAge", "Name", "NumberOfPlayers", "PhotoUrl", "PlayingTime", "Price", "ProductType", "PublisherId" },
                values: new object[,]
                {
                    { 23, 7, "In the 2400s, mankind begins to terraform the planet Mars. Giant corporations, sponsored by the World Government on Earth, initiate huge projects to raise the temperature, the oxygen level, and the ocean coverage until the environment is habitable. In Terraforming Mars, you play one of those corporations and work together in the terraforming process, but compete for getting victory points that are awarded not only for your contribution to the terraforming, but also for advancing human infrastructure throughout the solar system, and doing other commendable things.", 0, 12, "Terraforming Mars", "1-5", "terraformingmars.jpg", "120", 69.95m, 0, 1 },
                    { 24, 7, "Scythe is an engine-building game set in an alternate-history 1920s period. It is a time of farming and war, broken hearts and rusted gears, innovation and valor. In Scythe, each player represents a character from one of five factions of Eastern Europe who are attempting to earn their fortune and claim their faction's stake in the land around the mysterious Factory. Players conquer territory, enlist new recruits, reap resources, gain villagers, build structures, and activate monstrous mechs.", 0, 14, "Scythe", "1-5", "scythe.jpg", "90-115", 79.95m, 0, 17 },
                    { 22, 6, "Game play in Dixit Odyssey matches that of Dixit: Each turn one player is the storyteller. This player secretly chooses one card in his hand, then gives a word or sentence to describe this card—but not too obviously. Each other player chooses a card in hand that matches this word/sentence and gives it to the storyteller. The storyteller then lays out the cards, and all other players vote on which card belongs to the storyteller. If no one or everyone guesses the storyteller's card, the storyteller receives no points and all players receive two; otherwise the storyteller and the correct guesser(s) each receive three points. Players score one point for each vote their image receives. Players refill their hands, and the next player becomes the storyteller. When the deck runs out, the player with the most points wins.", 0, 8, "Dixit: Odyssey", "3-12", "dixitodyssey.jpg", "30", 26.95m, 1, 16 },
                    { 21, 6, "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.", 0, 7, "Exploding Kittens: Party Pack", "2-10", "explodingkittenspartypack.jpg", "15", 34.95m, 1, 15 },
                    { 20, 6, "Sushi Go Party!, an expanded version of the best-selling card game Sushi Go!, is a party platter of mega maki, super sashimi, and endless edamame. You still earn points by picking winning sushi combos, but now you can customize each game by choosing à la carte from a menu of more than twenty delectable dishes. What's more, up to eight players can join in on the sushi-feast. Let the good times roll!", 0, 8, "Sushi Go Party!", "2-8", "sushigoparty.jpg", "20", 22.95m, 1, 14 },
                    { 19, 6, "In Codenames, two teams compete to see who can make contact with all of their agents first. Spymasters give one-word clues that can point to multiple words on the board. Their teammates try to guess words of the right color while avoiding those that belong to the opposing team. And everyone wants to avoid the assassin.", 0, 14, "Codenames", "2-8", "codenames.jpg", "15", 17.95m, 1, 14 },
                    { 18, 5, "Legendary Encounters: An Alien Deck Building Game, based on the four movies of the Alien series, is a fully cooperative game with original art. While based on the Marvel superheroes version of Legendary, the two games will be compatible but cannot be fully integrated.<br><br>Legendary Encounters is a deck-building game in the same family as Legendary: A Marvel Deck Building Game, but now players must cooperate in order to survive against hordes of aliens. Taking on the role of protagonists such as Ripley, Dallas, Bishop and Corporal Hicks, players take turns recruiting cards for their deck from a central selection in order to improve their deck and defeat Xenomorph cards that are added to the central game board.", 0, 17, "Legendary Encounters: An Alien Deck Building Game", "1-5", "legendaryencounters-alien.jpg", "30-60", 59.95m, 1, 13 },
                    { 17, 5, "The forces of evil are threatening to overrun Hogwarts castle in Harry Potter: Hogwarts Battle, a cooperative deck-building game, and it's up to four students to ensure the safety of the school by defeating villains and consolidating their defenses. In the game, players take on the role of a Hogwarts student: Harry, Ron, Hermione or Neville, each with their own personal deck of cards that's used to acquire resources.", 0, 11, "Harry Potter: Hogwarts Battle", "2-4", "harrypotterhogwartsbattle.jpg", "30-60", 49.95m, 1, 12 },
                    { 12, 3, "Crossing into the Land of 1001 Nights, your caravan arrives at the fabled Sultanate of Naqala. The old sultan just died and control of Naqala is up for grabs! The oracles foretold of strangers who would maneuver the Five Tribes to gain influence over the legendary city-state. Will you fulfill the prophecy? Invoke the old Djinns and move the Tribes into position at the right time, and the Sultanate may become yours!", 0, 13, "Five Tribes", "2-4", "fivetribes.jpg", "40-80", 44.95m, 0, 11 },
                    { 11, 3, "Spirit Island is a complex and thematic cooperative game about defending your island home from colonizing Invaders. Players are different spirits of the land, each with its own unique elemental powers. Every turn, players simultaneously choose which of their power cards to play, paying energy to do so. Using combinations of power cards that match a spirit's elemental affinities can grant free bonus effects. Faster powers take effect immediately, before the Invaders spread and ravage, but other magics are slower, requiring forethought and planning to use effectively. In the Spirit phase, spirits gain energy, and choose how / whether to Grow: to reclaim used power cards, to seek for new power, or to spread presence into new areas of the island.", 0, 13, "Spirit Island", "1-4", "spiritisland.jpg", "90-120", 79.95m, 0, 10 },
                    { 10, 2, "A group of poor explorers hoping to get rich quickly heads out to recover treasures from some undersea ruins. They're all rivals, but their budgets force them all to share a single rented submarine. In the rented submarine, they all have to share a single tank of air, as well. If they don't get back to the sub before they run out of air, they'll drop all their treasure. Now it's time to see who can bring home the greatest riches.", 0, 8, "Deep Sea Adventure", "2-6", "deepseaadventure.jpg", "30", 9.95m, 0, 9 },
                    { 9, 2, "Escape: The Curse of the Temple is a cooperative game in which players must escape (yes...) from a temple (yes...) which is cursed (yes...) before the temple collapses and kills one or more explorers, thereby causing everyone to lose.", 0, 8, "Escape: The Curse of the Temple", "1-5", "escapethecurseofthetemple.jpg", "10", 43.95m, 0, 8 },
                    { 25, 7, "The T.I.M.E Agency protects humanity by preventing temporal faults and paradoxes from threatening the fabric of our universe. As temporal agents, you and your team will be sent into the bodies of beings from different worlds or realities to successfully complete the missions given to you. Failure is impossible, as you will be able to go back in time as many times as required.", 0, 12, "T.I.M.E Stories", "2-4", "timestories.jpg", "90", 37.95m, 0, 18 },
                    { 8, 2, "Choose your dice well in Clever to enter them into the matching colored area, put together tricky chain-scoring opportunities, and rack up the points. The dice you don't use are as important as what you do because every die that's smaller than the chosen one can be used by the other players, keeping everyone in the game at all times.", 1, 8, "Clever", "1-4", "mansionsofmadness2.jpg", "30", 13.95m, 0, 7 },
                    { 6, 1, "Robinson Crusoe: Adventures on the Cursed Island is an epic game from Portal. You will build a shelter, palisade, weapons, you will create tools like axes, knives, sacks, you will do everything you can to… to survive. You will have to find food, fight wild beasts, protect yourself from weather changes…", 0, 14, "Robinson Crusoe: Adventures on the Cursed Island", "1-4", "robinsoncrusoe.jpg", "60-120", 36.95m, 0, 5 },
                    { 5, 1, "Stuffed Fables is an unusual adventure game in which players take on the roles of brave stuffies seeking to save the child they love from a scheming, evil mastermind. Make daring melee attacks, leap across conveyor belts, or even steer a racing wagon down a peril-filled hill. The game delivers a thrilling narrative driven by player choices. Players explore a world of wonder and danger, unlocking curious discoveries. The chapters of Stuffed Fables explore the many milestones of a child's life, creating a memorable tale ideal for families, as well as groups of adults who haven't forgotten their childlike sense of wonder.", 0, 7, "Stuffed Fables", "2-4", "stuffedfables.jpg", "60-90", 55.95m, 0, 4 },
                    { 4, 1, "Your last village was ransacked by barbarians. You barely had time to pick up the baby and your favorite fishing pole before they started the burning and pillaging. You wandered over a cruel desert, braved frozen peaks, and even paddled a log across a rough sea, kicking at the sharks whenever they got too close, the baby strapped tightly to your back.", 0, 13, "Above and Below", "2-4", "aboveandbelow.jpg", "90", 39.95m, 0, 3 },
                    { 26, 8, "Game of Thrones: The Trivia Game lets you use your knowledge to compete for the Iron Throne. You and your friends answer questions about the first four seasons of the hit HBO series in order to conquer key locations in Westeros. Whoever controls the most locations in the Seven Kingdoms wins! Choose more difficult questions to immediately gain more control over a location, accumulate resources to earn the favor of iconic characters, and cunningly make and break alliances with other players. Questions are organized by season to ensure that your game is free from spoilers. With over 1,200 questions included, you are certain to find fresh challenges and learn new details about Westeros with every game.", 0, 18, "Game of Thrones: The Trivia Game", "2-4", "gameofthronestrivia.jpg", "30-60", 42.95m, 1, 2 },
                    { 16, 5, "Battlestar Galactica: The Board Game is an exciting game of mistrust, intrigue, and the struggle for survival. Based on the epic and widely-acclaimed Sci Fi Channel series, Battlestar Galactica: The Board Game puts players in the role of one of ten of their favorite characters from the show. Each playable character has their own abilities and weaknesses, and must all work together in order for humanity to have any hope of survival. However, one or more players in every game secretly side with the Cylons. Players must attempt to expose the traitor while fuel shortages, food contaminations, and political unrest threatens to tear the fleet apart.", 0, 14, "Battlestar Galactica: The Board Game", "3-6", "battlestargalacticaboardgame.jpg", "120-180", 49.95m, 0, 2 },
                    { 15, 5, "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players.<br><br>Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance. You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent.", 0, 14, "Star Wars: Rebellion", "2-4", "starwarsrebellion.jpg", "180-240", 99.95m, 0, 2 },
                    { 14, 3, "The Lord of the Rings: The Card Game is a cooperative adventure game in which the players attempt to complete a scenario, each with three heroes of their choice and a deck of allies, events and attachments to support them. Each round, players send their heroes and allies to quest or to fight with enemies that engage them. However, as the heroes and allies exhaust after questing, defending, or attacking, the players' options are typically insufficient to deal with everything at once. Therefore, players need to determine whether it is more urgent to quest and make progress in the scenario while the enemy forces gain power, or to take down enemies while making no progress, not knowing what will come next.", 0, 13, "The Lord of the Rings: The Card Game", "1-2", "lordoftheringscardgame.jpg", "30-60", 42.95m, 1, 2 },
                    { 13, 3, "In the second edition of A Game of Thrones: The Board Game, three to six players take on the roles of the great Houses of the Seven Kingdoms of Westeros, as they vie for control of the Iron Throne through the use of diplomacy and warfare. Based on the best-selling A Song of Ice and Fire series of fantasy novels by George R.R. Martin, A Game of Thrones is an epic board game in which it will take more than military might to win. Will you take power through force, use honeyed words to coerce your way onto the throne, or rally the townsfolk to your side? Through strategic planning, masterful diplomacy, and clever card play, spread your influence over Westeros!", 0, 14, "A Game of Thrones: The Board Game (Second Edition)", "3-6", "gameofthronesboardgame.jpg", "120-240", 64.95m, 0, 2 },
                    { 3, 4, "Eldritch Horror is a cooperative game of terror and adventure in which one to eight players take the roles of globetrotting investigators working to solve mysteries, gather clues, and protect the world from an Ancient One – that is, an elder being intent on destroying our world. Each Ancient One comes with its own unique decks of Mystery and Research cards, which draw you deeper into the lore surrounding each loathsome creature. Discover the true name of Azathoth or battle Cthulhu on the high seas.", 0, 14, "Eldritch Horror", "1-8", "eldritchhorror.jpg", "120-240", 59.95m, 0, 2 },
                    { 2, 4, "Something evil stirs in Arkham, and only you can stop it. Blurring the traditional lines between roleplaying and card game experiences, Arkham Horror: The Card Game is a Living Card Game of Lovecraftian mystery, monsters, and madness!", 0, 14, "Arkham Horror: The Card Game", "1-2", "arkhamhorrorcardgame.jpg", "60-120", 39.95m, 1, 2 },
                    { 1, 4, "Mansions of Madness: Second Edition is a fully cooperative, app-driven board game of horror and mystery for one to five players that takes place in the same universe as Eldritch Horror and Elder Sign. Let the immersive app guide you through the veiled streets of Innsmouth and the haunted corridors of Arkham's cursed mansions as you search for answers and respite. Eight brave investigators stand ready to confront four scenarios of fear and mystery, collecting weapons, tools, and information, solving complex puzzles, and fighting monsters, insanity, and death. Open the door and step inside these hair-raising Mansions of Madness: Second Edition. It will take more than just survival to conquer the evils terrorizing this town.", 0, 14, "Mansions of Madness: Second Edition", "1-5", "mansionsofmadness2.jpg", "120-180", 89.95m, 0, 2 },
                    { 7, 2, "Draft dice and use the tools-of-the-trade in Sagrada to carefully construct your stained glass window masterpiece.<br><br> In more detail, each player builds a stained glass window by building up a grid of dice on their player board. Each board has some restrictions on which color or shade (value) of die can be placed there. Dice of the same shade or color may never be placed next to each other. Dice are drafted in player order, with the start player rotating each round, snaking back around after the last player drafts two dice. Scoring is variable per game based on achieving various patterns and varieties of placement...as well as bonus points for dark shades of a particular hidden goal color.", 0, 14, "Sagrada", "1-4", "sagrada.jpg", "30-45", 29.95m, 0, 6 },
                    { 27, 8, "In the trivia game iKNOW, you get to test what other players know while trying to score for yourself. The game includes 1,600 questions in four categories, and each question comes with three hints at three levels of difficulty that reveal the answer piece by piece. Do you think you'll know the answer first – or should you let other players give the question a try?", 1, 14, "iKNOW", "2-6", "iknow.jpg", "60", 29.95m, 1, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PublisherId",
                table: "Product",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
