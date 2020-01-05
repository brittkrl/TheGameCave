using Microsoft.EntityFrameworkCore.Migrations;

namespace TheGameCave.WebAPI.Migrations
{
    public partial class UpdateWronglySeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OnSale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Robinson Crusoe: Adventures of the Cursed Island is a cooperative adventure game that shipwrecks players on a deserted island. Besides the more common survivor necessities (shelter, food, weapons), players will also learn through their decisions, and discoveries, that this island has many mysteries to throw at them.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Draft dice and use the tools-of-the-trade in Sagrada to carefully construct your stained glass window masterpiece. In more detail, each player builds a stained glass window by building up a grid of dice on their player board. Each board has some restrictions on which color or shade (value) of die can be placed there. Dice of the same shade or color may never be placed next to each other. Dice are drafted in player order, with the start player rotating each round, snaking back around after the last player drafts two dice. Scoring is variable per game based on achieving various patterns and varieties of placement...as well as bonus points for dark shades of a particular hidden goal color.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "OnSale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players. Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance. You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Legendary Encounters: An Alien Deck Building Game, based on the four movies of the Alien series, is a fully cooperative game with original art. While based on the Marvel superheroes version of Legendary, the two games will be compatible but cannot be fully integrated. Legendary Encounters is a deck-building game in the same family as Legendary: A Marvel Deck Building Game, but now players must cooperate in order to survive against hordes of aliens. Taking on the role of protagonists such as Ripley, Dallas, Bishop and Corporal Hicks, players take turns recruiting cards for their deck from a central selection in order to improve their deck and defeat Xenomorph cards that are added to the central game board.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "OnSale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "OnSale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Vul-Kar is back, and he’s meaner than ever. This fully restored version of the 1986 classic offers an amazing new island, a charming new narrative, stunning new components, and engaging new gameplay. Play cards to race across the island. Gather treasures and take snapshots. And, of course, blast your friends with fireballs! The new version offers more marble mayhem with a dynamic Vul-Kar figure that keeps you guessing where they’ll come out. But make sure you get back to the Hello-copter to really max out your score.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Santorini is a re-imagining of the purely abstract 2004 edition. Since its original inception over 30 years ago, Santorini has been continually developed, enhanced and refined by designer Gordon Hamilton. Santorini is an accessible strategy game, simple enough for an elementary school classroom while aiming to provide gameplay depth and content for hardcore gamers to explore, The rules are simple. Each turn consists of 2 steps: move and build. Move one of your builders into a neighboring space. You may move your Builder Pawn on the same level, step-up one level, or step down any number of levels. Then construct a building level adjacent to the builder you moved. When building on top of the third level, place a dome instead, removing that space from play. If either of your builders reaches the third level, you win.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "In the game Unstable Unicorns players start with a baby unicorn in your stable. Build your Unicorn Army as fast as you can, or be destroyed by one of your so-called friends. There are over 20 Magical Unicorns to collect, and each of them has a special power. Seek revenge or protect your stable using your Magic. The person who has a Neigh Card can send the game into madness. The first person to complete their Unicorn Army shall hereafter be known as The Righteous Ruler of All Things Magical.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OnSale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Robinson Crusoe: Adventures on the Cursed Island is an epic game from Portal. You will build a shelter, palisade, weapons, you will create tools like axes, knives, sacks, you will do everything you can to… to survive. You will have to find food, fight wild beasts, protect yourself from weather changes…");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Draft dice and use the tools-of-the-trade in Sagrada to carefully construct your stained glass window masterpiece.<br><br> In more detail, each player builds a stained glass window by building up a grid of dice on their player board. Each board has some restrictions on which color or shade (value) of die can be placed there. Dice of the same shade or color may never be placed next to each other. Dice are drafted in player order, with the start player rotating each round, snaking back around after the last player drafts two dice. Scoring is variable per game based on achieving various patterns and varieties of placement...as well as bonus points for dark shades of a particular hidden goal color.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "OnSale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Star Wars: Rebellion is a board game of epic conflict between the Galactic Empire and Rebel Alliance for two to four players.<br><br>Experience the Galactic Civil War like never before. In Rebellion, you control the entire Galactic Empire or the fledgling Rebel Alliance. You must command starships, account for troop movements, and rally systems to your cause. Given the differences between the Empire and Rebel Alliance, each side has different win conditions, and you'll need to adjust your play style depending on who you represent.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Legendary Encounters: An Alien Deck Building Game, based on the four movies of the Alien series, is a fully cooperative game with original art. While based on the Marvel superheroes version of Legendary, the two games will be compatible but cannot be fully integrated.<br><br>Legendary Encounters is a deck-building game in the same family as Legendary: A Marvel Deck Building Game, but now players must cooperate in order to survive against hordes of aliens. Taking on the role of protagonists such as Ripley, Dallas, Bishop and Corporal Hicks, players take turns recruiting cards for their deck from a central selection in order to improve their deck and defeat Xenomorph cards that are added to the central game board.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "OnSale",
                value: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "OnSale",
                value: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Welcome to Fireball Island! You may have heard stories. You may have visited when you were younger. Perhaps you even saw a fireball engulf a fellow traveler in a hellscape of horror that makes you afraid to close your eyes at night. Whatever the case, welcome back! Turns out that Vul-Kar didn't like having his gem stolen way back when, so there has been some volcanic upheaval, an explosion in our snake population, feral tigers, new types of trees bent on ending human life, and swarms of bees everywhere. But don't worry — we have top people working on it. Start your day of adventure at the helipad. Be sure to sign the waiver, which legally obligates you to take snapshots across the island. You'll race down the many paths, avoiding hazards all the while. On the plus side, you get to keep all the treasure you find. Fireball Island: The Curse of Vul-Kar is a restoration of the classic 1986 game Fireball Island that features a unique 3D island and a host of marble mayhem. This new version boasts an island that is even bigger than the original (and yet fits in a smaller box) and more marbles. It is a family-weight game for 2-4 players (5 with an expansion) that plays in 30-45 minutes. Simple card play replaces the random roll-and-move of the original, and the set collection for the treasures offers some interesting choices for players. Remember, you don't have to outrun the fireball — just the other players.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Santorini is an accessible strategy game, simple enough for an elementary school classroom while aiming to provide gameplay depth and content for hardcore gamers to explore, The rules are simple. Each turn consists of 2 steps: 1. Move - move one of your builders into a neighboring space. You may move your Builder Pawn on the same level, step-up one level, or step down any number of levels. 2. Build - Then construct a building level adjacent to the builder you moved. When building on top of the third level, place a dome instead, removing that space from play. Winning the game - If either of your builders reaches the third level, you win. Variable player powers - Santorini features variable player powers layered over an otherwise abstract game, with 40 thematic god and hero powers that fundamentally change the way the game is played.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Learn how unstable your friendships really are. You start with a Baby Unicorn in your Stable. SO CUTE! But don't get too attached, because even Baby Unicorns aren't safe in this game! There are over 20 Magical Unicorns to collect, and each has a special power. Build your Unicorn Army as fast as you can, or be destroyed by one of your so-called friends! Seek revenge or protect your stable using your Magic! Sound easy? Not so fast. Someone could have a Neigh Card (Get it? Neigh?) and send the game into MADNESS! The first person to complete their Unicorn Army shall hereafter be known as The Righteous Ruler of All Things Magical... at least until the next game. Good luck.");
        }
    }
}
