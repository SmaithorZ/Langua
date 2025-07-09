using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsForTextErikSkriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 33, "Var bor Erik och med vem?", 3, 9, "I Stockholm med sina föräldrar", "I Malmö ensam", "I Göteborg med sin sambo", "I Uppsala med sin syster" },
                    { 34, "Vilket jobb söker Erik?", 2, 9, "Säljare", "Kundserviceassistent", "Lärare", "Systemutvecklare" },
                    { 35, "Vad är några av Eriks styrkor enligt brevet?", 3, 9, "Kreativ, spontan och sportig", "Ansvarsfull, noggrann och tystlåten", "Tålamodig, ansvarsfull och noggrann", "Självsäker, envis och flexibel" },
                    { 36, "Vad lärde sig Erik på sitt tidigare jobb på callcenter?", 3, 9, "Att använda Excel och PowerPoint", "Att jobba hemifrån", "Att hantera stress och vara vänlig i svåra situationer", "Att sälja produkter via e-post" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
