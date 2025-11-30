using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group6_WSAD_FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBellaReason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reason",
                value: "I love attending concerts because live music feels completely different and more personal than listening at home. Over the past five years, I’ve gone to dozens of shows with friends, ranging from indie and pop concerts to full EDM festivals. I’ve seen artists like Conan Gray, Kesha, The Weeknd, COIN, The Lumineers, The Band Camino, The Driver Era, Mt. Joy, and multiple Breakaway Festivals. Concerts are one of my favorite ways to spend time because the energy, the atmosphere, and the shared experience with the crowd make every show unforgettable. I try to stay within budget and not spend more than $100 per concert, but I still prioritize going whenever I can. I already have festivals lined up for next year, and the concert I want to go to the most is Billie Eilish because she is my dream upcoming artist to see live.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reason",
                value: "Because I love live music and especially enjoy hearing indie artists perform.");
        }
    }
}
