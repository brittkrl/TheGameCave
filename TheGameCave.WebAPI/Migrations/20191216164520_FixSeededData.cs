using Microsoft.EntityFrameworkCore.Migrations;

namespace TheGameCave.WebAPI.Migrations
{
    public partial class FixSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NumberOfPlayers", "PhotoUrl" },
                values: new object[] { "1-4", "bandido.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NumberOfPlayers", "PhotoUrl" },
                values: new object[] { "", "" });
        }
    }
}
