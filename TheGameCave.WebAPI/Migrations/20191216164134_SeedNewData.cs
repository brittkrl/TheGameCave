using Microsoft.EntityFrameworkCore.Migrations;

namespace TheGameCave.WebAPI.Migrations
{
    public partial class SeedNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Family" },
                    { 10, "Mystery" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "NumberOfPlayers", "PhotoUrl", "Price" },
                values: new object[] { "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck. The game gets more and more intense with each card you draw because fewer cards left in the deck means a greater chance of drawing the kitten and exploding in a fiery ball of feline hyperbole.", "Exploding Kittens", "2-5", "explodingkittens.jpg", 24.95m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Language", "MinimumAge", "Name", "NumberOfPlayers", "PhotoUrl", "PlayingTime", "Price", "ProductType", "PublisherId" },
                values: new object[,]
                {
                    { 45, 6, "The world's first dodgeball card game. Collect cards. Play your hand. Throw things at your friends. Throw Throw Burrito is what you get when you cross a card game with dodgeball. Try to collect matching sets of cards faster than your opponents while simultaneously ducking, dodging, and throwing squishy airborne burritos. The cards you collect earn points, but getting hit by flying burritos loses them. So clear some space and put away the antiques, because you’ve never played a card game quite like this before. How it works: Place a pair of burritos on a table and draw cards. Keep your cards a secret. Rack up points by finding sets of three in the deck. Find matches before anyone else does. If someone plays Burrito Cards, a Battle ensues. Steal points from your opponents by hitting them with squishy toy burritos. Declare war on your friends. Some battles only involve a handful of players. Others force the entire table to engage in a Burrito War. Duel to determine the winner. During a Burrito Duel, two players must stand back to back, walk three paces, and FIRE.", 0, 7, "Throw Throw Burrito", "2-6", "throwthrowburrito.jpg", "15", 34.95m, 1, 15 },
                    { 44, 7, "As the mega corporations are getting ready to start the terraforming process, you now have the chance to make those early choices that will come to define your corporation and set the course for the future history of Mars - this is the prelude to your greatest endeavors! In Terraforming Mars: Prelude, you choose from Prelude cards that jumpstart the terraforming process or boost your corporation's engine. There are also 5 new corporations and 7 project cards that thematically fit the early stages of terraforming a new planet. Prelude is an expansion to Terraforming Mars, and can be combined with any other Terraforming Mars expansion or variant.", 0, 12, "Terraforming Mars: Prelude", "1-5", "terraformingmarsprelude.jpg", "90-120", 18.95m, 0, 1 },
                    { 40, 2, "In the multiplayer puzzle game Railroad Ink, your goal is to connect as many exits on your board as possible. Each round, a set of dice are rolled in the middle of the table, determining which kind of road and railway routes are available to all players. You have to draw these routes on your erasable boards to create transport lines and connect your exits, trying to optimize the available symbols better than your opponents. The more exits you connect, the more points you score at the end of the game, but you lose points for each incomplete route, so plan carefully! Will you press your luck and try to stretch your transportation network to the next exit, or will you play it safe and start a new, simpler to manage route? Railroad Ink comes in two versions, each one including two expansions with additional dice sets that add special rules to your games. The Blazing Red Edition includes the Lava and Meteor expansions. Try to confine the lava coming from the erupting volcano before it destroys your routes, or deal with the havoc brought by the meteor strikes and mine the craters for precious ore. These special rules can spice up things and make each game play and feel different.", 0, 8, "Railroad Ink: Blazing Red Edition", "1-6", "railroadink-red.jpg", "20-30", 14.95m, 0, 14 },
                    { 37, 6, "Imploding Kittens is the first Expansion of Exploding Kittens, the award-winning card game that made Kickstarter history as the most-backed project, ever. This Expansion deck includes 20 new cards featuring 6 new types of actions and an Imploding Kitten which increases the game from 5 to 6 players.", 0, 7, "Imploding Kittens", "2-6", "implodingkittens.jpg", "15", 17.95m, 1, 15 },
                    { 43, 7, "Our world has widened before us. Corporations expand their operations to all corners of the solar system in pursuit of minerals and resources. Most places are not suited for terraforming, but building colonies may greatly improve your income and your possibilities in achieving that higher goal — the terraforming of Mars. Send your trade fleet to distant moons! Colonize the clouds of Jupiter! And let your Earth assets propel you to success! Terraforming Mars: Colonies, an expansion for Terraforming Mars that can be played with only the base game or with any combination of expansions, lets you visit the outer solar system. It features colony tiles where you can build colonies and send your trade fleet. It also includes new cards and corporations. ", 0, 12, "Terraforming Mars: Colonies", "1-5", "terraformingmarscolonies.jpg", "120", 26.95m, 0, 1 },
                    { 34, 1, "Welcome to Fireball Island! You may have heard stories. You may have visited when you were younger. Perhaps you even saw a fireball engulf a fellow traveler in a hellscape of horror that makes you afraid to close your eyes at night. Whatever the case, welcome back! Turns out that Vul-Kar didn't like having his gem stolen way back when, so there has been some volcanic upheaval, an explosion in our snake population, feral tigers, new types of trees bent on ending human life, and swarms of bees everywhere. But don't worry — we have top people working on it. Start your day of adventure at the helipad. Be sure to sign the waiver, which legally obligates you to take snapshots across the island. You'll race down the many paths, avoiding hazards all the while. On the plus side, you get to keep all the treasure you find. Fireball Island: The Curse of Vul-Kar is a restoration of the classic 1986 game Fireball Island that features a unique 3D island and a host of marble mayhem. This new version boasts an island that is even bigger than the original (and yet fits in a smaller box) and more marbles. It is a family-weight game for 2-4 players (5 with an expansion) that plays in 30-45 minutes. Simple card play replaces the random roll-and-move of the original, and the set collection for the treasures offers some interesting choices for players. Remember, you don't have to outrun the fireball — just the other players.", 0, 7, "Fireball Island: The Curse of Vul-Kar", "2-4", "fireballislandlegendofvulkar.jpg", "45-60", 84.95m, 0, 15 },
                    { 33, 6, "Originally an expansion for Exploding Kittens, the most successful Kickstarter project ever, that contained cards that were too horrific and/or incredible to be included in a kid safe version. As a stretch goal this was turned into a stand alone game that can be combined with the standard Exploding Kittens deck. If you combine the two decks, you can go up to 9 players. Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.", 0, 18, "Exploding Kittens: NSFW Edition", "2-5", "explodingkittens-nsfw.jpg", "15", 26.95m, 1, 15 },
                    { 30, 4, "Betrayal at House on the Hill quickly builds suspense and excitement as players explore a haunted mansion of their own design, encountering spirits and frightening omens that foretell their fate. With an estimated one hour playing time, Betrayal at House on the Hill is ideal for parties, family gatherings or casual fun with friends. Betrayal at House on the Hill is a tile game that allows players to build their own haunted house room by room, tile by tile, creating a new thrilling game board every time. The game is designed for three to six people, each of whom plays one of six possible characters. Secretly, one of the characters betrays the rest of the party, and the innocent members of the party must defeat the traitor in their midst before it’s too late! Betrayal at House on the Hill will appeal to any game player who enjoys a fun, suspenseful, and strategic game. Betrayal at House on the Hill includes detailed game pieces, including character cards, pre-painted plastic figures, and special tokens, all of which help create a spooky atmosphere and streamline game play.", 0, 12, "Betrayal at House on the Hill", "3-6", "betrayalatthehouseonthehill.jpg", "60", 34.95m, 0, 15 },
                    { 29, 8, "Bears vs Babies is a card game in which you build handsome, incredible monsters who go to war with horrible, awful babies. The shared deck of cards consists of bear parts (and other monster parts) and baby cards. When you draw a part, you use it to build a monster for yourself; when you draw a baby, it goes in the center of the table. When babies are provoked, they attack, and anyone who has fewer monster parts than the number of attacking babies loses their monster; everyone with more parts than babies defeats this infantile army and scores.", 0, 7, "Bears vs. Babies", "2-5", "bearsvsbabies.jpg", "15-20", 29.95m, 1, 15 },
                    { 36, 8, "In Imhotep, the players become builders in Egypt who want to emulate the first and best-known architect there, namely Imhotep. Over six rounds, they move wooden stones by boat to create five seminal monuments, and on a turn, a player chooses one of four actions: Procure new stones, load stones on a boat, bring a boat to a monument, or play an action card. While this sounds easy, naturally the other players constantly thwart your building plans by carrying out plans of their own. Only those with the best timing — and the stones to back up their plans — will prove to be Egypt's best builder.", 0, 10, "Imhotep", "2-4", "imhotep.jpg", "40", 34.95m, 0, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "FryxGames");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Asmodee");

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 25, "Unstable Games" },
                    { 20, "Helvetiq" },
                    { 21, "Plan B Games" },
                    { 22, "Ankama" },
                    { 23, "IELLO" },
                    { 24, "Roxley" },
                    { 26, "Blue Cocker Games" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Language", "MinimumAge", "Name", "NumberOfPlayers", "PhotoUrl", "PlayingTime", "Price", "ProductType", "PublisherId" },
                values: new object[,]
                {
                    { 38, 9, "The harvest is in, and the artisans are hard at work preparing for the upcoming festival. Decorate the palace lake with floating lanterns and compete to become the most honored artisan when the festival begins. In Lanterns: The Harvest Festival, players have a hand of tiles depicting various color arrangements of floating lanterns, as well as an inventory of individual lantern cards of specific colors. When you place a tile, all players (you and your opponents) receive a lantern card corresponding to the color on the side of the tile facing them. Place carefully to earn cards and other bonuses for yourself, while also looking to deny your opponents. Players gain honor by dedicating sets of lantern cards — three pairs, for example, or all seven colors — and the player with the most honor at the end of the game wins.", 0, 8, "Lanterns: The Harvest Festival", "2-4", "lanternstheharvestfestival.jpg", "30", 19.95m, 0, 14 },
                    { 42, 9, "A long time ago at the Japanese Imperial court, the Chinese Emperor offered a giant panda bear as a symbol of peace to the Japanese Emperor. Since then, the Japanese Emperor has entrusted his court members (the players) with the difficult task of caring for the animal by tending to his bamboo garden. In Takenoko, the players will cultivate land plots, irrigate them, and grow one of the three species of bamboo (Green, Yellow, and Pink) with the help of the Imperial gardener to maintain this bamboo garden. They will have to bear with the immoderate hunger of this sacred animal for the juicy and tender bamboo. The player who manages his land plots best, growing the most bamboo while feeding the delicate appetite of the panda, will win the game.", 0, 8, "Takenoko", "2-4", "takenoko.jpg", "45", 36.95m, 0, 15 },
                    { 39, 10, "Get ready to enter the poor and dreary Whitechapel district in London 1888 – the scene of the mysterious Jack the Ripper murders – with its crowded and smelly alleys, hawkers, shouting merchants, dirty children covered in rags who run through the crowd and beg for money, and prostitutes – called 'the wretched' – on every street corner. The board game Letters from Whitechapel, which plays in 90-150 minutes, takes the players right there. One player plays Jack the Ripper, and his goal is to take five victims before being caught. The other players are police detectives who must cooperate to catch Jack the Ripper before the end of the game. The game board represents the Whitechapel area at the time of Jack the Ripper and is marked with 199 numbered circles linked together by dotted lines. During play, Jack the Ripper, the Policemen, and the Wretched are moved along the dotted lines that represent Whitechapel's streets. Jack the Ripper moves stealthily between numbered circles, while policemen move on their patrols between crossings, and the Wretched wander alone between the numbered circles.", 0, 14, "Letters from Whitechapel", "2-6", "lettersfromwhitechapel.jpg", "60", 38.95m, 0, 7 },
                    { 28, 8, "A light-security prisoner is trying to escape through tunnels starting underneath his cell. Will you be able to join forces and cards to stop him? Bandido is a cooperative game of strategy and observation for the entire family.", 0, 6, "Bandido", "", "", "60", 10.95m, 1, 20 },
                    { 31, 3, "Century: Golem Edition is a re-themed version of Century: Spice Road set in the world of Caravania. In Century: Golem Edition, players are caravan leaders who travel the famed golem road to deliver crystals to the far reaches of the world.", 0, 8, "Century: Golem Edition", "2-5", "centurygolemedition.jpg", "30-45", 29.95m, 1, 21 },
                    { 32, 2, "Your goal in Draftosaurus is to have the dino park most likely to attract visitors. To do so, you have to draft dino meeples and place them in pens that have some placement restrictions. Each turn, one of the players roll a die and this adds a constraint to which pens any other player can add their dinosaur. Draftosaurus is a quick and light drafting game in which you don't have a hand of cards that you pass around (after selecting one), but a bunch of dino meeples in the palm of your hand.", 0, 8, "Draftosaurus", "2-5", "draftosaurus.jpg", "15", 17.95m, 1, 22 },
                    { 35, 2, "In King of Tokyo, you play mutant monsters, gigantic robots, and strange aliens—all of whom are destroying Tokyo and whacking each other in order to become the one and only King of Tokyo. At the start of each turn, you roll six dice, which show the following six symbols: 1, 2, or 3 Victory Points, Energy, Heal, and Attack. Over three successive throws, choose whether to keep or discard each die in order to win victory points, gain energy, restore health, or attack other players into understanding that Tokyo is YOUR territory. The fiercest player will occupy Tokyo, and earn extra victory points, but that player can't heal and must face all the other monsters alone! Top this off with special cards purchased with energy that have a permanent or temporary effect, such as the growing of a second head which grants you an additional die, body armor, nova death ray, and more.... and it's one of the most explosive games of the year! In order to win the game, one must either destroy Tokyo by accumulating 20 victory points, or be the only surviving monster once the fighting has ended.", 0, 8, "King of Tokyo", "2-6", "kingoftokyo.jpg", "30", 29.95m, 0, 23 },
                    { 41, 9, "Santorini is an accessible strategy game, simple enough for an elementary school classroom while aiming to provide gameplay depth and content for hardcore gamers to explore, The rules are simple. Each turn consists of 2 steps: 1. Move - move one of your builders into a neighboring space. You may move your Builder Pawn on the same level, step-up one level, or step down any number of levels. 2. Build - Then construct a building level adjacent to the builder you moved. When building on top of the third level, place a dome instead, removing that space from play. Winning the game - If either of your builders reaches the third level, you win. Variable player powers - Santorini features variable player powers layered over an otherwise abstract game, with 40 thematic god and hero powers that fundamentally change the way the game is played.", 0, 8, "Santorini", "2-4", "santorini.jpg", "20", 30.95m, 0, 24 },
                    { 46, 6, "Learn how unstable your friendships really are. You start with a Baby Unicorn in your Stable. SO CUTE! But don't get too attached, because even Baby Unicorns aren't safe in this game! There are over 20 Magical Unicorns to collect, and each has a special power. Build your Unicorn Army as fast as you can, or be destroyed by one of your so-called friends! Seek revenge or protect your stable using your Magic! Sound easy? Not so fast. Someone could have a Neigh Card (Get it? Neigh?) and send the game into MADNESS! The first person to complete their Unicorn Army shall hereafter be known as The Righteous Ruler of All Things Magical... at least until the next game. Good luck.", 0, 14, "Unstable Unicorns", "2-8", "unstableunicorns.jpg", "30-45", 24.95m, 1, 25 },
                    { 47, 9, "As an architect in Welcome To..., you want to build the best new town in the United States of the 1950s by adding resources to a pool, hiring employees, and more. Welcome To... plays like a roll-and-write dice game in which you mark results on a score-sheet...but without dice. Instead you flip cards from three piles to make three different action sets with both a house number and a corresponding action from which everyone chooses one. You use the number to fill in a house on your street in numerical order. Then you take the action to increase the point value of estates you build or score points at the end for building parks and pools. Players also have the option of taking actions to alter or duplicate their house numbers. And everyone is racing to be the first to complete public goals. There's lots to do and many paths to becoming the best suburban architect in Welcome To...! Because of the communal actions, game play is simultaneous and thus supports large groups of players. With many varying strategies and completely randomized action sets, no two games will feel the same!", 0, 10, "Welcome To...", "1-12", "welcometo.jpg", "25", 19.95m, 0, 26 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "NumberOfPlayers", "PhotoUrl", "Price" },
                values: new object[] { "Exploding Kittens is a kitty-powered version of Russian Roulette. Players take turns drawing cards until someone draws an exploding kitten and loses the game. The deck is made up of cards that let you avoid exploding by peeking at cards before you draw, forcing your opponent to draw multiple cards, or shuffling the deck.", "Exploding Kittens: Party Pack", "2-10", "explodingkittenspartypack.jpg", 34.95m });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Intrafin");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "The Oatmeal");
        }
    }
}
