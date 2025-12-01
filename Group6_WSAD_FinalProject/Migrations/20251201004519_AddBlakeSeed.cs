using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group6_WSAD_FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddBlakeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName" },
                values: new object[] { 2, "Blake" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "DifficultyLevel", "Name", "OwnerId", "Reason" },
                values: new object[] { 2, "Video Games", 1, "Gaming", 2, "Gaming is one of my favorite passtimes and I enjoy both playing alone and with friends. Genres I enjoy most include Survival, Simulation, Action/Adventure, Sports, and FPS. Some of my favorite games to play include Ark: Survival Evolved/Ascended, Elite Dangerous, RocketLeague, Deep Rock Galactic, Battlefield 6, and Rust. I have been playing video games since I was very young and started out on the PlayStation 1. One of the first games I remember playing was the original Gran Turismo and Crash Bandicoot. One of the physically oldest games I have extensively played is Toejam and Earl on the Sega Genesis. Since then, I have owned Playstation 2, 3, and 4, the Xbox 360, One, and Series X, the Nintendo DS, 3DS, WII, and Switch Lite, the Oculus Quest 1 and 2, and more recently I built a Gaming PC. Across all those systems I've likely owned or played hundreds of games and logged tens of thousands of hours playing them. " });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
