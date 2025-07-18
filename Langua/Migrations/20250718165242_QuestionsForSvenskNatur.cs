using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsForSvenskNatur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 62, "Hur gammal är Elin som berättar i texten?", 3, 16, "Sex år", "Sju år", "Åtta år", "Nio år" },
                    { 63, "Vad ser Elin när hon går i skogen?", 1, 16, "En ekorre som hoppar från gren till gren ", "Hjortar och rävar", "En björn och en uggla", "En bäver som bygger ett bo" },
                    { 64, "Vad gör Elin vid sjön?", 4, 16, "Hon badar i vattnet", "Hon fiskar med sin pappa", "Hon bygger ett sandslott", "Hon plockar en blå blomma och sätter den i håret" },
                    { 65, "Vad säger Elins mamma om naturen?", 3, 16, "Att man inte får plocka blommor", "Att naturen är tråkig på vintern", "Att vi måste ta hand om den för att den är en skatt", "Att man alltid måste ta med sig ett tält" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65);
        }
    }
}
