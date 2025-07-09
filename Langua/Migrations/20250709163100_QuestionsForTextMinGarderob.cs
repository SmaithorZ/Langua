using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsForTextMinGarderob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 37, "Vilken typ av tröja tycker personen mest om att använda?", 3, 10, "T-shirts", "Skjortor", "Hoodies ", " Stickade tröjor" },
                    { 38, "Hur ser personens favorithoodie ut?", 2, 10, "Den är grå med dragkedja", "Den är mörkblå och har en stor ficka fram", "Den är röd med mönster", "Den är vit och tunn" },
                    { 39, "Vad använder personen nästan varje dag?", 1, 10, "Ett par svarta jeans", "En mönstrad skjorta", "En vinterjacka", "Ett par blå shorts" },
                    { 40, "Var förvaras mössor, vantar och halsdukar?", 4, 10, "I en låda under sängen", "På en krok bakom dörren", "I byrålådan", "På en hylla högst upp i garderoben" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
