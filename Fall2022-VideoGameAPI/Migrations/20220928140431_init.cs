using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fall2022_VideoGameAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCharacter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "MainCharacter", "Studio", "Title" },
                values: new object[] { 1, "Mario", "Nintendo", "Super Mario Brothers" });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "MainCharacter", "Studio", "Title" },
                values: new object[] { 2, "Kirby", "Hal Laboratories", "Kirby: Nightmare In Dreamland" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
