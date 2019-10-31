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
                values: new object[] { 1, 4, "Mansions of Madness: Second Edition is a fully cooperative, app-driven board game of horror and mystery for one to five players that takes place in the same universe as Eldritch Horror and Elder Sign. Let the immersive app guide you through the veiled streets of Innsmouth and the haunted corridors of Arkham's cursed mansions as you search for answers and respite. Eight brave investigators stand ready to confront four scenarios of fear and mystery, collecting weapons, tools, and information, solving complex puzzles, and fighting monsters, insanity, and death. Open the door and step inside these hair-raising Mansions of Madness: Second Edition. It will take more than just survival to conquer the evils terrorizing this town.", 0, 14, "Mansions of Madness: Second Edition", "1-5", "mansionsofmadness2.jpg", "120-180", 89.95m, 0, 2 });

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
