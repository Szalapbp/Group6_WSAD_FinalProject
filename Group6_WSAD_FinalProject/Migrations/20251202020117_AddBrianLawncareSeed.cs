using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group6_WSAD_FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddBrianLawncareSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Reason",
                value: "Gaming is one of my favorite passtimes and I enjoy both playing alone and with friends. Genres I enjoy most include Survival, Simulation, Action/Adventure, Sports, and FPS. Some of my favorite games to play include Ark: Survival Evolved/Ascended, Elite Dangerous, RocketLeague, Deep Rock Galactic, Battlefield 6, and Rust. I have been playing video games since I was very young and started out on the PlayStation 1. One of the first games I remember playing was the original Gran Turismo and Crash Bandicoot. One of the physically oldest games I have extensively played is Toejam and Earl on the Sega Genesis. Since then, I have owned Playstation 2, 3, and 4, the Xbox 360, One, and Series X, the Nintendo DS, 3DS, WII, and Switch Lite, the Oculus Quest 1 and 2, and more recently I built a Gaming PC. Across all those systems I've likely owned or played hundreds of games and logged many tens of thousands of hours playing them. ");

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "DifficultyLevel", "Name", "OwnerId", "Reason" },
                values: new object[] { 3, "Outdoor Maintenance", 1, "Lawncare", 3, "Lawncare is my main hobby because I enjoy taking a simple yard and turning it into something clean, sharp, and well-maintained. I spend a lot of time learning how different types of grass grow, how soil health affects turf quality, and how proper mowing, watering, and fertilizing can completely change the look of a yard over time. I like experimenting with different techniques, such as changing mowing heights throughout the season, adjusting watering cycles, and using soil tests to help decide what nutrients the lawn needs. I also enjoy the physical part of the work, like edging, trimming, and keeping all the equipment in good shape. It’s rewarding to see how even small improvements add up when you stay consistent. Lawncare lets me combine hands-on work with learning new things, and I take a lot of pride in making my lawn look better every month. It’s a hobby that gives me a break from screens and technology, but still fits perfectly with my interest in tracking progress, planning, and understanding how different variables affect results." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Reason",
                value: "Gaming is one of my favorite passtimes and I enjoy both playing alone and with friends. Genres I enjoy most include Survival, Simulation, Action/Adventure, Sports, and FPS. Some of my favorite games to play include Ark: Survival Evolved/Ascended, Elite Dangerous, RocketLeague, Deep Rock Galactic, Battlefield 6, and Rust. I have been playing video games since I was very young and started out on the PlayStation 1. One of the first games I remember playing was the original Gran Turismo and Crash Bandicoot. One of the physically oldest games I have extensively played is Toejam and Earl on the Sega Genesis. Since then, I have owned Playstation 2, 3, and 4, the Xbox 360, One, and Series X, the Nintendo DS, 3DS, WII, and Switch Lite, the Oculus Quest 1 and 2, and more recently I built a Gaming PC. Across all those systems I've likely owned or played hundreds of games and logged tens of thousands of hours playing them. ");
        }
    }
}
